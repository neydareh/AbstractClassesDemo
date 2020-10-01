using System;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract(Vehicle car)
        {
            Console.WriteLine($"Driving {car.Year} {car.Make} {car.Model} from Abstract Method");
        }
    }
}
