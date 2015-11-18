using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item20
{
    interface IMsg
    {
        void Message();
    }

    public class MyClass : IMsg
    {
        public virtual void Message()
        {
            Console.WriteLine("MyClass");
        }
    }

    public class MyDerivedClass : MyClass
    {
        public void Message()
        {
            Console.WriteLine("MyDerivedClass");
        }
    }

    public class MyDerivedClass2 : MyClass, IMsg
    {
        public new void Message()
        {
            Console.WriteLine("MyDerivedClass");
        }
    }

    public class _1_TestClass
    {
        public void Func1()
        {
            //MyDerivedClass d = new MyDerivedClass();
            //d.Message(); // ???
            //IMsg m = d as IMsg;
            //m.Message(); // ???

            //MyDerivedClass2 d2 = new MyDerivedClass2();
            //d2.Message(); // ???
            //IMsg m2 = d2 as IMsg;
            //m2.Message(); // ???

            MyDerivedClass d = new MyDerivedClass();
            d.Message(); // ???
            IMsg m = d as IMsg;
            m.Message(); // ???
            MyClass b = d;
            b.Message(); // ???
        }
    }

    public class MyClass2 : IMsg
    {
        public virtual void Message()
        {
            Console.WriteLine("MyClass");
        }
    }

    public abstract class MyClass3 : IMsg
    {
        public abstract void Message();
    }

    public class MyDerivedClass3 : MyClass2
    {
        public override void Message()
        {
            Console.WriteLine("MyDerivedClass");
        }
    }

    public class _1_TestClass2
    {
        public void Func1()
        {
            MyDerivedClass3 d = new MyDerivedClass3();
            d.Message(); // ???
            IMsg m = d as IMsg;
            m.Message(); // ???
            MyClass2 b = d;
            b.Message(); // ???
        }
    }
}
