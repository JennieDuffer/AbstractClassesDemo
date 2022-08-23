using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public static object HasTrunk { get; private set; }

        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car challenger = new Car() { HasTrunk = true, Make = "Dodge", Model = "Challenger", Year = 2015 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "XXX", Year = 2000 };
            Vehicle suv = new Car() { HasTrunk = true, Make = "Jeep", Model = "Wrangler", Year = 2011 };
            Vehicle sport = new Car() { HasTrunk = true, Make = "Porshe", Model = "Boxster", Year = 2020 };



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(challenger);
            vehicles.Add(motorcycle);
            vehicles.Add(suv);
            vehicles.Add(sport);

            foreach (var item in vehicles)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                item.DriveVirtual();
                Console.WriteLine();
            }

            

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
