using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DConductor
    {
        public String Registrar(Conductores conductor)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Conductores.Add(conductor);
                    context.SaveChanges();
                }
                return "Conductor registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar el Conductor: " + ex.Message;
            }
        }

        public String Modificar(Conductores conductor)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Conductores conductorTemp = context.Conductores.Find(conductor.Id_Conductor);

                    if (conductorTemp == null)
                    {
                        return "Conductor no encontrado para modificar.";
                    }

                    conductorTemp.Documento_Identidad = conductor.Documento_Identidad;
                    conductorTemp.Nombre = conductor.Nombre;
                    conductorTemp.Telefono = conductor.Telefono;
                    conductorTemp.Licencia = conductor.Licencia;
                    conductorTemp.Estado = conductor.Estado;

                    context.SaveChanges();
                }
                return "Conductor modificado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar el Conductor: " + ex.Message;
            }
        }

        public String Eliminar(int id_conductor)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Conductores conductorTemp = context.Conductores.Find(id_conductor);
                    if (conductorTemp == null)
                    {
                        return "Conductor no encontrado para eliminar.";
                    }
                    context.Conductores.Remove(conductorTemp);
                    context.SaveChanges();
                }
                return "Conductor eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Conductor: " + ex.Message;
            }
        }

        public List<Conductores> ListarTodo()
        {
            List<Conductores> conductores = new List<Conductores>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    conductores = context.Conductores.ToList();
                }
                return conductores;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar Conductores: " + ex.Message);
                return conductores;
            }
        }

        //metodo buscar conductor
        public List<Conductores> BuscarConductorporDocumento(int documento)
        {
            List<Conductores> conductores = new List<Conductores>();

            try
            {
                using (var context = new BDEFEntities2())
                {
                    conductores = context.Conductores
                        .Where(c => c.Documento_Identidad == documento)
                        .ToList();
                }

                return conductores;
            }
            catch (Exception ex)
            {
                return conductores;
            }
        }

        public Conductores BuscarPorId(int id)
        {
            using (var context = new BDEFEntities2())
            {
                return context.Conductores.FirstOrDefault(c => c.Id_Conductor == id);
            }
        }


    }
}
