using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item12
{
    class _1_변수초기화
    {
        private ArrayList _arrayList;

        public _1_변수초기화()
        {
           
            _arrayList = new ArrayList();
        }

        public _1_변수초기화(int a)
        {
            
            _arrayList = new ArrayList();
        }

        public _1_변수초기화(string a)
        {
            _arrayList = new ArrayList();
        }

        public _1_변수초기화(Double d)
        {
            _arrayList = new ArrayList();
        }
    }
}
