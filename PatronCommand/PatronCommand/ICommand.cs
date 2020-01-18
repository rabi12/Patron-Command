using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public interface ICommand
    {
        string getNombre();
        void Execute(IGuerrero guerrero);
    }
}
