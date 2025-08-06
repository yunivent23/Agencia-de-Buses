using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DViaje
    {
        public String Registrar(Viajes viaje)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Viajes.Add(viaje);
                    context.SaveChanges();
                }
                return "Viaje registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar el Viaje: " + ex.Message;
            }
        }

        public String Modificar(Viajes viaje)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Viajes viajeTemp = context.Viajes.Find(viaje.Id_Viaje);

                    if (viajeTemp == null)
                    {
                        return "Viaje no encontrado para modificar.";
                    }

                    viajeTemp.Id_Bus = viaje.Id_Bus;
                    viajeTemp.Id_Conductor = viaje.Id_Conductor;
                    viajeTemp.Id_Ruta = viaje.Id_Ruta;
                    viajeTemp.Fecha_Salida = viaje.Fecha_Salida;
                    viajeTemp.Fecha_LLegada = viaje.Fecha_LLegada;
                    viajeTemp.Estado = viaje.Estado;

                    context.SaveChanges();
                }
                return "Viaje modificado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar el Viaje: " + ex.Message;
            }
        }

        public String Eliminar(int id_viaje)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Viajes viajeTemp = context.Viajes.Find(id_viaje);
                    if (viajeTemp == null)
                    {
                        return "Viaje no encontrado para eliminar.";
                    }
                    context.Viajes.Remove(viajeTemp);
                    context.SaveChanges();
                }
                return "Viaje eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Viaje: " + ex.Message;
            }
        }

        public List<Viajes> ListarTodo()
        {
            List<Viajes> viajes = new List<Viajes>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    viajes = context.Viajes.ToList();
                }
                return viajes;
            }
            catch (Exception ex)
            {
                return viajes;
            }
        }

        public Viajes BuscarPorId(int idViaje)
        {
            using (var context = new BDEFEntities2())
            {
                return context.Viajes.Find(idViaje);
            }
        }

    }
}
