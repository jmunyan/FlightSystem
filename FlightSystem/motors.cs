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
            current_temperature = 20;
            this.heat = current_temperature;
        }

        private Boolean start()
        {
            //starts the motors with a base amount of power
            power(10);

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

        public int power(int new_value){
            output = new_value;
            return new_value;
        }


    }
}
