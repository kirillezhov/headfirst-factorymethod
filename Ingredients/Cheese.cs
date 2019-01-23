using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients
{
    public interface Cheese
    {
        string ToString();
    }

    public class MozarellaCheese : Cheese
    {
        public override string ToString()
        {
            return "Shredded Mozzarella";
        }
    }

    public class ReggianoCheese : Cheese
    {
        public override string ToString()
        {
            return "Reggiano Cheese";
        }
    }
}
