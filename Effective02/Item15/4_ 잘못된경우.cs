using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item15
{
    class _4__잘못된경우
    {
        public void Func1(string connString, string commandString)
        {
            SqlConnection myConnection = new SqlConnection(connString);
            SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection);
            using (myConnection as IDisposable)
            using (mySqlCommand as IDisposable)
            {
                myConnection.Open();
                mySqlCommand.ExecuteNonQuery();
            }
        }
    }
}
