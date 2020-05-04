using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlightSystem
{

    class Sensors
    {

        /// <summary>
        /// works with the different input and output methods typically found on a flying object.
        /// makes sure the sensor type is in the database, adds it if it isn't. 
        /// retrieves and stores data from fake sensors using DBTools methods
        /// </summary>

        static DBTools db = new DBTools();
        private string type;
        double parameter_high;
        double parameter_low;

        public Sensors(string type, double parameter_high = 0, double parameter_low = 0)
        {
            if(db.bool_search_table("sensor_parameters", "type", type))
            {
                SqlDataReader reader = db.run_sql_command("SELECT parameter_high, parameter_low FROM sensor_parameters where type=" + type + "limit 1");
                
                this.type = type;
                this.parameter_high = reader.GetDouble(0);
                this.parameter_low = reader.GetDouble(1);
            }
            else
            {
                db.insert_data("sensor_parameters", "type, parameter_high, parameter_low", type + ", " + Convert.ToString(parameter_high) + ", " + Convert.ToString(parameter_low));
                this.type = type;
                this.parameter_high = parameter_high;
                this.parameter_low = parameter_low;
            }
        }

        public double get_value(){
            ///almost useless for this implementation, because no real data is being created
            ///

            SqlDataReader reader = db.run_sql_command("SELECT value FROM sensor_values WHERE type=" + type + " ORDER BY time_of_measurement LIMIT 1");

            if (reader.HasRows)
            {
                return reader.GetDouble(0);
            }
            return assign_Random_Test_Value();
        }

        public object[] detect()
        {
            ///gets the sensors from the database.

            SqlDataReader reader = db.run_sql_command("SELECT type FROM sensor_parameters");
            object[] types = new object[reader.FieldCount];
            return types;
            
        }

        public double assign_Random_Test_Value()
        {
            double avg_value = db.get_average("sensor_values", type);

            double min = avg_value - (.1 * avg_value);
            double max = avg_value + (.1 * avg_value);

            Random random = new Random();

            double value = random.NextDouble() * (max - min) + min;
            record(value);

            return value;
        }

        public void record(double value)
        {
            db.insert_data("sensor_values", "type, value, time_of_measurement", type + ", " + Convert.ToString(value) + ", " + Convert.ToString(DateTime.Now));
        }
    }
}
