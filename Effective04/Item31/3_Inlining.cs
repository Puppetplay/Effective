using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective04.Item31
{
    class _3_Inlining
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }

    class Test
    {
        public void Func1()
        {
            _3_Inlining inlining = new _3_Inlining();
            string value = inlining.Name;
        }
    }
}
