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
        private double circle_radius;       // radius of the circle
        private double circle_diameter;     // diameter of the circle
        private double area;                // area of the circle


        /*
            * =======
            * METHODS
            * =======
        */

        // Constructor
        public Circle(double radius)
        {
            circle_radius = radius;
            circle_diameter = radius * 2;
            SetArea();
        }

        //Sets the area of the Circle shape
        public override void SetArea()
        {
            area = Math.PI * (circle_radius * circle_radius);
        }


    }
}
