using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item4
{
    class _1_If
    {
        private String _name;

        public void Func1()
        {
#if CAR3
            Trace.WriteLine("Enter...");

            string methodName = new StackTrace().GetFrame(1).GetMethod().Name;
            Debug.Assert(_name != null, methodName, "똑바로입력해");
            Trace.WriteLine("Exit");
#endif
        }
    }
}
