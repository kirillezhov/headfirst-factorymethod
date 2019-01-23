using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients;

namespace FactoryMethod
{
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough() => new ThinCrustDough();

        public Sauce CreateSauce() => new MarinaraSauce();
        public Cheese CreateCheese() => new ReggianoCheese();
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();
        public Clams CreateClam() => new FreshClams();
    }

    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough() => new ThickCrustDough();

        public Sauce CreateSauce() => new PlumTomatoSauce();
        public Cheese CreateCheese() => new MozarellaCheese();
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Spinach(), new EggPlant(), new BlackOlives() };
            return veggies;
        }

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();
        public Clams CreateClam() => new FrozenClams();
    }
}
