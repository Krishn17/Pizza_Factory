using System.Collections.Generic;
using System.Configuration;

namespace Pizza_Factory
{
    public static class  Config
    {
        public static int BaseTime => int.Parse(ConfigurationManager.AppSettings["BaseTime"] ?? string.Empty);

        public static int NumberOfPizzas => int.Parse(ConfigurationManager.AppSettings["NumberOfPizzas"] ?? string.Empty);

        public static int Interval => int.Parse(ConfigurationManager.AppSettings["WaitIntervalTime"] ?? string.Empty);

        public static List<string> PizzaList = new List<string> { "Stuffed Crust", "Deep Pan", "Thin and Crispy" };

        public static List<string> ToppingList = new List<string> { "Ham and Mushroom", "Pepperoni", "Vegetable" };

    }
}
