using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients
{
    public interface Sauce
    {
        string ToString();
    }

    public class MarinaraSauce : Sauce
    {
        public override string ToString()
        {
            return "Marinara Sauce";
        }
    }

    public class PlumTomatoSauce : Sauce
    {
        public override string ToString()
        {
            return "Plum Tomato Sauce";
        }
    }
}
