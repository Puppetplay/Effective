using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    public class FirstType
    {
    }

    public class SecondType
    {
        private FirstType _value;
        public static implicit operator FirstType(SecondType t)
        {
            return t._value;
        }
    }

    class _5_Example
    {
        public void Func1()
        {
            object o = new SecondType();

            // First
            FirstType t = o as FirstType;
            if (t != null)
            {

            }
            else
            {
            }

            // Second
            try
            {
                t = (FirstType)o;
                if (t != null)
                {

                }
                else
                {
                }
            }
            catch
            {
            }

            // Third
            SecondType st = o as SecondType;
            try
            {
                t = (FirstType)st;
                if (t != null)
                {

                }
                else
                {
                }
            }
            catch
            {

            }

            t = o as SecondType;
        }
    }
}
