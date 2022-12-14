using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($" This {GetType().Name} drives virtual");
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }



    }
}
