using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Qa
{
    internal class Bike : Vehicle
    {
        public override void CalculateSpeed()
        {
            Console.WriteLine("Bike's Speed is 80 m/s.");
        }
    }
}
