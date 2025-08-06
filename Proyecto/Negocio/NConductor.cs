using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.NConductor;

namespace Negocio
{
    public class NConductor
    {
        private DConductor dConductor = new DConductor();

        public String Registrar(Conductores conductores)
        {
            return dConductor.Registrar(conductores);
        }

        public String Modificar(Conductores conductores)
        {
            return dConductor.Modificar(conductores);
        }

        public String Eliminar(int id_conductores)
        {
            return dConductor.Eliminar(id_conductores);
        }

        public List<Conductores> ListarTodo()
        {
            return dConductor.ListarTodo();
        }
        //metodo buscar
        public List<Conductores> BuscarporDocumento(int documento)
        {
            return dConductor.BuscarConductorporDocumento(documento);
        }

        public Conductores BuscarPorId(int id_conductores)
        {
            return dConductor.BuscarPorId(id_conductores);
        }
    }
}
