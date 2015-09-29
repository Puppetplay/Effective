using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    class _7_중복
    {
        public void Func1()
        {
            object o = new object();
            FirstType f = null;

            // 1
            if (o is FirstType)
            {
                f = o as FirstType;
            }

            // 2
            if((o as FirstType) != null)
            {
                f = o as FirstType;
            }

            // 3
            f = o as FirstType;
            if (f != null)
            {
            }
        }
    }
}
