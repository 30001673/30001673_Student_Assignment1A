using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Jeremy Sayers
//Date: 29/08/18
//Purpose: display inputted properties via auto-implemented properties
namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars("", "", "");
            Console.WriteLine("Please Enter a Car Colour");
            car1.Colour = Console.ReadLine();
            Console.WriteLine("Please Enter a Car Make");
            car1.Make = Console.ReadLine();
            Console.WriteLine("Please Enter a Car GearBox");
            car1.Gearbox = Console.ReadLine();

            Console.WriteLine($"Car 1.\nColour: {car1.Colour} \nMake: {car1.Make} \nGearBox: {car1.Gearbox}\n");
            Console.ReadLine();

        }
    }
}
