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

        public Sensors(string type)
        {
            
        }

        public int get_value(){
            ///makes a random value within the bounds of the 
            return 0;
        }

        protected bool reset(){
            this.value = 0;
            get_value();
        }

        protected string[] detect(){
            ///gets the sensors from the database.
            
            return 
            
        }

        static int average_value()
        {

        }

        static int assign_Random_Test_Value()
        {
            int min = average_value() - 1;
            int max = average_value() - 1;
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
