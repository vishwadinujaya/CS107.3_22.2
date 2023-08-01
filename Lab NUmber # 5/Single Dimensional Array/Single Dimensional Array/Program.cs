using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SDArray objSDCalc = new SDArray();

            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter value for array index {0} :",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Minimum value is" + objSDCalc.MinValue(arr));
            Console.WriteLine("Maximum value is" + objSDCalc.MaxValue(arr));
            Console.WriteLine("Average value is" + objSDCalc.Average(arr));
            Console.WriteLine("Reverse of the array is");

            int[] reverse = objSDCalc.Reverse(arr);

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(reverse[i]);

            }




        }
    }
}
