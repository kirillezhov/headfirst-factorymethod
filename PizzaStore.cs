using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else return null;
        }
    }

    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else return null;
        }
    }
}
