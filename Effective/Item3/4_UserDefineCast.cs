using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    class _4_UserDefineCast
    {
        public void Func1()
        {
            Digit dig = new Digit(7);
            double num = dig;
            Digit dig2 = 12;
        }
    }

    class Digit
    {
        public Digit(double d) { val = d; }
        public double val;

        public static implicit operator double (Digit d)
        {
            return d.val;
        }

        public static implicit operator Digit(double d)
        {
            return new Digit(d);
        }
    }
}
