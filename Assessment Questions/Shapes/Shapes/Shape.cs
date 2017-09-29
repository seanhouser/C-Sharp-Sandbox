using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        /*
            * ======
            * FIELDS
            * ======
        */

        private double height;
        private double width;


        /*
            * ======
            * METHODS
            * ======
        */

        //Accessors
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        //Returns the area of the shape object
        public virtual double GetArea()
        {
            Console.WriteLine("\nBase class GetArea method called\n");
            return -99;
        }
    }
}
