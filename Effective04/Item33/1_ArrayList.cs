using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective04.Item33
{
    class _1_ArrayList
    {
        public void Func1()
        {
            IEnumerable myArrayList = new MyArrayList();
            myArrayList.GetEnumerator();
        }
    }

    public class MyArrayList : IEnumerable
    {
        private class MyArrayListEnumerator : IEnumerator
        {
            public object Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MyArrayListEnumerator();
        }
    }
}
