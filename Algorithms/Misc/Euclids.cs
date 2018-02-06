using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Misc
{
    //Euclid's Algorithm is used to find the two most common divisor of two numbers.

    public class Euclids
    {
        public static int FindCommonDivisor(int a, int b) 
        {
            int result = a / b;
            int rem = a % b;

            if(rem != 0)
            {
                a = b;
                b = rem;

                return FindCommonDivisor(a, b);
            }

            return result;
        }
    }
}
