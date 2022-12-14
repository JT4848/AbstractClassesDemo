using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($" This {GetType().Name} drives abstract");
        }


        public bool HasTrunk { get; set; }
    }
}
