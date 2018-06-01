using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Car
    {
        public Engine Engine { get; set; }
        public Color Color { get; set; }
        public Transmission Transmission { get; set; }

        public override string ToString()
        {
            return "Car" + '\n'
                   + "Engine - " + Engine + '\n'
                   + "Color - " + Color + '\n'
                   + "Transmission - " + Transmission + '\n';
        }
    }
}
