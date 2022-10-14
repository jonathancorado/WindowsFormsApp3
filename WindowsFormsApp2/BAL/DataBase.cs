using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD.Properties;
using System.Configuration;
using WindowsFormsApp2.Properties;
using System.Data.SqlClient;

namespace ConexionBD.CD
{
    public class DataBase
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
             SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }
    }
}



