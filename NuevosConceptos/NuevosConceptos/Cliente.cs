using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public decimal Saldo { get; set; }

        public Cliente() { }

        public static Cliente operator - (Cliente cliente1, Cliente cliente2)
        {
            Cliente newcliente = new Cliente();
            if (cliente1.Cuit == cliente2.Cuit)
            {
                newcliente.Saldo = cliente1.Saldo - cliente2.Saldo;
                return newcliente;
            }
            else
            {
                if (cliente1.Saldo < cliente2.Saldo)
                {
                    newcliente.Saldo = cliente1.Saldo;
                    return newcliente;
                }
                newcliente.Saldo = cliente2.Saldo;
                return cliente2;
            }
        }
    }
}
