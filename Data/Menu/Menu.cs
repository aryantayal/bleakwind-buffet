using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Xml;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    ///     A public static class that represents the menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        ///     An IEnumerable<IOrderItem> that returns all the entrees
        /// </summary>
        /// <returns>A list of the all the available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmelette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTBone());
            return entree;
        }

        /// <summary>
        ///     An IEnumerable<IOrderItem> that returns all the sides
        /// </summary>
        /// <returns>A list of the all the available sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var side = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                side.Add(new DragonbornWaffleFries
                {
                    Size = s
                });

                side.Add(new FriedMiraak
                {
                    Size = s
                });

                side.Add(new MadOtarGrits
                {
                    Size = s
                });

                side.Add(new VokunSalad
                {
                    Size = s
                });
            }

            return side;
        }

        /// <summary>
        ///     An IEnumerable<IOrderItem> that returns all the drinks
        /// </summary>
        /// <returns>A list of the available drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var drink = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drink.Add(new AretinoAppleJuice
                {
                    Size = s
                });

                drink.Add(new CandlehearthCoffee
                {
                    Size = s
                });

                drink.Add(new MarkarthMilk
                {
                    Size = s
                });

                drink.Add(new WarriorWater
                {
                    Size = s
                });

                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                    drink.Add(new SailorSoda
                    {
                        Size = s,
                        Flavor = sf
                    });
            }

            return drink;
        }

        /// <summary>
        ///     An IEnumerable<IOrderItem> that returns the full menu.
        /// </summary>
        /// <returns>A list containing all of the items on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            var menu = new List<IOrderItem>();
            var entree = Entrees();
            menu.AddRange(entree);

            var side = Sides();
            menu.AddRange(side);

            var drink = Drinks();
            menu.AddRange(drink);

            return menu;
        }

        public static IEnumerable<IOrderItem> All => FullMenu();

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> j, string terms)
        {
            var results = new List<IOrderItem>();

            if (terms == null) return j;

            foreach (var item in j)
                if (item.ToString() != null &&
                    item.ToString().ToLower().Contains(terms.ToLower()))
                    results.Add(item);

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> list,
            IEnumerable<string> category)
        {
            var results = new List<IOrderItem>();

            if (category == null || category.Count() == 0) return list;

            foreach (var item in list)
            {
                if (category.Contains("Entree"))
                    if (item is Entree.Entree)
                        results.Add(item);
                if (category.Contains("Drink"))
                    if (item is Drink)
                        results.Add(item);
                if (category.Contains("Side"))
                    if (item is Side)
                        results.Add(item);
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> list,
            double? min, double? max)
        {
            if (min == null && max == null) return list;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (var item in list)
                    if (item.Price <= max)
                        results.Add(item);
                return results;
            }

            if (max == null)
            {
                foreach (var item in list)
                    if (item.Price >= min)
                        results.Add(item);
                return results;
            }

            foreach (var item in list)
                if (item.Price >= min && item.Price <= max)
                    results.Add(item);
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> list,
            double? min, double? max)
        {
            if (min == null && max == null) return list;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (var item in list)
                    if (item.Calories <= max)
                        results.Add(item);
                return results;
            }

            if (max == null)
            {
                foreach (var item in list)
                    if (item.Calories >= min)
                        results.Add(item);
                return results;
            }

            foreach (var item in list)
                if (item.Calories >= min && item.Calories <= max)
                    results.Add(item);
            return results;
        }
    }
}