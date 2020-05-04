using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * not using this because it isn't necessary
 * for the current application
 */


namespace FlightSystem
{

    class Sensors
    {

        /// <summary>
        /// works with the different input and output methods typically found on a flying object.
        /// makes sure the sensor type is in the database, adds it if it isn't. 
        /// retrieves and stores data from fake sensors using DBTools methods
        /// </summary>
        /// <param name="type"></param>

        private DBTools db = new DBTools();

        public Sensors(string type, int parameter_high = 0, int parameter_low = 0)
        {
            
        }

        public int get_value(){
            ///makes a random value within the bounds of the 
            return 0;
        }

        protected string[] detect(){
            ///gets the sensors from the database.

            string[] types;

            SqlDataReader reader = db.run_sql_command("SELECT type FROM sensor_parameters");

            return types;
            
        }

        static float get_average_value(string item)
        {
            return db.get_average("sensor values", item);
        }

        static int assign_Random_Test_Value(string item)
        {
            int avg_value = average_value(item);

            int min = avg_value - (.1 * ;
            int max = avg_value + 1;
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
