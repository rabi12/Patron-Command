using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    class CaminarCommand : ICommand
    {
        
        public void Execute(IGuerrero guerrero)
        {
            Console.WriteLine(guerrero.getNombre() +" CAMINANDO con velocidad de "+guerrero.getPoder());
        }

        public string getNombre()
        {
            return "Caminar";
        }
    }
}
