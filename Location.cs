using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstAssignment
{
    public class Location
    {
        //attributes
        private double XValue;
        private double YValue;

        //Constructor
        public Location(double x, double y)
        {
            XValue = x;
            YValue = y;
        }
        //behaviour
        public double GetXValue()
        {
            return XValue;
        }
        public double GetYValue()
        {
            return YValue;
        }
    }
}
