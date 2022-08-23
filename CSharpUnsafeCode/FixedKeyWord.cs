﻿\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\LKKKKKKKKKKKKKKKKKKKKKKK7-8P.BGMHYK7UKO0UG [86D.J-*J+///////////////////////////] System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnsafeCode
{
    class Point
    {
        public int x, y;
    }

    internal class FixedKeyWord
    {
        unsafe static void SquarePrintParam(int* p)
        {
            *p *= *p;
        }

        internal unsafe static void App()
        {
            Point point = new Point
            {
                x = 5,
                y = 6
            };

            fixed (int* p = &point.x)
            {
                SquarePrintParam(p);
            }

            Console.WriteLine($"{point.x} {point.y}");
        }
    }
}
