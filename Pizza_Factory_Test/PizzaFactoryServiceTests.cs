using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza_Factory;


namespace Pizza_Factory_Test
{
    public class PizzaFactoryServiceTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GetBaseNotFoundInFactory_PizzaThrowsException(string input)
        {
            var factory = new Pizza_Factory_Service.PizzaFactory();
            var ex = Assert.Throws<NullReferenceException>(() => factory.GetPizzaFactory(input, "topping", 0));
            Assert.Equal("Pizza base must exist", ex.Message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GetNoToppings_PizzaThrowsException(string input)
        {
            var factory = new Pizza_Factory_Service.PizzaFactory();
            var ex = Assert.Throws<NullReferenceException>(() => factory.GetPizzaFactory("Stuffed Crust", input, 0));
            Assert.Equal("Pizza must have a topping", ex.Message);
        }
        [Theory]
        [InlineData("Deep Pan", 2)]
        [InlineData("Stuffed Crust", 1.5)]
        [InlineData("Thin and Crispy", 1)]
        public void GetPizza_TotalCookingTimeIsCalculatedCorrectly(string pizzaName, double multiplier)
        {
            const string topping = "topping";
            var factory = new Pizza_Factory_Service.PizzaFactory();
            int baseCookingTime = 3000;
            var f = factory.GetPizzaFactory(pizzaName, topping, baseCookingTime);
            var toppingLength = "topping".Length * 100;
            Assert.Equal((baseCookingTime * multiplier) + toppingLength, f.TotalCookingTime);

        }
        [Fact]
        public void GetPizza_GetToppingReturnsToppingCorrectly()
        {
            var factory = new Pizza_Factory_Service.PizzaFactory();
            var f = factory.GetPizzaFactory("Stuffed Crust", "topping", 0);
            Assert.NotNull(f.GetTopping);
            Assert.Equal("topping", f.GetTopping);
        }
    }
}
