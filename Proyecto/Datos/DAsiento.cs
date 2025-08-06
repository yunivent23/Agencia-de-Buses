using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAsiento
    {
        public String Registrar(Asientos asiento)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Asientos.Add(asiento);
                    context.SaveChanges();
                }
                return "Asiento registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar el Asiento: " + ex.Message;
            }
        }

        /*public String Modificar(Asientos asiento)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Asientos asientoTemp = context.Asientos.Find(asiento.Id_Asiento);

                    if (asientoTemp == null)
                    {
                        return "Asiento no encontrado para modificar.";
                    }

                    asientoTemp.Numero = asiento.Numero;
                    asientoTemp.Id_Bus = asiento.Id_Bus;
                    asientoTemp.Tipo = asiento.Tipo;

                    context.SaveChanges();
                }
                return "Asiento modificado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar el Asiento: " + ex.Message;
            }
        }*/

        public string Modificar(string idAsiento, string nuevoTipo)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Asientos asientoTemp = context.Asientos.Find(idAsiento);

                    if (asientoTemp == null)
                    {
                        return $"No se encontró el asiento con ID {idAsiento}.";
                    }

                    asientoTemp.Tipo = nuevoTipo;
                    context.SaveChanges();

                    return $"Asiento {idAsiento} actualizado correctamente a tipo '{nuevoTipo}'.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al modificar el asiento {idAsiento}: {ex.Message}";
            }
        }


        public String Eliminar(string id_asiento)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Asientos asientoTemp = context.Asientos.Find(id_asiento);
                    if (asientoTemp == null)
                    {
                        return "Asiento no encontrado para eliminar.";
                    }
                    context.Asientos.Remove(asientoTemp);
                    context.SaveChanges();
                }
                return "Asiento eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Asiento: " + ex.Message;
            }
        }

        public List<Asientos> ListarTodo()
        {
            List<Asientos> asientos = new List<Asientos>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    asientos = context.Asientos.ToList();
                }
                return asientos;
            }
            catch (Exception ex)
            {
                return asientos;
            }
        }

        //Listar POR BUS
        public List<Asientos> ListarPorBus(int idBus)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    return context.Asientos
                                  .Where(a => a.Id_Bus == idBus)
                                  .OrderBy(a => a.Numero)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los asientos del bus: " + ex.Message);
            }
        }

        //Listar por Viaje
        public List<Asientos> ListarPorViaje(int idViaje)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    var viaje = context.Viajes.Find(idViaje);
                    if (viaje == null)
                    {
                        throw new Exception("No se encontró el viaje con ID: " + idViaje);
                    }

                    int idBus = viaje.Id_Bus;
                    return context.Asientos
                                  .Where(a => a.Id_Bus == idBus)
                                  .OrderBy(a => a.Numero)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los asientos del viaje: " + ex.Message);
            }
        }

        //ELIMINA TODOS LOS ASIENTOS DE UN BUS, SE USA CUANDO SE ELIMINA UN BUS
        public bool EliminarPorBus(int idBus)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    var asientosBus = context.Asientos
                                             .Where(a => a.Id_Bus == idBus)
                                             .ToList();

                    if (asientosBus.Count == 0)
                        return true;

                    context.Asientos.RemoveRange(asientosBus);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
