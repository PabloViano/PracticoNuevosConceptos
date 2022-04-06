using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
        public static DateTime RetornarFecha (this string Fecha)
        {
            DateTime FechaRetornar = DateTime.Now;
            int valor = 0;
            try
            {
                FechaRetornar = DateTime.Parse(Fecha);
            }
            catch (Exception)
            {
                valor = -1;
            }
            finally
            {
                if (valor == -1)
                {
                    FechaRetornar = DateTime.MinValue;
                }
            }
            return FechaRetornar;
        }
        public static string InvertirString (this string palabra)
        {
            char[] invertida = palabra.ToCharArray();
            invertida.Reverse();
            return invertida.ToString();
        }
        public static string UnirArray(this string[] array,char separador)
        {
            string palabra = "";
            foreach (string item in array)
            {
                palabra += $"{item}{separador}";
            }
            return palabra;
        }
        public static bool ValidarEmail (this string email)
        {
            string FormatoEmail = @"[0-9a-zA-Z]+[@]+[a-zA-Z]+[.]+[a-z]";
            if (Regex.IsMatch(email, FormatoEmail))
            {
                return true;
            }
            return false;
        }
        public static bool ValidarCuil(this string cuil)
        {
            string FormatoCuil = @"\d{2}-\d{8}-\d";
            if (Regex.IsMatch(cuil, FormatoCuil))
            {
                return true;
            }
            return false;
        }
        public static int Restar (this int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
