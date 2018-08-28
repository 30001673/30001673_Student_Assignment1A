using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
     public class Person
    {
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }


        public int GetAge()
        {
            return 2018 - YearOfBirth;
        }




        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}