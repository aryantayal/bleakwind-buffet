using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// list being displayed
        /// </summary>
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }
        /// <summary>
        /// the search keyword put in
        /// </summary>
        public string SearchTerms { get; set; }
        /// <summary>
        /// Entree constructor
        /// </summary>
        public List<IOrderItem> Entree { get; set; }
        /// <summary>
        /// side constructor
        /// </summary>
        public List<IOrderItem> Side { get; set; }
        /// <summary>
        /// drink constructor
        /// </summary>
        public List<IOrderItem> Drink { get; set; }

        /// <summary>
        /// The linq commands for the search
        /// </summary>
        /// <param name="SearchItem"></param>
        /// <param name="category"></param>
        /// <param name="PriceMax"></param>
        /// <param name="PriceMin"></param>
        /// <param name="CalMax"></param>
        /// <param name="CalMin"></param>
        public void OnGet(string SearchItem, IEnumerable<string> category,
            double? PriceMax, double? PriceMin, double? CalMax, double? CalMin)
        {
            OrderItems = Menu.FullMenu();
            SearchTerms = SearchItem;
            if (SearchTerms != null)
                OrderItems = OrderItems.Where(menu =>
                    menu.ToString() != null &&
                    menu.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) ||
                    menu.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));

            if (category != null && category.ToString().Length != 0)
                OrderItems = OrderItems.Where(menu =>
                {
                    foreach (var item in category)
                    {
                        if (item == "Entree" && menu is Entree) return true;

                        if (item == "Drink" && menu is Drink) return true;

                        if (item == "Side" && menu is Side) return true;
                    }

                    return false;
                });

            if (PriceMax != null && PriceMin != null)
                OrderItems = OrderItems.Where(menu => menu.Calories >= PriceMin && menu.Calories <= PriceMax);
            else if (PriceMin != null)
                OrderItems = OrderItems.Where(menu => menu.Calories >= PriceMin);
            else if (PriceMax != null) OrderItems = OrderItems.Where(menu => menu.Calories <= PriceMax);
            if (PriceMax != null && PriceMin != null)
                OrderItems = OrderItems.Where(menu => menu.Price >= CalMin && menu.Calories <= CalMax);
            else if (PriceMin != null)
                OrderItems = OrderItems.Where(menu => menu.Price >= PriceMin);
            else if (PriceMax != null) OrderItems = OrderItems.Where(menu => menu.Price <= PriceMax);

            Entree = new List<IOrderItem>();
            Drink = new List<IOrderItem>();
            Side = new List<IOrderItem>();

            foreach (var item in OrderItems)
            {
                if (item is Entree) Entree.Add(item);
                if (item is Drink) Drink.Add(item);
                if (item is Side) Side.Add(item);
            }

            /*
            SearchTerms = SearchItem;
            OrderItems = Menu.FullMenu();
            OrderItems = Menu.Search(OrderItems, SearchItem);
            OrderItems = Menu.FilterByCategory(OrderItems, category);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            OrderItems = Menu.FilterByCalories(OrderItems, CalMin, CalMax);
            */
        }
    }
}