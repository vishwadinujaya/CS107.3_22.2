using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Question_2
{
    internal class Multiplication:GetNumbers
    {
        public Multiplication()
        {

            int mul = Number1 * Number2;
            Console.WriteLine("Multiplication=" + mul);

        }
    }
}
