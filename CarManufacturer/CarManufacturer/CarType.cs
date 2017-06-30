using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
   abstract public class CarType
    {
        private readonly string _name;
        private readonly CarModels _carModels;

        
        internal CarType(string manufacturerName,CarModels carModels)
        {
            this._name = manufacturerName;
            this._carModels = carModels;
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public string Model
        {
            get
            {
                return this._carModels.ToString();
            }
        }

    }
    public class Suzuki:CarType
    {
        public Suzuki(string mName, CarModels model) : base(mName, model) { }

    }

    public class Ford : CarType
    {
        public Ford(string mName,CarModels model) : base(mName, model) { }

    }
    public class Volkswagen : CarType
    {
        public Volkswagen(string mName, CarModels model) : base(mName, model) { }

    }
    public class Swift : CarType
    {
        public Swift(string mName,CarModels model) : base(mName, model) { }

    }
    public class Nissan : CarType
    {
        public Nissan(string mName, CarModels model) : base(mName, model) { }

    }
    public class Toyota : CarType
    {
        public Toyota(string mName, CarModels model) : base(mName, model) { }

    }
   public enum CarModels
    {
        SUV,
        Sedan,
        HatchBack
    }

}
