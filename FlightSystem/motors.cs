using System;

namespace FlightSystem
{
    class Motors
    {

        int current_power;
        int heat;
        int current_temperature;
        int brakes;

        Sensors thermometer = new Sensors("thermometer", -60.5, 1000);
        Sensors output = new Sensors("engine_power_level", 0, 100);

        public Motors()
        {
            this.current_power = 0;
            current_temperature = 20;//just using a standard temperature for starters
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
