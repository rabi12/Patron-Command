using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public class GuerreroFactory : IGuerreroFactory
    {
        public IGuerrero crearGuerrero(string clase)
        {
            switch (clase)
            {
                case "B": return new GuerreroClaseBaja();
                case "M": return new GuerreroClaseMedia();
                case "A": return new GuerreroClaseAlta();

                default: return new GuerreroClaseBaja();
            }
        }
    }
}
