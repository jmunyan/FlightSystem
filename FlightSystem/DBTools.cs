using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    class DBTools
    {

        /// <summary>
        /// class used for connecting to the local detabase
        /// and simplifying some sql features
        /// </summary>
        /// <param name="DB_NAME"></param>

        protected SqlConnection cn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\johnmunyan\\source\\repos\\FlightSystem\\FlightSystem\\Database1.mdf; Integrated Security = True");

        public DBTools()
        {
            ///default constructor, there's only one database I'm using, it wouldn't work with another
        }

        public SqlDataReader run_sql_command(string command)
        {
            ///turns a string command into a SqlCommand and runs it
            ///returns the reader for the query

            try
            {
                SqlCommand sql_command = new SqlCommand(command, cn);
                cn.Open();
                SqlDataReader reader = sql_command.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public float get_average(string table, string value)
        {
            string sql_command = "SELECT AVG(" + value + ") as avg FROM " + table;
            SqlDataReader reader = run_sql_command(sql_command);

            if (reader == null)
            {
                throw new ArgumentOutOfRangeException("reader cannot be null");
            }

            float i = (float)reader.GetValue(0);

            return i;
        }

        public object[] return_query_results(SqlDataReader reader)
        {

            ///returns an object[] containing the column values

            object[] object_array = new object[reader.FieldCount];
            reader.GetValues(object_array);
            return object_array;

        }

        public int insert_data(string table, string fields, string data)
        {

            ///inserts data into fields in table
            ///data and fields must be "," seperated

            string command = "INSERT INTO " + table + " (" + fields + ")\n VALUES (" + data + ");";

            try
            {
                SqlCommand sql_command = new SqlCommand(command, cn);
                cn.Open();
                return sql_command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return -1;
            }

        }

        public Boolean bool_search_table(string table, string field, string item)
        {

            ///returns true if there are any rows returned from an SQL WHERE statement

            string command = "SELECT * FROM " + table + " WHERE " + field + "=" + item;
            SqlDataReader reader = run_sql_command(command);
            return reader.HasRows;
        }

    }
}
