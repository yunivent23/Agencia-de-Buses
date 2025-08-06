using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAsiento
    {
        private DAsiento dAsiento = new DAsiento();

        public String Registrar(Asientos asiento)
        {
            return dAsiento.Registrar(asiento);
        }

        /*
        public String Modificar(Asientos asiento)
        {
            return dAsiento.Modificar(asiento);
        }
        */
        public String Eliminar(string id_asiento)
        {
            return dAsiento.Eliminar(id_asiento);
        }

        public List<Asientos> ListarTodo()
        {
            return dAsiento.ListarTodo();
        }
        public bool Modificar(string idAsiento, string tipo)
        {
            string resultado = dAsiento.Modificar(idAsiento, tipo);
            return resultado.StartsWith("Asiento") || resultado.Contains("actualizado");
        }
        public List<Asientos> ListarPorBus(int idBus)
        {
            return dAsiento.ListarPorBus(idBus);
        }

        public List<Asientos> ListarPorViaje(int idViaje)
        {
            return dAsiento.ListarPorViaje(idViaje);
        }

        public bool EliminarPorBus(int idBus)
        {
            return dAsiento.EliminarPorBus(idBus);
        }

    }
}
