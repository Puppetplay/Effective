using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item29
{
    class _1_동일한결과
    {
        public void Func1()
        {
            object o = new MyOtherClass();
            MyClass c1 = o as MyClass;
            c1.MagicMethod();

            MyOtherClass c2 = o as MyOtherClass;
            c2.MagicMethod();
        }
    }

    public class MyClass
    {
        public void MagicMethod()
        {

        }
    }

    public class MyOtherClass : MyClass
    {
        public new void MagicMethod()
        {

        }
    }
}
