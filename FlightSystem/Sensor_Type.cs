using System;
using System.Collections.Generic;

namespace FlightSystem
{
    internal class Sensor_Type
    {
        /*
        //some generic sensor types
        string[] sensor_types = { "comass", "spedometer", "altimeter", "anemometer", "engine_thermometer", "thermometer" };

        //some generic sensor parameters
        private int[] compass_parameters = { 0, 360 };
        private int[] spedometer_parameters = { 0, 10000 };
        private int[] altimeter_parameters = { -100, 50000 };
        private int[] anemometer_parameters = { -15000, 15000 };
        
        [time_of_measurement] TIMESTAMP NULL, 
    [value] FLOAT NULL,*/

        string type;
        int[] parameters;

        Dictionary<string, int[]> sensor_parameters = new Dictionary<string, int[]>();

        public Sensor_Type(string type, int[] parameters = null)
        {
            if (!(sensor_parameters.ContainsKey(type)) && parameters != null)
            {
                new_sensor_type(type, parameters);
            }
            else
            {
                try
                {
                    this.type = type;
                    this.parameters = parameters;
                }catch(ArgumentNullException e)
                {
                    throw e;
                }
                
            }
        }

        private string new_sensor_type(string type, int[] parameters)
        {
            sensor_parameters.Add(type, parameters);
            return type;
        }

        protected int[] get_parameters(string name)
        {
            return sensor_parameters[name];
        }
    }
}