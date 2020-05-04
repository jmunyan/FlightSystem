using System;

namespace FlightSystem
{
    class Physical_Error_Detection
    {
        String error_type;
        int error_code;
        bool active;

        public Physical_Error_Detection(){

        }
        
        public Sensors[] scan(){
            return null;
        }
        //not sure if I'll keep this or just use the original one from the sensors
        public bool check_state(){
            return true;
        }
    }
}
