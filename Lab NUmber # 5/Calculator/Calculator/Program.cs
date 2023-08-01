using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result=0;

            CalculateValues objCalculate = new CalculateValues();
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division \n");

            Console.Write("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Number 1:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter Number 2:");
            float b = float.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your answer is:" + objCalculate.Addition(a,b));
                    break;
                case 2:
                    Console.WriteLine("Your answer is:" + objCalculate.Subtraction(a,b));
                    break;
                case 3:
                    Console.WriteLine("Your answer is:" + objCalculate.Multiplication(a,b));
                    break;
                case 4:
                    Console.WriteLine("Your answer is:" + objCalculate.Division(a,b));
                    break;
            }

            







            
        }
    }
}
