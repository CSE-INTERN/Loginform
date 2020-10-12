using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternKadai_LoginForm_Normal
{
    class Config
    {
        public Dictionary<string,string> KVdictionary = new Dictionary<string,string>();
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
                    KVdictionary.Add(reader["KEY"].ToString(), reader["VALUE"].ToString() );
                }
            }
        }

    }
}
