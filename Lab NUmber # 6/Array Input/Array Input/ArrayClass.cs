using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Input
{
    internal class ArrayClass
    {
        public void CreateArray(int size)
        {    
            int[] arr = new int[size];

            for(int i=0;i<size;i+=2)
            {
                Console.Write("Enter the element of index {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (i + 1 < size)
                {
                    arr[i + 1] = 0;
                }
                
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
                
                
            }

            
            
        }
    }
}
