using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos
{
    public class DAsignacion
    {
        public String Registrar(Asignaciones asignacion)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Asignaciones.Add(asignacion);
                    context.SaveChanges();
                }
                return "Asignación registrada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar la Asignación: " + ex.Message;
            }
        }

        public String Modificar(Asignaciones asignacion)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Asignaciones asignacionTemp = context.Asignaciones.Find(asignacion.Id_Asignacion);

                    if (asignacionTemp == null)
                    {
                        return "Asignación no encontrada para modificar.";
                    }

                    asignacionTemp.Id_Conductor = asignacion.Id_Conductor;
                    asignacionTemp.Id_Bus = asignacion.Id_Bus;
                    asignacionTemp.Fecha_Asignacion = asignacion.Fecha_Asignacion;
                    asignacionTemp.Turno = asignacion.Turno;
                    asignacionTemp.Observaciones = asignacion.Observaciones;

                    context.SaveChanges();
                }
                return "Asignación modificada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar la Asignación: " + ex.Message;
            }
        }

        public String Eliminar(int id_asignacion)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Asignaciones asignacionTemp = context.Asignaciones.Find(id_asignacion);
                    if (asignacionTemp == null)
                    {
                        return "Asignación no encontrada para eliminar.";
                    }
                    context.Asignaciones.Remove(asignacionTemp);
                    context.SaveChanges();
                }
                return "Asignación eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la Asignación: " + ex.Message;
            }
        }

        public List<Asignaciones> ListarTodo()
        {
            List<Asignaciones> asignaciones = new List<Asignaciones>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    asignaciones = context.Asignaciones.ToList();
                }
                return asignaciones;
            }
            catch (Exception ex)
            {
                return asignaciones;
            }
        }

        //Para la validacion del registro
        public bool ExisteAsignacion(int idConductor, int idBus, DateTime fecha, string turno)
        {
            using (var context = new BDEFEntities2())
            {
                DateTime inicio = fecha.Date;
                DateTime fin = inicio.AddDays(1);

                return context.Asignaciones.Any(a =>
                    (a.Id_Conductor == idConductor || a.Id_Bus == idBus) &&
                    a.Fecha_Asignacion >= inicio && a.Fecha_Asignacion < fin &&
                    a.Turno == turno);
            }
        }

        public Asignaciones BuscarAsignacion(int idConductor, int idBus, DateTime fecha)
        {
            using (var context = new BDEFEntities2())
            {
                return context.Asignaciones.FirstOrDefault(a =>
                    a.Id_Conductor == idConductor && 
                    a.Id_Bus == idBus && System.Data.Entity.DbFunctions.TruncateTime(a.Fecha_Asignacion) == fecha.Date); 
                    //a.Fecha_Asignacion == fecha.Date;
            }
        }

    }
}
