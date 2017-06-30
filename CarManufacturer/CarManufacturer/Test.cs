using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Test
    {
        static void Main(string[] args)
        {
            int featureCount=0, choice;
            CarFactory carfactory = new CarFactory();
            string[] features = { "AIRBAG ", "FUEL INJECTION", "CRUISE CONTROL" };
            string[] userFeature = new string[3];
            Console.WriteLine("\n Choose a Manufacturer\n"
             + "1.Suzuki\n"
            + "2.Ford\n" +
            "3.Swift\n" +
            "4.Nissan\n" +
            "5.Volkswagen\n" +
            "6.Toyota\n");
            int manufacturer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Choose a model\n"
                + "1.SUV\n" +
                "2.Sedan\n" +
                "3.Hatch Back");
            int model= Convert.ToInt32(Console.ReadLine()); ;
            string color;

            Console.WriteLine("\n Available features\n"
                + "1.AIRBAG\n" +
                "2.FUEL INJECTION\n" +
                "3.CRUISE CONTROL");
            Console.Write("\n Enter Number of features you want");
            featureCount = Convert.ToInt32(Console.ReadLine());
            if (featureCount > 0)
            {
                Console.Write("\n select required features");
                for (int i = 0; i < featureCount; i++)
                {

                    choice = Convert.ToInt32(Console.ReadLine());
                    processChoice(choice, i);

                }
                Console.WriteLine("Enter preferred color");
                color = Convert.ToString(Console.ReadLine());
                carfactory.CreateCar((CarManufactures)manufacturer - 1, color, userFeature,(CarModels)model-1);
                Console.ReadKey();
                void processChoice(int selection, int index)
                {
                    switch (selection)
                    {
                        case 1:
                            userFeature[index] = "AIRBAG";
                            break;
                        case 2:
                            userFeature[index] = "FUEL INJECTION";
                            break;
                        case 3:
                            userFeature[index] = "CRUISE CONTROL";
                            break;
                    }

                }
            }
        }
    }
}

