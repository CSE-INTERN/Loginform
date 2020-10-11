using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InternKadai_LoginForm_Normal
{
    class Config
    {
        public int PasswordMin { get; set; }
        public  int PasswordMax { get; set; }
        public Config() {
            String sql = "select * from KV ";
            using (SqlConnection sqlConnection = new SqlConnection(InternKadaiDatabase.ConnectionString()))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sql;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();


                var reader = sqlDataReader;
            while (reader.Read())
                {
                    if (reader["KEY"].ToString().Equals("PasswordMin")) {
                        PasswordMin = int.Parse(reader["VALUE"].ToString());
                    }
                    if (reader["KEY"].ToString().Equals("PasswordMax"))
                    {
                        PasswordMax = int.Parse(reader["VALUE"].ToString());
                    }

                }
            }
        }

    }
}
