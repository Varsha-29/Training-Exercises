using System;
using System.Collections.Generic;
using System.Linq;


namespace CarManufacturer
{
    public class Car
    {

        public readonly CarType carType;
        public readonly string Color;

        private float price;
        public float totalCost;
        public float Price
        {
            get { return price; }
        }
        internal Car(CarType carType, string color, float price)
        {
            this.carType = carType;
            this.Color = color;
            this.price = price;
            this._features = new List<Feature>();
            this.totalCost = price;
        }
        internal void AddFeature(Feature feature)
        {
            this._features.Add(feature);

        }

        internal List<Feature> _features;
        
        public void AddFeatures(string[] features, CarManufactures manufacturer)
        {
            int size = features.Length;
            FeatureFactory _featureFactory = new FeatureFactory();
            foreach (string _featureName in features)
            {
                switch (_featureName)
                {
                    case "AIRBAG":
                        Feature _airBagObg = _featureFactory.GetFeature(Features.AirBag, "Air Bag", 8, 5000, "side airbag");
                        this._features.Add(_airBagObg);
                        this.totalCost += 5000;
                        break;
                    case "FUEL INJECTION":
                        if (manufacturer == CarManufactures.Suzuki)

                        {
                            this._features.Add(FuelInjection.DirectInjection);
                            this.totalCost += FuelInjection.DirectInjection.Cost;
                        }
                        else if (manufacturer == CarManufactures.Volkswagen)
                        {
                            this._features.Add(FuelInjection.MultiPointInjection);
                            this.totalCost += FuelInjection.MultiPointInjection.Cost;
                        }
                        else
                        {
                            Feature _fuelInjection = _featureFactory.GetFeature(Features.FuelInjection, "Fuel Injection", 6, 2000,null);
                            this._features.Add(_fuelInjection);
                            this.totalCost += 2000;
                        }
                        break;
                    case "CRUISE CONTROL":
                        Feature _cruiseControl = _featureFactory.GetFeature(Features.CruiseControl, "Cruise Control", 7, 5500, null);
                        this.totalCost += 5500;
                        break;

                }
            }
        }
    }

    public class CarFactory
    {

        public void CreateCar(CarManufactures manufacture, string color, string[] features,CarModels model)
        {
            Car newCar = null;
            CarType carType = null;
            TypeFactory typeFactory = new TypeFactory();
            carType = typeFactory.GetCarType(manufacture, model);
            switch (manufacture)
            {
                case CarManufactures.Suzuki:
                   
                    newCar = new Car(carType, color, 100000);
                    newCar.AddFeatures(features, manufacture);
                    break;

                case CarManufactures.Ford:
                    newCar = new Car(carType, color, 250000);
                    newCar.AddFeatures(features, manufacture);
                    break;

                case CarManufactures.Swift:
                    newCar = new Car(carType, color, 90000);
                    newCar.AddFeatures(features, manufacture);
                    break;
                case CarManufactures.Nissan:
                    newCar = new Car(carType, color, 350000);
                    newCar.AddFeatures(features, manufacture);
                    break;
                case CarManufactures.Toyota:
                    newCar = new Car(carType, color, 200000);
                    newCar.AddFeatures(features, manufacture);
                    break;
                case CarManufactures.Volkswagen:
                    newCar = new Car(carType, color, 400000);
                    newCar.AddFeatures(features, manufacture);
                    break;

            }
            Console.WriteLine("Car was created:\n \nManufacturer:\t" + newCar.carType.Name+"\nModel:\t"+newCar.carType.Model + "\n Color:\t" + newCar.Color + "\nPrice of car:\t" + newCar.Price + "\n Total Price(with features):\t" + newCar.totalCost);


        }
    }

    public enum CarManufactures
    {
        Suzuki,
        Ford,
        Swift,
        Nissan,
        Volkswagen,
        Toyota
    }


}

