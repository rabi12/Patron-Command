using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    class SaltarCommand : ICommand
    {
        public void Execute(IGuerrero guerrero)
        {
            Console.WriteLine(guerrero.getNombre() + " SALTANDO con velocidad de " + guerrero.getPoder());
        }

        public string getNombre()
        {
            return "Saltar";
        }
    }
}
