using System;
using System.Windows.Forms;

namespace FlightSystem
{
    class Navigation
    {
        int startx, starty, destx, desty;
        string destination;
        string location;
        double bearing;
        string[] path;

        public Navigation(int startx, int starty, int destx, int desty){
            if (startx != null && starty != null && destx != null && desty != null)
            {
                this.startx = startx;
                this.starty = starty;
                this.destx = destx;
                this.desty = desty;
            }
            //might put else back, but had a bad design for it
        }

        //returns the current direction
        protected int get_bearing()
        {
            ///gets the current bearing from the database
            ///
            return 0;
        }

        //updates the altitude
        protected double get_altitude()
        {
            ///gets the current altitude from the database
            ///
            return 0;

        }

        public int[] get_current_location()
        {
            ///returns the current x,y(longitude, latitude) coordinates
            ///
            return null;
        }

        public string[] set_destination(int startx, int starty, int destx, int desty)
        {
            return null;
        }

        public string[] set_location(int x, int y)
        {
            return null;
        }

        public string set_start(int startx, int starty, int destx, int desty)
        {
            return "getting rid of error so I can test other stuff";
        }


    }
}
