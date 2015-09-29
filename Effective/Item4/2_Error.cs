using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item4
{
    class _2_Error
    {
        public void Func1()
        {
            string msg = null;
#if DEBUG
            msg = "메세지";
#endif
            Console.WriteLine(msg);
        }
    }
}
