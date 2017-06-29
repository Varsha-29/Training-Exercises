using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class CruiseControl : Feature
    {
        public CruiseControl(string name, int rating, float cost) : base(name, rating, cost) { }

        private static CruiseControl _laserCruise;
        public static CruiseControl LaserCruise
        {
            get
            {
                if (_laserCruise == null)
                {
                    _laserCruise = new CruiseControl("Laser Cruise", 7, 4000);
                }
                return _laserCruise;
            }
        }


        private static CruiseControl _radarCruise;
        public static CruiseControl RadarCruise
        {
            get
            {
                if (_radarCruise == null)
                {
                    _radarCruise = new CruiseControl("Radar Cruise", 5, 3000);
                }
                return _radarCruise;
            }
        }

    }
}
