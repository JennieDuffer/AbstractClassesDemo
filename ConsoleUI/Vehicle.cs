using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 2000;
        public string Make { get; set; } = "Toyota";

        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine(" Vehicle is virtually in drive");
        }

    }
}
