using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    public class Person
    {
        

        public string GetFullName()
        {
             return FirstName + " " + LastName;    //Return FirstName string + SPACE + LastName String
        }


        public string FirstName { get; set; }      //Auto-implemented property for FirstName - get/set
       
        public string LastName { get; set; }       //Auto-implemented property for LastName - get/set

        public int YearOfBirth { get; set; }       //Auto-implemented property for YearOfBirth - get/set


        public int GetAge()
        {
            return 2018 - YearOfBirth;             //Return Current Year - Inputted YearOfBirth
        }

       


        public Person(string firstName, string lastName)  //Constructor for FirstName & LastName - Person Object
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
