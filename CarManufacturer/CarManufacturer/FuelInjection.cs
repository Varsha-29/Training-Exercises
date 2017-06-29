using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class FuelInjection : Feature
    {
        public FuelInjection(string name, int rating, float cost) : base(name, rating, cost) { }

        private static FuelInjection _directInjection;
        public static FuelInjection DirectInjection
        {
            get
            {
                if (_directInjection == null)
                {
                    _directInjection = new FuelInjection("Suzuki", 4, 3000);
                }
                return _directInjection;
            }
        }


        private static FuelInjection _multiPointInjection;

        public static FuelInjection MultiPointInjection
        {
            get
            {
                if (_multiPointInjection == null)
                {
                    _multiPointInjection = new FuelInjection("Volkswagen", 17, 9000);
                }
                return _multiPointInjection;
            }
        }
    }
}
