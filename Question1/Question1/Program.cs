using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetSet;
//Author: Jeremy Sayers
//Date : 29/08/18
//Purpose: Display inputted Car colour, car make and Gear Box
namespace Question1
{
    class Program
    {
        public static void Main()
        {
            Cars car1 = new Cars();                         //Define Object for Cars
            Console.WriteLine("Please Enter a Car Colour"); //Output Instruction
            car1.SetColour(Console.ReadLine());             //Input is = SetColor Variable
            Console.WriteLine("Please Enter a Car Make");   
            car1.SetMake(Console.ReadLine());
            Console.WriteLine("Please Enter a Car GearBox");
            car1.SetGearbox(Console.ReadLine());

            Console.WriteLine($"Cars 1.\nColour: {car1.GetColour()} \nMake: {car1.GetMake()} \nGearBox: {car1.GetGearbox()}\n");
            Console.ReadLine();

        }
    }


   
}

