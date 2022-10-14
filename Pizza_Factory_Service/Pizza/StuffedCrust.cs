using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Service.Pizza
{
    public class StuffedCrust : IPizza
    {
        public StuffedCrust(int baseCookingTime, string incomingTopping)
        {
            GetTopping = incomingTopping;
            BaseCookingTime = baseCookingTime;
        }

        public string GetPizzaName => "Stuffed Crust";
        public double BaseCookingTime { get; }
        public double GetMultiplier => 1.5;
        public string GetTopping { get; }
        public int ToppingCookingTime => GetTopping.Length * 100;
        public double TotalCookingTime => (BaseCookingTime * GetMultiplier) + ToppingCookingTime;

    }
}
