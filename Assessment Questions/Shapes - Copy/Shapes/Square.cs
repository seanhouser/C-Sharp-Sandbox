using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        /*
            * ======
            * FIELDS
            * ======
        */

        private double square_length;    // length of the square sides
        private double area;             // area of the square


        /*
            * =======
            * METHODS
            * =======
        */

        // Constructor
        public Square(double s_length)
        {
            square_length = s_length;
            SetArea();
        }

        //Sets the area of the Square shape
        public override void SetArea()
        {
            area = square_length * square_length;
        }


    }
}
