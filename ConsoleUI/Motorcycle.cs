using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($" This {GetType().Name} drives abstract");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($" This {GetType().Name} drives virtual");
        }

        public bool HasSideCart { get; set; }

    }
}
