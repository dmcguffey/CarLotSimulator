using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string engineNoise { get; set; }
        public string honkNoise { get; set; }
        public bool isDriveable { get; set; }

        public Car()
        {

        }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            this.engineNoise = engineNoise;
            this.honkNoise = honkNoise;
            this.isDriveable = isDriveable;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(honkNoise);
        }
    }


}
