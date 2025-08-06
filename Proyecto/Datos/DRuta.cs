using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRuta
    {
        public String Registrar(Rutas ruta)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Rutas.Add(ruta);
                    context.SaveChanges();
                }
                return "Ruta registrada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar la Ruta: " + ex.Message;
            }
        }

        public String Modificar(Rutas ruta)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Rutas rutaTemp = context.Rutas.Find(ruta.Id_Ruta);

                    if (rutaTemp == null)
                    {
                        return "Ruta no encontrada para modificar.";
                    }

                    rutaTemp.Origen = ruta.Origen;
                    rutaTemp.Destino = ruta.Destino;
                    rutaTemp.Distancia_Km = ruta.Distancia_Km;
                    rutaTemp.Duracion_Estimada = ruta.Duracion_Estimada;

                    context.SaveChanges();
                }
                return "Ruta modificada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar la Ruta: " + ex.Message;
            }
        }

        public String Eliminar(int id_ruta)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Rutas rutaTemp = context.Rutas.Find(id_ruta);
                    if (rutaTemp == null)
                    {
                        return "Ruta no encontrada para eliminar.";
                    }
                    context.Rutas.Remove(rutaTemp);
                    context.SaveChanges();
                }
                return "Ruta eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la Ruta: " + ex.Message;
            }
        }

        public List<Rutas> ListarTodo()
        {
            List<Rutas> rutas = new List<Rutas>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    rutas = context.Rutas.ToList();
                }
                return rutas;
            }
            catch (Exception ex)
            {
                return rutas;
            }
        }
    }
}
