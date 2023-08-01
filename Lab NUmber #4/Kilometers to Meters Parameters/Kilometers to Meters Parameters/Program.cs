using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometers_to_Meters_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues obj = new ConvertValues();
            
            Console.Write("Enter the value in Kilometers");
            double km = Convert.ToDouble(Console.ReadLine());
            
            obj.kilometerTOmeter(km);
            Console.ReadKey();
        }
    }
}
