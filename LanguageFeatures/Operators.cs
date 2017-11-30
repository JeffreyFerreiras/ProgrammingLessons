using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    class Operators
    {
        public void NullablesOperators()
        { //    ?.      ?[     ??
            var nums = Enumerable.Range(0,100).ToArray();
            int? len = nums?.Length; // used to avoid an exception if when calling a property/method on a null object
            int? first = nums?[0]; //same exept with indexers.

            string test = null;
            string rand = test ?? test; // if test not null then assign test
        }


        public void BitWiseOperators()
        {
            // <<= >>= << >> shifts bits to left or right depending on number specified.

            int x = 100;
            int a = x >> 1; //shift bits of x to right once
            a >>= 2; //shift a bits to right twice and assign to a.

            // NOTE: bits shifted to far right will be lost. ie. 011 shifted once
            // to the right is 001. In the same way when shifting to the left, the empty
            // space will be filled with a 0.

            // ~ invert bits operator
            // short is 16 bits
            short c = ~3;
            Convert.ToString(c, 2);

            // & (and) sets bits to 1 if both are 1, 0 if both are zero and 0 if they are different
            c = 3 & 5; //011 & 101 = 001
            Convert.ToString(c, 2);
            // | (or) same as above except it will assign a 1 if they are different
            c = 3 | 5; //011 | 101 = 111
            Convert.ToString(c, 2);
            // ^ (exeptional OR) sets 1 if bits are different and 0 if same.
            c = 3 ^ 5; // //011 | 101 = 110
            Convert.ToString(c, 2);
        }
    }
}
