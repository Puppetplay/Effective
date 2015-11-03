using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item23
{
    class MyBusinessObject
    {
        private DataSet _ds;
        public DataSet Data
        {
            get { return _ds; }
        }
    }


    public class TestClass01
    {
        public void Func1()
        {
            MyBusinessObject bo = new MyBusinessObject();
            DataSet ds = bo.Data;
            ds.Tables.Clear();
        }
    }
}
