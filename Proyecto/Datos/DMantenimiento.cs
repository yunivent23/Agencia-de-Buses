using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMantenimiento
    {
        public String Registrar(Mantenimientos mantenimiento)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Mantenimientos.Add(mantenimiento);
                    context.SaveChanges();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return "Error al registrar el Mantenimiento: " + ex.Message;
            }
        }

        public String Modificar(Mantenimientos mantenimiento)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Mantenimientos mantenimientoTemp = context.Mantenimientos.Find(mantenimiento.Id_Mantenimiento);

                    if (mantenimientoTemp == null)
                    {
                        return "Mantenimiento no encontrado para modificar.";
                    }

                    mantenimientoTemp.Id_Bus = mantenimiento.Id_Bus;
                    mantenimientoTemp.Fecha = mantenimiento.Fecha;
                    mantenimientoTemp.Descripcion = mantenimiento.Descripcion;
                    mantenimientoTemp.Costo = mantenimiento.Costo;
                    mantenimientoTemp.EmpresaResponsable = mantenimiento.EmpresaResponsable;

                    context.SaveChanges();
                }
                return "Mantenimiento modificado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar el Mantenimiento: " + ex.Message;
            }
        }

        public String Eliminar(int id_mantenimiento)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Mantenimientos mantenimientoTemp = context.Mantenimientos.Find(id_mantenimiento);
                    if (mantenimientoTemp == null)
                    {
                        return "Mantenimiento no encontrado para eliminar.";
                    }
                    context.Mantenimientos.Remove(mantenimientoTemp);
                    context.SaveChanges();
                }
                return "Mantenimiento eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Mantenimiento: " + ex.Message;
            }
        }

        public List<Mantenimientos> ListarTodo()
        {
            List<Mantenimientos> mantenimientos = new List<Mantenimientos>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    mantenimientos = context.Mantenimientos.ToList();
                }
                return mantenimientos;
            }
            catch (Exception ex)
            {
                return mantenimientos;
            }
        }

        public List<Mantenimientos> ListarPorBus(int idBus)
        {
            using (var context = new BDEFEntities2())
            {
                return context.Mantenimientos
                              .Where(m => m.Id_Bus == idBus)
                              .ToList();
            }
        }


        public bool ExisteMantenimiento(int idBus, DateTime fecha)
        {
            using (var context = new BDEFEntities2())
            {
                DateTime inicio = fecha.Date;
                DateTime fin = inicio.AddDays(1);

                return context.Mantenimientos.Any(m =>
                    m.Id_Bus == idBus &&
                    m.Fecha >= inicio && m.Fecha < fin);
            }
        }

    }
}
