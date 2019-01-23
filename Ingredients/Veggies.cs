using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients
{
    public interface Veggies
    {
        string ToString();
    }

    public class Garlic : Veggies
    {
        public override string ToString()
        {
            return "Garlic";
        }
    }

    public class Onion : Veggies
    {
        public override string ToString()
        {
            return "Onion";
        }
    }

    public class Mushroom : Veggies
    {
        public override string ToString()
        {
            return "Mushroom";
        }
    }

    public class RedPepper : Veggies
    {
        public override string ToString()
        {
            return "Red Pepper";
        }
    }

    public class Spinach : Veggies
    {
        public override string ToString()
        {
            return "Spinach";
        }
    }

    public class EggPlant : Veggies
    {
        public override string ToString()
        {
            return "Egg Plant";
        }
    }

    public class BlackOlives : Veggies
    {
        public override string ToString()
        {
            return "Black Olives";
        }
    }
}
