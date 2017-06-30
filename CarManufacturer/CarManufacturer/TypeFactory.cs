using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class TypeFactory : AbstractFactory
    {
        public override CarType GetCarType(CarManufactures manufacturer,CarModels model)
        {
           switch(manufacturer)
            {
                case CarManufactures.Ford: return new Ford("Ford", model);
                case CarManufactures.Suzuki: return new Suzuki("Suzuki", model);
                case CarManufactures.Nissan:return new Nissan("Renault Nissan", model);
                case CarManufactures.Swift:return new Swift("Swift", model);
                case CarManufactures.Volkswagen:return new Volkswagen("Volkswagen",model);
                default:return new Toyota("Toyata", model);
            }
        }
        public override Feature GetFeature(Features feature, string name, int rating, float price, string type)
        {
            return null;
        }
    }
}
