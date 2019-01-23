using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients;

namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type); //FactoryMethod
    }

    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            var ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }

            return pizza;
        }
    }

    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            var ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chicago Style Clam Pizza");
            }

            return pizza;
        }
    }
}
