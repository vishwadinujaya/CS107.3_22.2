using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Vector_and_Scalar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int total=0;
            int vectortotal = 0;

            Console.Write("Enter the size of the array: ");
            int size=int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int[] vectorsum = new int[size];
            int[] vectorproduct = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the value of array1[{0}]: ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < size; j++)
            {
                Console.Write("Enter the value of array2[{0}]: ", j);
                array2[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                total += array1[i];
            }

            Console.WriteLine("The Scalar Sum is: " + total);

            //Vector Sum
            for (int i = 0; i < size; i++)
            {
                vectorsum[i]= array1[i] + array2[i];
            }

            Console.Write("The Vector Sum is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(vectorsum[i]+" ");
            }

            Console.Write("\n");

            //Vector Product
            for (int i = 0; i < size; i++)
            {
                vectorproduct[i] = array1[i] * array2[i];
            }
            Console.Write("The Vector Product is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(vectorproduct[i] + " ");
            }
            Console.Write("\n");

            //Scalar Product
            for (int i = 0; i < size; i++)
            {
                vectortotal += vectorproduct[i];
            }

            Console.WriteLine("The Scalar Product is: " + vectortotal);




        }
    }
}
