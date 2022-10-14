using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Service
{
    public interface IPizza
    {
        string GetPizzaName { get; }
        double GetMultiplier { get; }
        string GetTopping { get; }
        int ToppingCookingTime { get; }

        double TotalCookingTime { get; }

    }
}
