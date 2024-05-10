using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial3
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string NumeroTarjetaPropiedad { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string NumeroMotor { get; set; }
        public DateTime FechaUltimoIngreso { get; set; }
        public List<OrdenServicio> OrdenesServicio { get; set; } = new List<OrdenServicio>();
    }
}
