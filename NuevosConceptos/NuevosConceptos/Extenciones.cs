using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    internal static class Extenciones
    {
        public static int CantidadPalabras(this string palabra)
        {
            return palabra.Count();
        }
        public static string[] CantidadPalabras(string palabra, char separador)
        {
            string[] Listapalabra = palabra.Split(' ');
            return Listapalabra;
        }
        public static double SegundosDeDiferencia(this DateTime fecha1, DateTime fecha2)
        {
            double segundos =  (fecha1 - fecha2).TotalSeconds;
            return (segundos / 60);
        }
        public static double Promedio (this List<int> ListaEnteros)
        {
            return ListaEnteros.Average();
        }
        public static double ParesXImpares (this List<int> ListaEnteros)
        {
            List<int> Pares = new List<int>();
            List<int> Impares = new List<int>();
            foreach (int num in ListaEnteros)
            {
                if (num % 2 == 0)
                {
                    Pares.Add(num);
                }
                else
                {
                    Impares.Add(num);
                }
            }
            return (Pares.Sum() * Impares.Restar());
        }
        public static int Restar(this List<int> Enteros)
        {
            int Resta = Enteros.First();
            for (int i = 1; i < Enteros.Count() + 1; i++)
            {
                Resta -= Enteros[i];
            }
            return Resta;
        }
    }
}
