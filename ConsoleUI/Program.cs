using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
           List<Vehicle> vehicles = new List <Vehicle>();

            Car car1 = new Car();
            car1.Year = "2005";
            car1.Make = "Ford";
            car1.Model = "F250";
            car1.HasTrunk = false;
            
            Motorcycle moto1 = new Motorcycle();
            moto1.Year = "2002";
            moto1.Make = "harley";
            moto1.Model = "sportster";
            moto1.HasSideCart = true;

            Vehicle car2 = new Car()
            { 
                Year = "1995", 
                Model = "Chevy", 
                Make = "Silverado", 
                HasTrunk = false 
            };

            Vehicle moto2 = new Motorcycle()
            { 
                Year = "2007", 
                Make = "Suzuki", 
                Model = "Hyabusa", 
                HasSideCart = false 
            };
            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(car2);
            vehicles.Add(moto2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($" Year is {vehicle.Year}, make is {vehicle.Make}, model is {vehicle.Model}" );
                vehicle.DriveAbstract();
                vehicle.DriveVirtual(); 
            }

            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
