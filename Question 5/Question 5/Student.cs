using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    public class Student : Person //Student Class inherits data from Person Class
    {
     

        public string Campus { get; set; }  //Auto-Implemented Property for Campus - Get/Set
        public int StudentID { get; set; }  //Auto-Implemented Property for StudentID - Get/Set


        public int EnrollStudent()          //Method to Generate random 4-digit number
        {
             Random random = new Random();  //Define class for random
            return random.Next(1000, 9999); // Code Retrieved From https://stackoverflow.com/questions/2643421/correct-method-of-a-static-random-next-in-c
        }

      

        public Student(string firstName, string lastName, string campus) : base(firstName, lastName) //Constructor for Student Object
        {
            FirstName = firstName;
            LastName = lastName;
            Campus = campus;
        }
    }
}
