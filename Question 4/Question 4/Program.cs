using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Jeremy Sayers
//Date: 29/08/2018
//Purpose: Display inputted properties via method and auto implemented properties
namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("","");
            Console.WriteLine("Please Enter a First Name");
            person1.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter a Last Name");
            person1.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter the Year you were Born");
            person1.YearOfBirth = int.Parse(Console.ReadLine());  //Convert inputted string to Integer and assing to variable
            Console.ReadLine();

            Console.WriteLine($"Full Name: " + person1.GetFullName());  //Call method
            Console.WriteLine($"Age: " + person1.GetAge());             //Call method
            Console.ReadLine();  
         
        }
    }
}
