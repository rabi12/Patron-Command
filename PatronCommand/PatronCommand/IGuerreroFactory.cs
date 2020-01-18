using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCommand
{
    public interface IGuerreroFactory
    {
        IGuerrero crearGuerrero(string clase);
    }
}
