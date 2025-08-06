using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NBoleto
    {
        private DBoleto dBoleto = new DBoleto();
        private DViaje dViaje = new DViaje();
        private DAsiento dAsiento = new DAsiento();

        public String Registrar(Boletos boleto)
        {
            return dBoleto.Registrar(boleto);
        }

        public string Modificar(string idBoletoOriginal, Boletos boletoNuevo)
        {
            return new DBoleto().Modificar(idBoletoOriginal, boletoNuevo);
        }

        public bool ExisteIdBoleto(string idBoleto)
        {
            return new DBoleto().ExisteIdBoleto(idBoleto);
        }

        public String Eliminar(string id_boleto)
        {
            return dBoleto.Eliminar(id_boleto);
        }

        public List<Boletos> ListarTodo()
        {
            return dBoleto.ListarTodo();
        }

        public List<string> ObtenerAsientosOcupadosPorViaje(int idViaje)
        {
            return dBoleto.ObtenerAsientosOcupadosPorViaje(idViaje);
        }
 

            public List<Boletos> ListarPorViaje(int idViaje)
            {
                return dBoleto.ListarPorViaje(idViaje);
            }

            public List<Boletos> ListarPorAsiento(string idAsiento)
        {
            return dBoleto.ListarPorAsiento(idAsiento);
        }

        public void ActualizarBoletosUsados()
        {
            var todosBoletos = dBoleto.ListarTodo();
            DateTime hoy = DateTime.Today;

            foreach (var boleto in todosBoletos)
            {
                Viajes viaje = dViaje.BuscarPorId(boleto.Id_Viaje);
                if (viaje != null && viaje.Fecha_Salida.HasValue && viaje.Fecha_Salida.Value.Date <= hoy && boleto.Estado == "Vigente")
                {
                    boleto.Estado = "USADO";
                    dBoleto.Modificar(boleto.Id_Boleto, boleto);
                }
            }
        }

        public bool PuedeRegistrar(int idViaje)
        {
            var viaje = dViaje.BuscarPorId(idViaje);
            return viaje != null && viaje.Estado == "PROGRAMADO";
        }

        public bool PuedeModificar(string idBoleto)
        {
            var boleto = dBoleto.BuscarPorId(idBoleto);
            if (boleto == null) return false;

            var viaje = dViaje.BuscarPorId(boleto.Id_Viaje);
            return viaje != null && viaje.Estado == "PROGRAMADO";
        }

        public bool AsientoPerteneceAViaje(string idAsiento, int idViaje)
        {
            var asientos = dAsiento.ListarPorViaje(idViaje);
            return asientos.Any(a => a.Id_Asiento == idAsiento);
        }




    }
}
