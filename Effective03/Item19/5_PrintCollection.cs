using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    class _5_PrintCollection
    {
        public void PrintCollection(IEnumerable collection)
        {
            foreach(object o in collection)
            {
                Console.WriteLine("Collection contains {0}", o.ToString());
            }
        }

        public void PrintCollection(CollectionBase collection)
        {
            foreach(object o in collection)
            {
                Console.WriteLine("Collection contains {0}", o.ToString());
            }
        }

        public void Fun1()
        {
            DataTable dt = new DataTable();
            PrintCollection(dt.Rows);
        }
    }
}
