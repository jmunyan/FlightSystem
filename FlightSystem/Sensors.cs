using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

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

        public Sensors(string type)
        {
            
        }

        public int get_value(){
            ///makes a random value within the bounds of the 
            return 0;
        }

        protected bool reset(){
            
        }

        protected string[] detect(){
            ///gets the sensors from the database.
            
            string[] types = 
            
            return 
            
        }

        static float get_average_value(string item)
        {

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
