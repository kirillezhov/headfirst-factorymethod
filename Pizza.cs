using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using FactoryMethod.Ingredients;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected Veggies[] veggies;
        protected Cheese Cheese;
        protected Clams Clam;

        public abstract void Prepare();
        public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slince");
        public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

        public string GetName() => Name;
        public string SetName(string name) => this.Name = name;
    }

    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }

    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clam = ingredientFactory.CreateClam();
        }
    }
}
