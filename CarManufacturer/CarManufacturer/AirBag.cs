using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class AirBag : Feature
    {
        private string type;
      
        public AirBag(string name, int rating, float cost,string type) : base(name, rating, cost)
        {
            this.type = type;
           
         }
    }
}
