/*
 * Author: Aryan Tayal
 * Class: MenuTests.cs
 * Purpose: Test the MenuTests.cs class in the Data library
 */

using System.Collections.Generic;
using System.Linq;
using BleakwindBuffet.Data;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldContainEntrees()
        {
            var entrees = (List<IOrderItem>) Menu.Entrees();

            Assert.Collection(entrees,
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString())
            );
        }

        [Fact]
        public void ShouldContainSides()
        {
            var sides = (List<IOrderItem>) Menu.Sides();

            Assert.Collection(sides,
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString())
            );
        }

        [Fact]
        public void ShouldContainDrinks()
        {
            var drinks = (List<IOrderItem>) Menu.Drinks();

            Assert.Collection(drinks,
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()),
                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString())
            );
        }

        public void ShouldBeFullMenu()
        {
            var menu = (List<IOrderItem>) Menu.FullMenu();

            Assert.Collection(menu,
                item => Assert.Contains("Brairheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),
                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()),
                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString())
            );
        }

        [Fact]
        public void NoFilterShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.Search(menu, null);
            menu = Menu.FilterByPrice(menu, null, null);
            menu = Menu.FilterByCalories(menu, null, null);
            menu = Menu.FilterByCategory(menu, null);
            Assert.Equal(49, menu.Count());
        }

        [Fact]
        public void FilteringBySearchingStringShouldGiveCorrectResults()
        {
            var f = Menu.Search(Menu.All, "Watermelon");
            var menu = (List<IOrderItem>) f;

            Assert.Collection(menu, item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()));
            Assert.Equal(3, menu.Count);
        }

        [Fact]
        public void FilteringByCategoryShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            string[] itemType = {"Entree"};
            menu = Menu.FilterByCategory(menu, itemType);

            Assert.Collection(menu,
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()));
            Assert.Equal(7, menu.Count());
        }

        [Fact]
        public void FilteringByPriceNoMinShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.FilterByPrice(menu, null, 0);

            Assert.Collection(menu,
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()));
            Assert.Equal(3, menu.Count());
        }

        [Fact]
        public void FilteringByPriceShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.FilterByPrice(menu, 6, 7);

            Assert.Collection(menu,
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()));
            Assert.Equal(2, menu.Count());
        }

        [Fact]
        public void FilteringByPriceRangeShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.FilterByPrice(menu, 8.3, null);

            Assert.Collection(menu,
                item => Assert.Contains("Thalmor Triple", item.ToString()));
            Assert.Equal(1, menu.Count());
        }

        [Fact]
        public void FilteringByCaloriesNoMinShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.FilterByCalories(menu, null, 0);

            Assert.Collection(menu,
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()));
            Assert.Equal(3, menu.Count());
        }

        [Fact]
        public void FilteringByCaloriesUnderMaxShouldGiveCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.FilterByCalories(menu, 930, null);

            Assert.Collection(menu, item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()));
            Assert.Equal(2, menu.Count());
        }

        [Fact]
        public void FilteringByCaloriesCorrectResults()
        {
            var menu = Menu.All;
            menu = Menu.FilterByCalories(menu, 50, 90);

            Assert.Collection(menu, item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()));
            Assert.Equal(7, menu.Count());
        }
    }
}