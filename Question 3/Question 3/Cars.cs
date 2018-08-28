using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Cars
    {
        string colour, make, gearbox;

        public string Colour { get; set; }  //Colour auto-implemented property - get/set
        


        public string Make { get; set; }    //Make auto-implemented property - get/set



        public string Gearbox { get; set; }  //GearBox auto-implemented property - get/set


        public Cars(string col, string mk, string gbox) //Constructor for Cars Object
        {

            colour = col;
            make = mk;
            gearbox = gbox;

        }
    }
}

