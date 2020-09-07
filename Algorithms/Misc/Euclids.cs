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
        public static int FindCommonDivisor(int first, int second) 
        {
            int result = first / second;
            int rem = first % second;

            if(rem != 0)
            {
                first = second;
                second = rem;

                return FindCommonDivisor(first, second);
            }

            return result;
        }
    }
}
