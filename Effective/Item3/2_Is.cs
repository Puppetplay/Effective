using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    class _2_Is
    {
        public void Test()
        {
            object[] myObjects = new object[6];
            myObjects[0] = new Class1();
            myObjects[1] = new Class2();
            myObjects[2] = "hello";
            myObjects[3] = 123;
            myObjects[4] = 123.4;
            myObjects[5] = null;

            for (int i = 0; i < myObjects.Length; ++i)
            {
                // 형변환이 실패하면 Null리턴
                if(myObjects[i] is string)
                {
                    string s = (string)myObjects[i];
                }
                else
                {
                    
                }
            }

        }
    }

    public class Class1
    {
    }

    public class Class2
    {
    }
}