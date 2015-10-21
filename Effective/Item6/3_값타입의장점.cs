using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item6_3
{
    class _3_값타입의장점
    {
        public void Func1()
        {
            //MyClass myClass = new MyClass();
            //MyData myData = myClass.Foo();
            //int value = myData.value;
            //myData.value = 1;

            MyData m = new MyData();
            MyData b = m;
        }
    }

    public class MyClass
    {
        private MyData _myData;
        public MyData Foo()
        {
            return _myData;
            //return _myData.Clone() as MyData;
            // 성능저하, 가비지 수집증가
        }
    }

    public class MyData
    {
        public int value { get; set; }

        public MyData Clone()
        {
            MyData temp = new MyData();
            temp.value = this.value;
            return temp;
        }
    }

    //// 캡슐화 위배
    //public class MyData
    //{
    //    public int value { get; set; }
    //}

}
