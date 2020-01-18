using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class GuerreroClaseBaja : IGuerrero
    {
        string nombre;

        public GuerreroClaseBaja()
        {
            
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getPoder()
        {
            return 10;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
