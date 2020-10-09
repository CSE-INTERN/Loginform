using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternKadai_LoginForm_Normal{

    class InternKadaiCommonFunction{
        public static string SQLStringFormat(string sqlstring){

            if (String.IsNullOrEmpty(sqlstring)){

                throw new ArgumentNullException(nameof(sqlstring));
            }

            return "'" + sqlstring + "'";
        }
    }
}
