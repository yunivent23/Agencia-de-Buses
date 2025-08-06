using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRuta
    {
        private DRuta dRuta = new DRuta();

        public String Registrar(Rutas ruta)
        {
            return dRuta.Registrar(ruta);
        }

        public String Modificar(Rutas ruta)
        {
            return dRuta.Modificar(ruta);
        }

        public String Eliminar(int id_ruta)
        {
            return dRuta.Eliminar(id_ruta);
        }

        public List<Rutas> ListarTodo()
        {
            return dRuta.ListarTodo();
        }
    }
}
