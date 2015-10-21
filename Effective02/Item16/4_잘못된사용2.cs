using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item16
{
    class _4_잘못된사용2
    {
        public void Func1()
        {
            string msg = "Hello";
            msg += "Name";
            msg += ". Today is";
            msg += System.DateTime.Now.ToString();
        }

        public void Func2()
        {
            string msg = string.Format("Hello, {0}, Today is {1}", "Name", DateTime.Now.ToBinary());
        }

        public void Func3()
        {
            StringBuilder sb = new StringBuilder();
            // BraBraBra
        }
    }
}
