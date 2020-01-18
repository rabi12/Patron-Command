using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class GuerreroClaseAlta : IGuerrero
    {
        string nombre;

        public GuerreroClaseAlta()
        {
          
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getPoder()
        {
            return 30;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
