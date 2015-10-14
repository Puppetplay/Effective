using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item10
{
    class _1_루프비교
    {
        public void Func1()
        {
            int[] foo = new int[100];

            // 루프1
            foreach(int i in foo)
            {
                Console.WriteLine(i.ToString());
            }

            // 루프2
            for(int index = 0; index < foo.Length; index++)
            {
                Console.WriteLine(foo[index].ToString());
            }

            // 루프3
            int len = foo.Length;
            for(int index = 0; index < len; index++)
            {
                Console.WriteLine(foo[index].ToString());
            }

            // 루프3의 구조
            len = foo.Length;
            for(int index = 0; index < len; index++)
            {
                if(index < foo.Length)
                {
                    Console.WriteLine(foo[index].ToString());
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
