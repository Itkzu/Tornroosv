using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FirstAssignment
{
    class Rectangle:Shape
    {
        //Attributes
        public float side1;
        public float side2;

        //Constructor
        public Rectangle(float side1, float side2) : base(new Location(side1, side2))
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        //Behaviour
        public void ToString()
        {
            Console.WriteLine("this is a Rectangle.");
        }
        public double CountArea()
        {
            return side1 * side2;
        }
        public float Perimeter()
        {
            return side1 + side1 + side2 + side2;
        }
    }

}
