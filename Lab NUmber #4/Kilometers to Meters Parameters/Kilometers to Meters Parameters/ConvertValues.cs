using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometers_to_Meters_Parameters
{
    internal class ConvertValues
    {
        public void kilometerTOmeter(double km)
        {
            
            double meter = km * 1000;
            Console.WriteLine("The value in meters is {0}", meter);
        }
                
    }
}
