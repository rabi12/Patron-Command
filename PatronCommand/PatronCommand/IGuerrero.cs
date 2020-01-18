using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public interface IGuerrero
    {
        string getNombre();

        void setNombre(string nombre);

        int getPoder();

    }
}
