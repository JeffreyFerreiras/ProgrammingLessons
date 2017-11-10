using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Insertion
    {
        public static int[] InsertionSort(this int[] arry)
        {
            for(int i = 1; i < arry.Length; i++)
            {
                int inner = i;
                int val = arry[inner];

                while(inner > 0 && arry[inner - 1] > val)
                {
                    arry[inner] = arry[inner - 1];
                    inner--;
                }

                arry[inner] = val;
            }

            return arry;
        }
    }
}