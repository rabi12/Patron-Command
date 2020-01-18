using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class GuerreroClaseMedia : IGuerrero
    {
        string nombre;

        public GuerreroClaseMedia()
        {
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getPoder()
        {
            return 20;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
