using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID._5._DIP
{
    internal class Car
    {
        private IEngine engine; //car has a type of Engine
        //private Engine engine;
        //other components

        //public Car()
        public Car(IEngine engine)
        {
            //this.engine = new Engine();
            this.engine = engine;

        }
        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }
    }
}
