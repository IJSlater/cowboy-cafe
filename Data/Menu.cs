using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> entrees;
        private static List<IOrderItem> sides;
        private static List<IOrderItem> drinks;

        public static List<IOrderItem> FilterEntrees(string check, string name, string mincal,string maxcal,string minprice, string maxprice)
        {
            List<IOrderItem> ret = new List<IOrderItem>();
            if (check == null)
            {
                foreach (IOrderItem item in Menu.entrees)
                {
                    if (item is Entree entree)
                    {
                        ret.Add(entree);
                    }
                }
                return ret;
            }
                
            foreach (IOrderItem item in Menu.entrees)
            {
                if (item is Entree entree)
                {
                    if (entree.ToString().ToLower().Contains(name.ToLower()) || name == "" || name == "Search for Item")
                        if (entree.Calories >= Convert.ToDouble(mincal) && entree.Calories <= Convert.ToDouble(maxcal))
                            if (entree.Price >= Convert.ToDouble(minprice) && entree.Price <= Convert.ToDouble(maxprice))
                                ret.Add(entree);
                        
                }
            }

            return ret;
        
        }


        public static List<IOrderItem> FilterSides(string check, string name, string mincal, string maxcal, string minprice, string maxprice)
        {
            List<IOrderItem> ret = new List<IOrderItem>();
            if (check == null)
            {
                foreach (IOrderItem item in Menu.sides)
                {
                    if (item is Side side)
                    {
                        ret.Add(side);
                    }
                }
                return ret;
            }
            foreach (IOrderItem item in Menu.sides)
            {
                if (item is Side side)
                {
                    if (side.ToString().ToLower().Contains(name.ToLower()) || name == "" || name == "Search for Item")
                        if (side.Calories >= Convert.ToDouble(mincal) && side.Calories <= Convert.ToDouble(maxcal))
                            if (side.Price >= Convert.ToDouble(minprice) && side.Price <= Convert.ToDouble(maxprice))
                                ret.Add(side);

                }
            }

            return ret;

        }


        public static List<IOrderItem> FilterDrinks(string check, string name, string mincal, string maxcal, string minprice, string maxprice)
        {
            List<IOrderItem> ret = new List<IOrderItem>();
            if (check == null)
            {
                foreach (IOrderItem item in Menu.drinks)
                {
                    if (item is Drink drink)
                    {
                        ret.Add(drink);
                    }
                }
                return ret;
            }
            foreach (IOrderItem item in Menu.drinks)
            {
                if (item is Drink drink)
                {
                    if (drink.ToString().ToLower().Contains(name.ToLower()) || name == "" || name == "Search for Item")
                        if (drink.Calories >= Convert.ToDouble(mincal) && drink.Calories <= Convert.ToDouble(maxcal))
                            if (drink.Price >= Convert.ToDouble(minprice) && drink.Price <= Convert.ToDouble(maxprice))
                                ret.Add(drink);

                }
            }

            return ret;

        }





        static Menu()
        {
            entrees = new List<IOrderItem>();
            sides = new List<IOrderItem>();
            drinks = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new RustlersRibs());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new DakotaDoubleBurger());

            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());

            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());

        }
        public static IEnumerable<IOrderItem> Entrees() {  return entrees;  }
        public static IEnumerable<IOrderItem> Sides() { return sides; }
        public static IEnumerable<IOrderItem> Drinks() { return drinks; }

    }
}
