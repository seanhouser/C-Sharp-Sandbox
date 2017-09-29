using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        /*
         * NOTE
         * As this abstract base class does not implement any methods, an interface would be more appropriate
         */

        
        /*
            * ======
            * METHODS
            * ======
        */

        public abstract void SetArea();     //function to calculate the area of the shape and set the area field
        public abstract double GetArea();   //function to return the area of the shape
    }
}
