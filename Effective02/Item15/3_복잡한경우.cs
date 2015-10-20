using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item15
{
    class _3_복잡한경우
    {
        public void Func1(string connString, string commandString)
        {
            SqlConnection myConnection = null;
            SqlCommand mySqlCommand = null;

            try
            {
                myConnection = new SqlConnection(connString);
                try
                {
                    mySqlCommand = new SqlCommand(commandString, myConnection);
                    myConnection.Open();
                    mySqlCommand.ExecuteNonQuery();
                }
                finally
                {
                    if(mySqlCommand != null)
                    {
                        mySqlCommand.Dispose();
                    }
                }
            }
            finally
            {
                if(myConnection != null)
                {
                    myConnection.Dispose();
                }
            }
        }

        public void Func2(string connString, string commandString)
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

        public void Func3(string connString, string commandString)
        {
            SqlConnection myConnection = null;
            SqlCommand mySqlCommand = null;

            try
            {
                myConnection = new SqlConnection(connString);
               
                    mySqlCommand = new SqlCommand(commandString, myConnection);
                    myConnection.Open();
                    mySqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(mySqlCommand != null)
                {
                    mySqlCommand.Dispose();
                }
                if (myConnection != null)
                {
                    myConnection.Dispose();
                }
            }
        }
    }
}
