using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        public string SearchTerms { get; set; }

        public List<IOrderItem> Entree { get; set; }

        public List<IOrderItem> Side { get; set; }

        public List<IOrderItem> Drink { get; set; }

        public void OnGet(string SearchItem, IEnumerable<string> category,
            double? PriceMax, double? PriceMin, double? CalMax, double? CalMin)
        {
            SearchTerms = SearchItem;
            OrderItems = Menu.FullMenu();
            OrderItems = Menu.Search(OrderItems, SearchItem);
            OrderItems = Menu.FilterByCategory(OrderItems, category);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            OrderItems = Menu.FilterByCalories(OrderItems, CalMin, CalMax);

            Entree = new List<IOrderItem>();
            Drink = new List<IOrderItem>();
            Side = new List<IOrderItem>();

            foreach (IOrderItem item in OrderItems)
            {
                if (item is Entree)
                {
                    Entree.Add(item);
                }
                if (item is Drink)
                {
                    Drink.Add(item);
                }
                if (item is Side)
                {
                    Side.Add(item);
                }
            }
        }
    }
}
