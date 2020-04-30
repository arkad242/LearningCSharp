using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp_Block5
{
    public class Calculator
    {
        public double CalcTriangleSquare(int ab, int bc, int ac)
        {

            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
                     
        }

    }
}
