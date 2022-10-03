using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class  Shape
    {
        //Attributes
        private Location location;

        //Constructor
        public Shape(Location loc)

        {
            location = loc;
        }
        //Behaviour
        public void ToString()
        {
            Console.WriteLine("This is a shape!");
        }
        public double CountArea()
        {
            return 0;
        }
        public float Perimeter()
        {
            return 0;
        }
    }
}
