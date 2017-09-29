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

        private double square_length;   // length of the square sides


        /*
            * =======
            * METHODS
            * =======
        */

        // Constructor
        public Square(double s_length)
        {
            square_length = s_length;
        }

        //Returns the area of the shape object
        public override double GetArea()
        {
            return square_length * square_length;
        }
    }
}
