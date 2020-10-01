using System;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract(Vehicle motorcycle)
        {
            Console.WriteLine($"Driving {motorcycle.Year} {motorcycle.Make} {motorcycle.Model} from Abstract Method");
        }

        public override void DriveVirtual(Vehicle motorcycle)
        {
            Console.WriteLine($"Driving {motorcycle.Year} {motorcycle.Make} {motorcycle.Model} from Virtual Method");
        }
    }
}
