using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial3
{
    public class OrdenServicio
    {
        public int Codigo { get; set; }
        public string NombreServicio { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoCancelado { get; set; }
        public DateTime FechaServicio { get; set; }

        private static int lastCodigo = 0;

        public OrdenServicio(string nombreServicio, string nombreCliente, decimal montoCancelado, DateTime fechaServicio)
        {
            Codigo = ++lastCodigo;
            NombreServicio = nombreServicio;
            NombreCliente = nombreCliente;
            MontoCancelado = montoCancelado;
            FechaServicio = fechaServicio;
        }
    }


}
