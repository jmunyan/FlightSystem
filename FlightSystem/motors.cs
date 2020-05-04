using System;

namespace FlightSystem
{
    class Motors
    {

        int current_power;
        int heat;
        int current_temperature;
        int brakes;

        public Motors()
        {
            this.current_power = 0;
            current_temperature = 20;//the final version will get this from the db
            this.heat = current_temperature;
        }

        private Boolean start()
        {
            //starts the motors with a base amount of power
            power(10);
            return true;

        }

        public void emergency_stop()
        {
            power(0);
            brakes = 100;
        }

        public void stop(int a)
        {
            brakes = 100;
        }

        public int power(int new_power)
        {
            current_power = new_power;
            return new_power;
        }


    }
}
