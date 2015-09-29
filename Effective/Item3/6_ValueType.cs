using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    class _6_ValueType
    {
        public void Func1()
        {
            object o = 11;
            int i = 0;

            //int number = o as int;
            int? number2 = o as int?;
            if(number2.HasValue)
            {
                i = number2.Value;
            }

            //Cast
            try
            {
                i = (int)o;
            }
            catch
            {
                i = 0;
            }

            // Is
            if(o is int)
            {
                i = (int)o;
            }
        }
    }
}
