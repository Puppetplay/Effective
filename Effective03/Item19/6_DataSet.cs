using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    class _6_DataSet
    {
        //  DataTable을 다른구조의 자료형으로 바꿔야할때? (ex DataSet
        private DataSet _dataSetCollection = new DataSet();

        public IListSource TheCollection
        {
            get
            {
                return _dataSetCollection;
            }
        }

        public void Func1()
        {
            var col = TheCollection;
        }
    }
}
