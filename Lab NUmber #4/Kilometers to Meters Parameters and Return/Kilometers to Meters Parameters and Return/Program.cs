using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometers_to_Meters_Parameters_and_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertobj = new ConvertValues();
            
            double kilometer;

            Console.Write("Enter the value in kilometers: ");
            kilometer = Convert.ToDouble(Console.ReadLine());
            
            Console.Write(convertobj.kilometerTOmeter(kilometer));
            Console.ReadKey();
        }
    }
}
