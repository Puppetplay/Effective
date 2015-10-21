using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item15
{
    class _2_TryFinally
    {
        public void Func1(string connString)
        {
            SqlConnection myConnection = null;
            using (myConnection = new SqlConnection(connString))
            {
                myConnection.Open();
            }
        }

        public void Func2(string connString)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(connString);
                myConnection.Open();
                //myConnection.Dispose();
            }
            finally
            {
               myConnection.Dispose();
            }
        }
    }
}
