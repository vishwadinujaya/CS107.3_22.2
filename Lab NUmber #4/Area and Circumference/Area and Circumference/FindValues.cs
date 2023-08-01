using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Circumference
{
    internal class FindValues
    {
        public double findArea(double radius){
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        
        }

        public double findCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
