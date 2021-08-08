using System;
using System.ComponentModel.DataAnnotations;

namespace Dojodachi
{
    public class Dojodachi
    {
        // 1. properties
        public int happiness { get; set; }
        public int fullness { get; set; }
        public int energy { get; set; }
        public int meals { get; set; }

        // 2. constructor
        public Dojodachi()
        {
            happiness = 20;
            fullness = 20;
            energy = 50;
            meals = 3;
        }

        // 3. methods
        
    }
}