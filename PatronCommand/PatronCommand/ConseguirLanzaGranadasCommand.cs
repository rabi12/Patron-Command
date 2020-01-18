using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class ConseguirLanzaGrandasCommand : ICommand
    {
        public void Execute(IGuerrero guerrero)
        {
            Console.WriteLine(guerrero.getNombre() + " Consiguio Lanza Granadas con velocidad de " + guerrero.getPoder());
        }

        public string getNombre()
        {
            return "Conseguir Lanza Granadas";
        }
    }
}
