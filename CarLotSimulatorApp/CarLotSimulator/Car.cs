using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public Car()
        {
        }

        public Car(int year, string make,string model, string engineNoise, string honkNoise,  bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;

        }


        public int Year{ get; set; }
        public string Make{ get; set; }
        public string Model{ get; set; }
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void makeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void makeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }
}
