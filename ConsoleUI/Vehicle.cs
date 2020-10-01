using System;

namespace ConsoleUI
{
    abstract public class Vehicle
    {
        #region Vehicles
        /*
         * Create an abstract class called Vehicle
         * The vehicle class shall have three string properties Year, Make, and Model
         * Set the defaults to something generic in the Vehicle class
         * Vehicle shall have an abstract method called DriveAbstract with no implementation
         * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
         */
        #endregion
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public abstract void DriveAbstract(Vehicle vehicle);
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine("DriveVirtual() method called");
        }
        
    }
}
