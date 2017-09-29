using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        /*
            * ======
            * FIELDS
            * ======
        */

        private double circle_radius;   // radius of the circle


        /*
            * =======
            * METHODS
            * =======
        */

        // Constructor
        public Circle(double radius)
        {
            circle_radius = radius;
        }

        //Returns the area of the shape object
        public override double GetArea()
        {
            return Math.PI * (circle_radius * circle_radius);
        }
    }
}
