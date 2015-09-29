using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    class _1_Cast
    {
        public void Func1()
        {
            int i = 10;
            char ch = (char)i;
        }

        public void Func2()
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
                try
                {
                    string s = (string)myObjects[i];
                    if (s != null)
                    {
                    }
                    else
                    {
                    }
                }
                catch
                {
                }
            }

        }
    }
}
