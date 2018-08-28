using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Jeremy Sayers
//Date: 29/08/18
//Purpose: Display inputted properties and objects using inheritance

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("", "", "");
            Console.WriteLine("Enter Student's Name below:");
            Console.Write("Enter First Name:");
            student1.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name:");
            student1.LastName = Console.ReadLine();
            Console.Write("Enter Campus:");
            student1.Campus = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Generating New Person Record...");
            Console.WriteLine($"Adding Student to {student1.Campus} campus...");
            Console.WriteLine($"{student1.FirstName} {student1.LastName} of {student1.Campus} campus has a Student ID of {student1.EnrollStudent()}");
            Console.ReadLine();



          
        }

      
    }
}
