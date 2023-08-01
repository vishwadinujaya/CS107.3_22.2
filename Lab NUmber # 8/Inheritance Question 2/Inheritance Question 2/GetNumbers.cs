using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Question_2
{
    abstract class GetNumbers
    {
        protected int Number1;
        protected int Number2;

        public GetNumbers()
        {
            Console.Write("Enter 2 numbers :");
            Number1= int.Parse(Console.ReadLine());
            Number2 = int.Parse(Console.ReadLine());

        }
        

    }
}
