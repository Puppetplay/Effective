using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item11
{
    class _2_Foreach장점
    {
        public void Func1()
        {
            Array test = Array.CreateInstance(typeof(int), new int[] { 5 }, new int[] { 1 });

            // 읽기전용처리

            // 다차원
            int[,] numbers = new int[8, 8];

            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    //string a = numbers[i, j].ToString();
                }
            }

            foreach(int number in numbers)
            {
                //string a = number.ToString();
            }

            List<int> a = new List<int>();
            List<int> d = new List<int>();
            foreach(int i in a)
            {
                d.Add(i);
            }



            int[] foo = new int[100];
            ArrayList f = new ArrayList(100);
            //foo.Count;
            //f.Count;
        }
    }
}
