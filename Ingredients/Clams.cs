using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients
{
    public interface Clams
    {
        string ToString();
    }

    public class FrozenClams : Clams
    {
        public override string ToString()
        {
            return "Frozen Clams";
        }
    }

    public class FreshClams : Clams
    {
        public override string ToString()
        {
            return "Fresh Clams";
        }
    }
}
