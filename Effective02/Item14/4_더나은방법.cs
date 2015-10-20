using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item14
{
    class _4_더나은방법
    {
    }

    class Defalut생성자
    {
        private int _a;

        public Defalut생성자(int a = 2)
        {
            _a = a;
        }
    }

    class Test
    {
        public void Func()
        {
            Defalut생성자 a = new Defalut생성자();
        }
    }
}
