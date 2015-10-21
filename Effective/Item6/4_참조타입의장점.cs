using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item6_4
{
    class _4_참조타입의장점
    {
        public void Func1()
        {
            MyClass myClass = new MyClass();
            IMyInterface myData = myClass.Foo();
            myData.Run();
        }
    }

    public class MyClass
    {
        private MyData _myData;
        public IMyInterface Foo()
        {
            return _myData as IMyInterface;
        }
    }

    public interface IMyInterface 
    {
        void Run();
    }

    public struct MyData : IMyInterface
    {
        public void Run()
        {

        }
    }

    //public class MyData : IMyInterface
    //{
    //    public void Run()
    //    {

    //    }
    //}
}
