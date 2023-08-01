using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Question_2
{
    internal class Division:GetNumbers
    {
        public Division()
        {

            int div = Number1 / Number2;
            Console.WriteLine("Division=" + div);

        }
    }
}
