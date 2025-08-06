using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBus
    {
        public String Registrar(Buses bus)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Buses.Add(bus);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }

        public String Modificar(Buses bus)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Buses busTemp = context.Buses.Find(bus.Id_Bus);
                    busTemp.Id_Bus = bus.Id_Bus;
                    busTemp.Placa = bus.Placa;
                    busTemp.Marca = bus.Marca;
                    busTemp.Modelo = bus.Modelo;
                    busTemp.Capacidad = bus.Capacidad;
                    busTemp.Estado = bus.Estado;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_bus)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Buses busTemp = context.Buses.Find(id_bus);
                    if (busTemp == null)
                    {
                        return "Bus no encontrado para eliminar.";
                    }
                    context.Buses.Remove(busTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Buses> ListarTodo()
        {
            List<Buses> buses = new List<Buses>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    buses = context.Buses.ToList();
                }
                return buses;
            }
            catch (Exception ex)
            {
                return buses;
            }
        }


        //metodo buscar por placa
        public List<Buses> BuscarBusPorPlaca(string placa)
        {
            List<Buses> buses = new List<Buses>();

            try
            {
                using (var context = new BDEFEntities2())
                {
                    buses = context.Buses
                        .Where(b => b.Placa == placa)
                        .ToList();
                }

                return buses;
            }
            catch (Exception ex)
            {
                return buses;
            }
        }

        public Buses BuscarPorId(int idBus)
        {
            using (var context = new BDEFEntities2())
            {
                return context.Buses.FirstOrDefault(b => b.Id_Bus == idBus);
            }
        }


    }
}
