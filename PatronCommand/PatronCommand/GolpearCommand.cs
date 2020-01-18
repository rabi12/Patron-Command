using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    class GolpearCommand : ICommand
    {
        public void Execute(IGuerrero guerrero)
        {
            Console.WriteLine(guerrero.getNombre() + " GOLPEANDO con velocidad de " + guerrero.getPoder());
        }

        public string getNombre()
        {
            return "Golpear";
        }
    }
}
