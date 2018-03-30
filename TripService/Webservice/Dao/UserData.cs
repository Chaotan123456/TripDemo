using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Webservice.Dao
{
    public class UserData
    {
        public string GetUserInfo()
        {
            string name="", password="";
            string connectionStr = @"Data Source = DLC5CG7451346LH\SQL2014;database = Trip; Persist Security Info = True;Integrated Security=SSPI; ";
            String sqlCmd = @"SELECT * FROM people";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                //建立连接
                conn.Open();

                ////创建SQL命令
                SqlCommand queryCmd = new SqlCommand(sqlCmd, conn);

                ////执行SQL命令
                SqlDataReader reader = queryCmd.ExecuteReader();


                while (reader.Read())
                {

                    name = reader[0].ToString();

                }

                conn.Close();
                return name;
            }
        }
    }
}
