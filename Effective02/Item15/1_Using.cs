using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item15
{
    class _1_Using
    {
        public void ExcuteCommand(string connString, string commandString)
        {
            SqlConnection myConnection = new SqlConnection(connString);
            SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection);

            myConnection.Open();
            mySqlCommand.ExecuteNonQuery();
        }
    }

    class Using_2
    {
        public void ExcuteCommand(string connString, string commandString)
        {
            SqlConnection myConnection = new SqlConnection(connString);
            SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection);

            myConnection.Open();
            mySqlCommand.ExecuteNonQuery();

            mySqlCommand.Dispose();
            myConnection.Dispose();
        }
    }

    class Using_3
    {
        public void ExcuteCommand(string connString, string commandString)
        {
            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                using (SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection))
                {
                    myConnection.Open();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
