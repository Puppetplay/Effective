using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item12
{
    class _3_사용하지말아야하는경우
    {
        int number = 0;
        String myString = null;

        private ArrayList arrayList = new ArrayList();

        public _3_사용하지말아야하는경우()
        {

        }

        public _3_사용하지말아야하는경우(int size)
        {
            arrayList = new ArrayList(size);
        }

        public _3_사용하지말아야하는경우(string str)
        {
            try
            {
                arrayList = new ArrayList(Int32.Parse(str));
            }
            catch
            {
                arrayList = new ArrayList();
            }
        }
    }
}
