using System;
using System.IO.Pipes;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot1 = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var car1 = new Car();
            car1.Year = 1993;
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.IsDriveable = true;

            car1.MakeEngineNoise("vroom vroom");
            car1.MakeHonkNoise("honk");
            
            carLot1.ParkingLot.Add(car1);
            
            Console.WriteLine($"Number of cars currently in the lot: {CarLot._numberOfCars}");


            
            var car2 = new Car()
            {
                Year = 1968,
                Make = "Chevrolet",
                Model = "Camaro Z28",
                IsDriveable = true
            };

            car2.MakeEngineNoise("VROOOOOOM");
            car2.MakeHonkNoise("HONK");
            
            carLot1.ParkingLot.Add(car2);
            
            Console.WriteLine($"Number of cars currently in the lot: {CarLot._numberOfCars}");


            
            var car3 = new Car(2016, "Dodge", "Dart SXT", true);

            car3.MakeEngineNoise("Vroom");
            car3.MakeHonkNoise("Honk");
            
            carLot1.ParkingLot.Add(car3);
            
            Console.WriteLine($"Number of cars currently in the lot: {CarLot._numberOfCars}");
            
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            carLot1.CheckCars();
        }
    }
}