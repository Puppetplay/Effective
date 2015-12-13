using Effective04_Dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective04.Item30
{
    public class _2_CLSCompliant
    {
        private MyClass _myClassVar;
        public UInt32 Foo()
        {
            return 1;
        }

        public void Foo2(UInt32 parm)
        {

        }

        public MyClass TheProperty
        {
            get
            {
                return _myClassVar;
            }
            set
            {
                _myClassVar = value;
            }
        }
    }
   
}
