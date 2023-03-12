using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Carlot
    {
        public List<Car> CarLot { get; set; } = new List<Car>();

        //For Static Class exercise
        public static int numberOfCars;

        public static int addCar()
        {
            return numberOfCars++;
        }


        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
}
