using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
     public class Circle : Shape
    {
        //Attributes
        public double Radius;
        //Constructor
        public Circle(double radius) : base(new Location(radius, radius))
        {
            Radius = radius;
        }

        //Behaviour
        public void ToString()
        {
            Console.WriteLine("this is Not a Rectangle.");
        }
        public double CountArea()
        {
            return (Radius*Radius)*3.14;
        }
        public float Perimeter()
        {
            var result = Radius+Radius+3.14;
            return (float)result;
        }
    }
    
}
