using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Single_Dimensional_Array
{
    internal class SDArray
    {
        public int MinValue(int[]array)
        {
            int lowest = array[0];

            for (int i = 1; i < 10; i++)
            {
             
               if (array[i] < lowest)
                {
                    lowest = array[i];
                }
                
            }

            return lowest;
            
        }

        public int MaxValue(int[] array)
        {
            int highest = array[0];

            for (int i = 1; i < 10; i++)
            {

                if (array[i] > highest)
                {
                    highest = array[i];
                }

            }

            return highest;

        }

        public int Average(int[] array)
        {
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                total += array[i];

            }

            int avg = total / 10;

            return avg;

        }

        public int[] Reverse(int[] array)
        {
            int[]reverse=new int[10];
            

            for (int i = 0; i < 10; i++)
            {
                reverse[i] = array[9-i];
            }

            return reverse;
            
            

        }

    }
}
