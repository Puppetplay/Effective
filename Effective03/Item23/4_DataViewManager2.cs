using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item23
{
    public class MyBusinessObject3
    {
        private DataSet _ds;
        public IList this[string tableName]
        {
            get
            {
                DataView view = _ds.DefaultViewManager.CreateDataView(_ds.Tables[tableName]);
                view.AllowNew = false;
                view.AllowDelete = false;
                view.AllowEdit = false;
                return view;
            }
        }
    }

    public class TestClass03
    {
        public void Func1()
        {
            MyBusinessObject2 mo = new MyBusinessObject2();
            DataView v = mo["customers"];
            foreach (DataRowView r in v)
            {
                Console.WriteLine(r["name"]);
            }
        }
    }
}
