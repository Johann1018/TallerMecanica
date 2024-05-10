using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial3
{
    public class TallerMecanica
    {
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();
        public static List<OrdenServicio> ordenesServicio = new List<OrdenServicio>();

        public static List<Vehiculo> Vehiculos
        {
            get { return vehiculos; }
        }

        public static void RegistrarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
        public static void RegistrarOrdenServicio(OrdenServicio ordenServicio)
        {
            ordenesServicio.Add(ordenServicio);
        }

        

    }
}
