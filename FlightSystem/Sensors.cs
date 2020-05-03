using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

/*
 * not using this because it isn't necessary
 * for the current application
 */


namespace FlightSystem
{
    class Sensors: Sensor_Type
    { 

        public Sensors(string sensor_type)
        {
            
        }

        public int get_value(){
            ///makes a random value within the bounds of the 
            return //HOW TO DATABASE?!?!?!;
        }

        protected bool reset(Sensors s){
            this.value = 0;
            get_value();
        }

        protected detect(){
            
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
