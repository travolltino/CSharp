using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal5Or7
{
    class Equal5Or7
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool check = (input % 5 == 0) && (input % 7 == 0);
            Console.WriteLine("The number {0} euqal for 7 and 5: {1}", input, check);
        }
    }
}
