using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Console.Write("Enter the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());

            FindValues findValues = new FindValues();

            Console.WriteLine("The area of the circle is {0}", findValues.findArea(radius));
            Console.WriteLine("The area of the circle is {0}", findValues.findCircumference(radius));
        }
    }
}
