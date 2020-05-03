using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class DBTools
    {

        /// <summary>
        /// class used for connecting to the local detabase
        /// and simplifying some sql features
        /// </summary>
        /// <param name="DB_NAME"></param>

        

        public DBTools()
        {
            SqlConnection cn = new SqlConnection("Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\johnmunyan\source\repos\FlightSystem\FlightSystem\Database1.mdf; Integrated Security = True");
        }

        private int get_average(string key)
        {
            
        }

    }
}
