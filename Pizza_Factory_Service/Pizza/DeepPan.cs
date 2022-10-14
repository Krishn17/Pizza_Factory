using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Service.Pizza
{
    public class DeepPan : IPizza
    {
        public DeepPan(int baseCookingTime, string incomingTopping)
        {
            GetTopping = incomingTopping;
            BaseCookingTime = baseCookingTime;
        }

        public string GetPizzaName => "Deep Pan";
        public double BaseCookingTime { get; }
        public double GetMultiplier => 2;
        public string GetTopping { get; }
        public int ToppingCookingTime => GetTopping.Length * 100;
        public double TotalCookingTime => (int)(BaseCookingTime * GetMultiplier) + ToppingCookingTime;
    }
}
