using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item15
{
    class _5_CloseNDispose
    {
        public void ExcuteCommand(string connString, string commandString)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(connString);
                SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection);
                myConnection.Open();
                mySqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(myConnection != null)
                {
                    myConnection.Close();
                }
            }
        }

        public void ExcuteCommand2(string connString, string commandString)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(connString);
                SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection);
                myConnection.Open();
                mySqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (myConnection != null)
                {
                    myConnection.Dispose();
                }
            }
        }
    }
}
