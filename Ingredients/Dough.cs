using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients
{
    public interface Dough
    {

    }

    public class ThinCrustDough : Dough
    {
        public override string ToString()
        {
            return "ThickCrust style extra thick crust dough";
        }
    }

    public class ThickCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }
}
