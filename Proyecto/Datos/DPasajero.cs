using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPasajero
    {
        public String Registrar(Pasajeros pasajero)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Pasajeros.Add(pasajero);
                    context.SaveChanges();
                }
                return "Pasajero registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar el Pasajero: " + ex.Message;
            }
        }

        public String Modificar(Pasajeros pasajero)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Pasajeros pasajeroTemp = context.Pasajeros.Find(pasajero.Id_Pasajero);

                    if (pasajeroTemp == null)
                    {
                        return "Pasajero no encontrado para modificar.";
                    }

                    pasajeroTemp.Documento_Identidad = pasajero.Documento_Identidad;
                    pasajeroTemp.Nombre = pasajero.Nombre;
                    pasajeroTemp.Correo = pasajero.Correo;
                    pasajeroTemp.Telefono = pasajero.Telefono;

                    context.SaveChanges();
                }
                return "Pasajero modificado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar el Pasajero: " + ex.Message;
            }
        }


public String Eliminar(int id_pasajero)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    // 1. Eliminar boletos relacionados
                    var boletos = context.Boletos
                                         .Where(b => b.Id_Pasajero == id_pasajero)
                                         .ToList();
                    context.Boletos.RemoveRange(boletos);

                    // 2. Eliminar el pasajero
                    var pasajero = context.Pasajeros.Find(id_pasajero);
                    if (pasajero == null)
                        return "Pasajero no encontrado.";

                    context.Pasajeros.Remove(pasajero);

                    // 3. Guardar cambios
                    context.SaveChanges();

                    return "Pasajero y sus boletos eliminados correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar pasajero: " + ex.Message;
            }
        }

        public List<Pasajeros> ListarTodo()
        {
            List<Pasajeros> pasajeros = new List<Pasajeros>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    pasajeros = context.Pasajeros.ToList();
                }
                return pasajeros;
            }
            catch (Exception ex)
            {
                return pasajeros;
            }
        }

        //Metodo para buscar Pasajero por documento
        public List<Pasajeros> BuscarPasajeroporDocumento(int documento)
        {
            List<Pasajeros> pasajeros = new List<Pasajeros>();

            try
            {
                using (var context = new BDEFEntities2())
                {
                    pasajeros = context.Pasajeros
                        .Where(c => c.Documento_Identidad == documento)
                        .ToList();
                }

                return pasajeros;
            }
            catch (Exception ex)
            {
                return pasajeros;
            }
        }
    }
}
