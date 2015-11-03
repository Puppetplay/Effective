using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item23
{
    public class MyBusinessObject2
    {
        private DataSet _ds;
        public DataView this[string tableName]
        {
            get
            {
                return _ds.DefaultViewManager.CreateDataView(_ds.Tables[tableName]);
            }
        }
    }

    public class TestClass02
    {
        public void Func1()
        {
            MyBusinessObject2 mo = new MyBusinessObject2();
            DataView v = mo["customers"];
            foreach(DataRowView r in v)
            {
                Console.WriteLine(r["name"]);
            }
        }
    }
}
