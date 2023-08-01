using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;

            Console.Write("Enter the size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());

            ArrayClass objarray = new ArrayClass();

            objarray.CreateArray(size);
        }
    }
}
