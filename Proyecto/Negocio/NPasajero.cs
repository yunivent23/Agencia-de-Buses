using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPasajero
    {
        private DPasajero dPasajero = new DPasajero();

        public String Registrar(Pasajeros pasajero)
        {
            return dPasajero.Registrar(pasajero);
        }

        public String Modificar(Pasajeros pasajero)
        {
            return dPasajero.Modificar(pasajero);
        }

        public String Eliminar(int id_pasajero)
        {
            return dPasajero.Eliminar(id_pasajero);
        }

        public List<Pasajeros> ListarTodo()
        {
            return dPasajero.ListarTodo();
        }
        public List<Pasajeros> BuscarPorDocumento(int documento)
        {
            return dPasajero.BuscarPasajeroporDocumento(documento);
        }


    }
}
