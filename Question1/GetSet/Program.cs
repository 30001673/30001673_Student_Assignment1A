using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        public static void Main()
        {

        }
    }

    public class Cars
    {
        string colour, make, gearbox;

        public string GetColour()  //Getter for colour property
        {
            return colour;         //Return variable colour
        }

        public void SetColour(string col)  //Setter for colour property
        {
            colour = col;
        }



        public string GetMake()   //Getter for Make property
        {
            return make;
        }

        public void SetMake(string mk) //Setter for Make property
        {
            make = mk;
        }

        public string GetGearbox() //Getter for Gearbox property
        {
            return gearbox;
        }

        public void SetGearbox(string gbox)  //setter for gearbox property
        {
            gearbox = gbox;
        }
    }
}
