using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item3
{
    class _3_As
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
            // Null은 어떠한 형(Ref)으로도 변환가능하다.

            // As
            for (int i = 0; i < myObjects.Length; ++i)
            {
                // 형변환이 실패하면 Null리턴
                //
                string s = myObjects[i] as string;
                if (s != null)
                {
                }
                else
                {
                }
            }

            // Cast
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
