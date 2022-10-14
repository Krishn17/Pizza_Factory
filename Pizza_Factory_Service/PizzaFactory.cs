using Pizza_Factory_Service.Pizza;

namespace Pizza_Factory_Service
{
    public class PizzaFactory
    {
        public IPizza GetPizzaFactory(string name, string topping, int baseCookingTime)
        {
            if (string.IsNullOrEmpty(topping))
            {
                throw new NullReferenceException("Pizza must have a topping");
            }

            var factory = new Dictionary<string, IPizza>
            {
                {"Stuffed Crust", new StuffedCrust(baseCookingTime, topping)},
                {"Deep Pan", new DeepPan(baseCookingTime, topping)},
                {"Thin and Crispy", new ThinAndCrispy(baseCookingTime, topping)}
            };

            return factory.FirstOrDefault(n => n.Key == name).Value ?? throw new NullReferenceException("Pizza base must exist");
        }

    }
}