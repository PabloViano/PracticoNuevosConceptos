using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    public static class ConversionTemp
    {
        public static double CelsuisAFar (double temperatura)
        {
            return temperatura / 2.12;
        }
        public static double FarACelsius (double temperatura)
        {
            return (temperatura * 2.12);
        }
    }
}
