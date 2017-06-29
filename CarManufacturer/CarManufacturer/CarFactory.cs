using System;
using System.Collections.Generic;
using System.Linq;


namespace CarManufacturer
{
    public class Car
    {

        public readonly CarManufactures Manufacture;
        public readonly string Color;

        private float price;
        public float totalCost;
        public float Price
        {
            get { return price; }
        }
        internal Car(CarManufactures manufacture, string color, float price)
        {
            this.Manufacture = manufacture;
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
            foreach (string _featureName in features)
            {
                switch (_featureName)
                {
                    case "AIRBAG":
                        Feature _airBagObg = new AirBag("Air Bag", 8, 5000, "side airbag");
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
                            Feature _fuelInjection = new FuelInjection("Fuel Injection", 6, 2000);
                            this._features.Add(_fuelInjection);
                            this.totalCost += 2000;
                        }
                        break;
                    case "CRUISE CONTROL":
                        Feature _cruiseControl = new CruiseControl("CruiseControl", 7, 5500);
                        this.totalCost += 5500;
                        break;

                }
            }
        }
    }

    public class CarFactory
    {
        public void CreateCar(CarManufactures manufacture, string color, string[] features)
        {
            Car newCar = null;
            switch (manufacture)
            {
                case CarManufactures.Suzuki:
                    newCar = new Car(manufacture, color, 100000);
                    newCar.AddFeatures(features, manufacture);
                    break;

                case CarManufactures.Ford:
                    newCar = new Car(manufacture, color, 250000);
                    newCar.AddFeatures(features, manufacture);
                    break;

                case CarManufactures.Swift:
                    newCar = new Car(manufacture, color, 90000);
                    newCar.AddFeatures(features, manufacture);
                    break;
                case CarManufactures.Nissan:
                    newCar = new Car(manufacture, color, 350000);
                    newCar.AddFeatures(features, manufacture);
                    break;
                case CarManufactures.Toyota:
                    newCar = new Car(manufacture, color, 200000);
                    newCar.AddFeatures(features, manufacture);
                    break;
                case CarManufactures.Volkswagen:
                    newCar = new Car(manufacture, color, 400000);
                    newCar.AddFeatures(features, manufacture);
                    break;

            }
            Console.WriteLine("Car was created:\n \nManufacture:\t" + newCar.Manufacture + "\t\t Color:\t" + newCar.Color + "\t\tPrice of car:\t" + newCar.Price + "\t\t Total Price(with features):\t" + newCar.totalCost);


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

