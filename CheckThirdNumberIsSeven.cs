using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckThirdNumberIsSeven
{
    class CheckThirdNumberIsSeven
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int lenght = input.Length;
            int other;
            other = lenght - 1;
            char checkedo = '7';

            char[] result = new Char[lenght];
            char[] proba = input.ToCharArray();
            
            for ( int i = 0; i< lenght ; i++)
            {
                result[i] = proba[other];
                other -= 1;
            }
            bool itsTrue = (result[2] == checkedo);
            Console.WriteLine("The third number is 7: {0}", itsTrue);

        }
    }
}
