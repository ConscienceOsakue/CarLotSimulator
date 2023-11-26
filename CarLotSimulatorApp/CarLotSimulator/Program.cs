using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO


            //Instanciate Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();


            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property



            //Now that the Car class is created we can instanciate 3 new cars

            //Instantiation 1 using Dot notation
            var franksCar = new Car();

            franksCar.Make = "Ford";
            franksCar.Model = "Focus";
            franksCar.Year = 2013;
            franksCar.EngineNoise = "vroom";
            franksCar.HonkNoise = "beep";
            franksCar.IsDrivable = true;

            //Add franks Car to the CarLot
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

            //Add kels car to the CarLot
            lot.Cars.Add(kelsCar);

            
            //Instantiation 3 Using the Construstor to allow parameter value to be placed inside properties 

            var lizCar = new Car(2013, "Honda", "Civic", "vrrooom", "vruuga", true);

            //Add liz Car car to the CarLot
            lot.Cars.Add(lizCar);



            //Set the properties for each of the cars

            //Call each of the methods for each car
            franksCar.makeEngineNoise();
            kelsCar.makeEngineNoise();
            lizCar.makeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done - Create a CarLot class
            // Done - It should have at least one property: a List of cars
            // Done -Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
