using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
   public class FeatureFactory:AbstractFactory
    {
        public override Feature  GetFeature(Features feature,string name,int rating,float cost,string type)
        {
            switch(feature)
            {
               
                case Features.CruiseControl: return new CruiseControl(name, rating, cost);
                case Features.FuelInjection:return new FuelInjection(name, rating, cost);
                default: return new AirBag(name, rating, cost, type);
            }
        }
        public override CarType GetCarType(CarManufactures manufacturer, CarModels model)
        {
            return null;
        }

    }
    public enum Features
    {
        AirBag,
        FuelInjection,
        CruiseControl
    }

}
