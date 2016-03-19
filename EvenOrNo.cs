using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrNo
{
    class EvenOrNo
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool check = (input % 2 == 0);
            Console.WriteLine("The number {0} is even: {1}", input, check);
        }
    }
}
