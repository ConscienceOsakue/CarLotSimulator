using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Instanciate Carlot .
            var lot = new CarLot();

            //Instantiation 1 using Dot notation
            var franksCar = new Car();

            franksCar.Make = "Ford";
            franksCar.Model = "Focus";
            franksCar.Year = 2013;
            franksCar.EngineNoise = "vroom";
            franksCar.HonkNoise = "beep";
            franksCar.IsDrivable = true;

            //Adding franks Car to the CarLot
            lot.Cars.Add(franksCar);

            //Object Instantiation syntax 2
            var kelsCar = new Car()
            {
                Year = 2019,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "....",
                HonkNoise = "brmmp",
                IsDrivable = false,
            };

            //Adding kels car to the CarLot
            lot.Cars.Add(kelsCar);

            
            //Instantiation 3 Using the Construstor to allow parameter value to be placed inside properties 

            var lizCar = new Car(2013, "Honda", "Civic", "vrrooom", "vruuga", true);

            //Add liz Car car to the CarLot
            lot.Cars.Add(lizCar);



            //Setting the properties for each of the cars

            //Calling each of the methods for each car
            franksCar.makeEngineNoise();
            kelsCar.makeEngineNoise();
            lizCar.makeEngineNoise();


            // iterating through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Numbers of cars created {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
