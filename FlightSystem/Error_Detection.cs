using System;

namespace FlightSystem
{
    class Error_Detection
    {
        String error_type;
        int error_code;
        bool active;

        public Error_Detection(){

        }
        
        public Sensors[] scan(){
            return null;
        }
        //not sure if I'll keep this or just use the original one from the sensors
        public bool check_state(Sensors s){
            return true;
        }

        public String get_error_location(Sensors s){
            return null;
        }
    }
}
