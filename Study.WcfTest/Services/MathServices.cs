using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Study.WcfTest
{
    public class MathServices:IMath
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}