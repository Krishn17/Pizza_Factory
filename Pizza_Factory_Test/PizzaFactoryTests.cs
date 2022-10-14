using Microsoft.VisualStudio.TestPlatform.TestHost;
using Pizza_Factory;
using Pizza_Factory_Service;
using Pizza_Factory_Service.Pizza;
using Program = Pizza_Factory.Program;
using Xunit;

namespace Pizza_Factory_Test
{
    public class PizzaFactoryTests
    {
        [Fact]
        public void GetRandomItemFromList_ReturnsItemFromList()
        {
            var pizzaList = new List<string> { "Stuffed Crust", "Deep Pan", "Thin and Crispy" };
            var item = Program.GetRandomItemFromList(pizzaList);

            Assert.NotEmpty(new[] { pizzaList.Contains(item) });

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GivenNoBase_GenerateNewPizzaThrowsException(string input)
        {
            var ex = Assert.Throws<NullReferenceException>(() => Program.GenerateNewPizza(input, "topping"));
            Assert.Equal( "Pizza base must exist", ex.Message);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GetNoTopping_GenerateNewPizzaThrowsException(string input)
        {
            var ex = Assert.Throws<NullReferenceException>(() => Program.GenerateNewPizza("Deep Pan", input));
            Assert.Equal("Pizza must have a topping", ex.Message);
        }

        [Fact]
        public void GetPizzaAndTopping_GenerateNewPizzaReturnsCorrectTypeAndName()
        {
            const string name = "Deep Pan";
            var pizza = Program.GenerateNewPizza(name, "Topping");
            
            
            Assert.NotNull(pizza);;
            Assert.Equal(typeof(DeepPan),pizza.GetType());
            Assert.Equal(pizza.GetPizzaName, name);

        }

        [Fact]
        public void GetStuffedCrust_GenerateNewPizzaReturnsCorrectTypeAndName()
        {
            const string name = "Stuffed Crust";
            var pizza = Program.GenerateNewPizza(name, "Topping");
            Assert.NotNull(pizza); ;
            Assert.Equal(typeof(StuffedCrust), pizza.GetType());
            Assert.Equal(pizza.GetPizzaName, name);

        }

        [Fact]
        public void GetThinAndCrispy_GenerateNewPizzaReturnsCorrectTypeAndName()
        {
            const string name = "Thin and Crispy";
            var pizza = Program.GenerateNewPizza(name, "Topping");
            Assert.NotNull(pizza); ;
            Assert.Equal(typeof(ThinAndCrispy), pizza.GetType());
            Assert.Equal(pizza.GetPizzaName, name);

        }
    }
}