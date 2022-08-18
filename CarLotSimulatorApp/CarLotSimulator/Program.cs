using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLotSimulator
{

    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carsList = new CarLot();
            
            Car myCarOne = new Car()
            {
                Make = "Kia",
                Model = "Forte",
                Year = 2020
            };
            

            carsList.CarsList = new List<Car>();

            carsList.CarsList.Add(myCarOne);


            Car myCarTwo = new Car()
            {
                Make = "Ford",
                Model = "Escape",
                Year = 2012
            };

            carsList.CarsList.Add(myCarTwo);
            

            Car myCarThree = new Car()
            {
                Make = "Hyundai",
                Model = "Elantra",
                Year = 2021
            };

            carsList.CarsList.Add(myCarThree);
           

            Console.WriteLine("Car one Details: \n");
            Console.WriteLine(myCarOne.Make);
            Console.WriteLine(myCarOne.Model);
            Console.WriteLine(myCarOne.Year);

            Console.WriteLine();

            Console.WriteLine("Car Two Details: \n");
            Console.WriteLine(myCarTwo.Make);
            Console.WriteLine(myCarTwo.Model);
            Console.WriteLine(myCarTwo.Year);

            Console.WriteLine();

            Console.WriteLine("Car Three Details: \n");
            Console.WriteLine(myCarThree.Make);
            Console.WriteLine(myCarThree.Model);
            Console.WriteLine(myCarThree.Year);

            Console.WriteLine();

            //*************BONUS*************//

            myCarOne.Make = "Tesla";
            myCarOne.Model = "Model S";
            myCarOne.Year = 2017;

            myCarTwo.Make = "Jaguar";
            myCarTwo.Model = "XE";
            myCarTwo.Year = 2015;

            myCarThree.Make = "Dodge";
            myCarThree.Model = "Charger";
            myCarThree.Year = 2013;

            myCarOne = new Car("Dodge", "Challenger", 2017);
            myCarTwo = new Car("Ford", "Bronco", 2013);
            myCarThree = new Car("Chevy", "Malibu", 2014);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("Cars in the Lot");
            Console.WriteLine();
            
            for (int i = 0; i < carsList.CarsList.Count(); i++) 
            {
                Console.WriteLine(carsList.CarsList[i].Make);
                Console.WriteLine(carsList.CarsList[i].Model);
                Console.WriteLine(carsList.CarsList[i].Year);
                Console.WriteLine();
            }
            
        }
    }
}
