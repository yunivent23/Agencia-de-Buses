using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMantenimiento
    {
        private DMantenimiento dMantenimiento = new DMantenimiento();

        public string ValidarMantenimiento(Mantenimientos mantenimiento)
        {
            var bus = new DBus().BuscarPorId(mantenimiento.Id_Bus);
            if (bus == null)
                return "El bus no existe.";
            if (bus.Estado != "Activo")
                return "No se puede registrar mantenimiento para un bus que no está activo.";

            if (mantenimiento.Fecha.Date < DateTime.Today)
                return "No se puede registrar mantenimiento en una fecha antigua.";

            var mantenimientosTEMP = new DMantenimiento();
            bool yaExiste = mantenimientosTEMP.ExisteMantenimiento(mantenimiento.Id_Bus, mantenimiento.Fecha);

            if (yaExiste)
                return "Ya existe un mantenimiento registrado para ese bus en esa fecha.";

            return "OK";
        }
        public string Registrar(Mantenimientos mantenimiento)
        {
            string validacion = ValidarMantenimiento(mantenimiento);
            if (validacion != "OK")
                return validacion;

            string resultado = new DMantenimiento().Registrar(mantenimiento);

            if (resultado == "OK")
            {
                DBus dBus = new DBus();
                var bus = dBus.BuscarPorId(mantenimiento.Id_Bus);
                if (bus != null)
                {
                    bus.Estado = "En mantenimiento";
                    var respuesta = dBus.Modificar(bus);

                    if (respuesta != "Modificado correctamente")
                        return "Mantenimiento registrado, pero no se pudo actualizar el estado del bus.";
                }
            }

            return resultado;
        }

        public String Modificar(Mantenimientos mantenimiento)
        {
            return dMantenimiento.Modificar(mantenimiento);
        }

        public String Eliminar(int id_mantenimiento)
        {
            return dMantenimiento.Eliminar(id_mantenimiento);
        }

        public List<Mantenimientos> ListarTodo()
        {
            return dMantenimiento.ListarTodo();
        }
    }
}
