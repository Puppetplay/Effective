using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item4
{
    class _3_ConditionalAttribute
    {
        private String _name;

        [Conditional("CAR3")]
        public void Func1()
        {
            Trace.WriteLine("Enter...");

            string methodName = new StackTrace().GetFrame(1).GetMethod().Name;
            Debug.Assert(_name != null, methodName, "똑바로입력해");
            Trace.WriteLine("Exit");
        }
    }
}
