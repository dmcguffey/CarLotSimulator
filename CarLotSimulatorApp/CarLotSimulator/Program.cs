using System;

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
            Carlot Lot = new Carlot();



            //Now that the Car class is created we can instanciate 3 new cars
            Car ModelT = new Car();
            ModelT.Make = "Ford";
            ModelT.Model = "Model-T";
            ModelT.Year = 1918;
            ModelT.engineNoise = "Chug Chug";
            ModelT.honkNoise = "Aooooga";
            ModelT.isDriveable = true;
            ModelT.MakeEngineNoise();
            ModelT.MakeHonkNoise();

            Lot.CarLot.Add(ModelT);
            Carlot.addCar();
            Console.WriteLine($"We now have {Carlot.numberOfCars} on the lot!");


            Car junker = new Car() { Make = "unknown", Model = "Can't tell", Year = 1954, engineNoise = "BOOM", honkNoise = "bzzz", isDriveable = false };
            junker.MakeEngineNoise();
            junker.MakeHonkNoise();

            Lot.CarLot.Add(junker);
            Carlot.addCar();
            Console.WriteLine($"We now have {Carlot.numberOfCars} on the lot!");

            Car Camaro = new Car("Chevrolet", "Camaro", 2012, "Vrooooom", "Brrrrrrrr", true);
            Camaro.MakeEngineNoise();
            Camaro.MakeHonkNoise();

            Lot.CarLot.Add(Camaro);
            Carlot.addCar();
            Console.WriteLine($"We now have {Carlot.numberOfCars} on the lot!");

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach (var car in Lot.CarLot)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model} ");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


        }
    }
}
