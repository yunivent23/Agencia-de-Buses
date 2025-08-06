using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAsignacion
    {
        private DAsignacion dAsignacion = new DAsignacion();

        public string Registrar(Asignaciones asignacion)
        {
            string resultado = ValidarAsignacion(asignacion);
            if (resultado != "OK")
                return resultado;

            return new DAsignacion().Registrar(asignacion);
        }

        public String Modificar(Asignaciones asignacion)
        {
            return dAsignacion.Modificar(asignacion);
        }

        public String Eliminar(int id_asignacion)
        {
            return dAsignacion.Eliminar(id_asignacion);
        }

        public List<Asignaciones> ListarTodo()
        {
            return dAsignacion.ListarTodo();
        }

        public string ValidarAsignacion(Asignaciones asignacion)
        {
            var conductor = new DConductor().BuscarPorId(asignacion.Id_Conductor);
            var bus = new DBus().BuscarPorId(asignacion.Id_Bus);

            if (conductor == null || bus == null)
                return "Conductor o bus no encontrados.";

            if (conductor.Estado != "Activo")
                return "El conductor no está activo.";

            if (bus.Estado != "Activo")
                return "El bus no está activo.";

            if (asignacion.Fecha_Asignacion.Date < DateTime.Today)
                return "No se puede registrar una asignación en una fecha pasada.";

            var mantenimientos = new DMantenimiento().ListarPorBus(asignacion.Id_Bus);
            bool estaEnMantenimiento = mantenimientos
                .Any(m => m.Fecha.Date == asignacion.Fecha_Asignacion.Date);

            if (estaEnMantenimiento)
                return "El bus está en mantenimiento en la fecha seleccionada.";

            var dAsignacion = new DAsignacion();
            bool existeCruce = dAsignacion.ExisteAsignacion(
                asignacion.Id_Conductor,
                asignacion.Id_Bus,
                asignacion.Fecha_Asignacion,
                asignacion.Turno
            );

            if (existeCruce)
                return "El conductor o el bus ya tienen una asignación en esa fecha y turno.";

            return "OK";
        }


        public Asignaciones BuscarAsignacion(int idConductor, int idBus, DateTime fecha)
        {
            return dAsignacion.BuscarAsignacion(idConductor, idBus, fecha);
        }

    }
}
