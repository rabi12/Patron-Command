using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class ConseguirRiflePlasmaCommand : ICommand
    {
        public void Execute(IGuerrero guerrero)
        {
            Console.WriteLine(guerrero.getNombre() + " Consiguio Rifle Plasma con velocidad de " + guerrero.getPoder());
        }

        public string getNombre()
        {
            return "Conseguir Rifle Plasma";
        }
    }
}
