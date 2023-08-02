using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Qa
{
    internal class Vehicle
    {
        public string model, color, engine;
        public int door;

        public Vehicle() {}

        public Vehicle(string model, string color, string engine, int door)
        {
            this.model = model;
            this.color = color;
            this.engine = engine;
            this.door = door;
        }

        public void start()
        {
            Console.WriteLine("Your Vehicle is Started.");
        }

        public void stop()
        {
            Console.WriteLine("Your Vehicle is Stopped.");
        }

        public void run()
        {
            Console.WriteLine("Your Vehicle is Running.");
        }

        public virtual void CalculateSpeed()
        {
            Console.WriteLine("Speed is 0 m/s.");
        }

        public void printinfo()
        {
            Console.WriteLine("Model = {0}\nColor = {1}\nEngine = {2}\nDoors = {3}",model,color,engine,door);
        }
    }
}
