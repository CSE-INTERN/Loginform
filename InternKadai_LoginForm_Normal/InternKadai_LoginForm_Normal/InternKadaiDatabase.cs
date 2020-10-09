using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternKadai_LoginForm_Normal{

    class InternKadaiDatabase{

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string ConnectionString(){

            string connectStrings = string.Empty;

            connectStrings += " Addr = 192.168.10.201;";
            connectStrings += " User Id = sa;";
            connectStrings += " password = P@ssw0rd;";
            connectStrings += " Initial Catalog = Intern_Kadai;";
            connectStrings += " Integrated Security = false";

            return connectStrings;
        }


        /// <summary>
        /// sqlを引数としてDataReaderを返す
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>DataReader</returns>
        public static SqlDataReader GetDataReader(String sql){

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString())) {

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sql;
                
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();

                return sqlDataReader;
            }
        }
    }
}

