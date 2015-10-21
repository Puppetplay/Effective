using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item6
{
    class _5_메모리할당차이
    {
        void Fun1()
        {
            C c = new C();

            Mytype[] var = new Mytype[100];

            int a = 10;
            String.Format("{0}", a);
        }
    }

    public class C
    {
        private Mytype _a;
        private Mytype _b;
    }

    struct Mytype
    {
        int a;
        int b;
    }

    //class Mytype
    //{

    //}
}
