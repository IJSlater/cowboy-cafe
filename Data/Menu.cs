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
