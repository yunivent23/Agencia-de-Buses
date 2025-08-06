using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.NConductor;

namespace Negocio
{
    public class NBus
    {
        private DBus dBus = new DBus();

        public String Registrar(Buses bus)
        {
            return dBus.Registrar(bus);
        }

        public String Modificar(Buses bus)
        {
            return dBus.Modificar(bus);
        }

        public String Eliminar(int id_bus)
        {
            return dBus.Eliminar(id_bus);
        }

        public List<Buses> ListarTodo()
        {
            return dBus.ListarTodo();
        }

        //buscar id bus
        public Buses BuscarPorId(int idBus)
        {
            return dBus.BuscarPorId(idBus);
        }

        //metodo buscar
        public List<Buses> BuscarporPlaca(string placa)
        {
            return dBus.BuscarBusPorPlaca(placa);
        }

        public void ActualizarEstadoBusesPorMantenimiento()
        {
            var dBus = new DBus();
            var dMantenimiento = new DMantenimiento();

            var buses = dBus.ListarTodo();
            var hoy = DateTime.Today;

            foreach (var bus in buses)
            {
                var mantenimientos = dMantenimiento.ListarPorBus(bus.Id_Bus);
                bool mantenimientoHoy = mantenimientos.Any(m => m.Fecha.Date == hoy);

                if (mantenimientoHoy && bus.Estado != "En mantenimiento")
                {
                    bus.Estado = "En mantenimiento";
                    dBus.Modificar(bus);
                }
            }
        }

    }
}