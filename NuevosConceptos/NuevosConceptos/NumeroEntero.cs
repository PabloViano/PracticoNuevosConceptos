using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    public class NumeroEntero
    {
        public int Entero { get; set; }

        public static decimal operator / (NumeroEntero numero1, int numero2) //Los dos params deben ser NumeroEntero
        {
            decimal result = numero1 / numero2;
            return result;
        }
    }
}
