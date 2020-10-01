using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */
            #region Vehicle
            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle truck = new Car() { Make = "Mercedez", Model = "Tractor", Year = 2005, HasTrunk = true };
            Vehicle powerBike = new Motorcycle() { Model = "Suzuki", Make = "Yamaha", Year = 2010, HasSideCart = false };
            Car nissan = new Car();
            nissan.Make = "Infiniti";
            nissan.Model = "Q-37Z";
            nissan.Year = 2012;
            nissan.HasTrunk = true;

            Motorcycle yamaha = new Motorcycle();
            yamaha.Make = "Yamaha";
            yamaha.Model = "YH-09";
            yamaha.Year = 2015;
            yamaha.HasSideCart = false;
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            vehicles.Add(truck);
            vehicles.Add(powerBike);
            vehicles.Add(nissan);
            vehicles.Add(yamaha);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}");
            }

            Console.WriteLine("");
            // Call each of the drive methods for one car and one motorcycle
            truck.DriveAbstract(truck);
            truck.DriveVirtual(truck);
            Console.WriteLine("");
            yamaha.DriveAbstract(yamaha);
            yamaha.DriveVirtual(yamaha);

            #endregion
            Console.ReadLine();
        }
    }
}
