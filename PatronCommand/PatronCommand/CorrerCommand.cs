using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    class CorrerCommand : ICommand
    {
        public void Execute(IGuerrero guerrero)
        {
            Console.WriteLine(guerrero.getNombre() + " CORRIENDO con velocidad de " + guerrero.getPoder());
        }

        public string getNombre()
        {
            return "Correr";
        }
    }
}
