using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        /*
            * ======
            * FIELDS
            * ======
        */
        private double rectangle_length;    // length of the rectangle
        private double rectangle_width;     // width of the rectangle
        private double area;                // area of the rectangle


        /*
            * =======
            * METHODS
            * =======
        */

        // Constructor
        public Rectangle(double r_length, double r_width)
        {
            rectangle_length = r_length;
            rectangle_width = r_width;
            SetArea();
        }

        //Sets the area of the Rectangle shape
        public override void SetArea()
        {
            area = rectangle_width * rectangle_length;
        }


    }
}
