using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<String> toppings = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(String topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }
        public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slince");
        public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

        public string GetName() => Name;
    }

    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }

    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    public class ClamPizza : Pizza
    {

    }

    public class PepperoniPizza : Pizza
    {

    }
}
