using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item6
{
    class _5_메모리할당차이
    {
        C c = new C();

        Mytype[] var = new Mytype[100];
    }

    public class C
    {
        private Mytype _a = new Mytype();
        private Mytype _b = new Mytype();
    }

    struct Mytype
    {

    }

    //class Mytype
    //{

    //}
}
