using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            double sumCar = 0.0;
            double sumtruck = 0.0;

            while (true)
            {
                string line = Console.ReadLine();
                if(line=="End")
                {
                    break;
                }

                string[] input = line.Split(' ');
                string type = input[0];
                string model = input[1];
                string colour = input[2];
                int horsepower = int.Parse(input[3]);
                
                if(type=="car")
                {
                    Car car = new Car(type, model, colour, horsepower);
                    sumCar += car.HorsePowerCar;
                    cars.Add(car);

                }
                else if(type=="truck")
                {
                    Truck truck = new Truck(type, model, colour, horsepower);
                    sumtruck += truck.HorsePowerTruck;
                    trucks.Add(truck);
                }

            }
            double averageCar = sumCar / cars.Count;
            double averageTruck = sumtruck / trucks.Count;
            while (true)
            {
                string name = Console.ReadLine();
                if(name== "Close the Catalogue")
                {
                    break;
                }
                foreach (var car in cars)
                {
                    if(car.ModelCar==name)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.ModelCar}");
                        Console.WriteLine($"Color: {car.ColourCar}");
                        Console.WriteLine($"Horsepower: {car.HorsePowerCar}");
                    }
                }
                foreach (var truck in trucks)
                {
                    if (truck.ModelTruck == name)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.ModelTruck}");
                        Console.WriteLine($"Color: {truck.ColourTruck}");
                        Console.WriteLine($"Horsepower: {truck.HorsePowerTruck}");
                    }
                }

            }
            Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
                
                    
        }
    }
    class Car
    {
        public Car(string type,string model,string colour,int horsepower)
        {
            TypeOfVehicleCar = type;
            ModelCar = model;
            ColourCar = colour;
            HorsePowerCar = horsepower;
        }
        public string TypeOfVehicleCar { get; set; }
        public string ModelCar { get; set; }
        public string ColourCar { get; set; }
        public int HorsePowerCar { get; set; }
    }
    class Truck
    {

        public Truck(string type, string model, string colour, int horsepower)
        {
            TypeOfVehicleTruck = type;
            ModelTruck = model;
            ColourTruck = colour;
            HorsePowerTruck = horsepower;
        }
        public string TypeOfVehicleTruck { get; set; }
        public string ModelTruck { get; set; }
        public string ColourTruck { get; set; }
        public int HorsePowerTruck { get; set; }
    }
}
