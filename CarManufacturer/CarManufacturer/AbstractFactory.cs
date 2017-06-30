using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public abstract class  AbstractFactory
    {
        public abstract Feature GetFeature(Features feature,string name,int rating,float price,string type);
        public abstract CarType GetCarType(CarManufactures manufacturer,CarModels model);

    }
}
