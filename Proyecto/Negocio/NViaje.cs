using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NViaje
    {
        private DViaje dViaje = new DViaje();
        private DRuta dRuta = new DRuta();
        private DBoleto dBoleto = new DBoleto();

        public String Registrar(Viajes viaje)
        {
            string validacion = ValidarViaje(viaje);
            if (validacion != "OK")
                return validacion;
            return dViaje.Registrar(viaje);
        }

        public String Modificar(Viajes viaje)
        {
            return dViaje.Modificar(viaje);
        }

        public String Eliminar(int id_viaje)
        {
            return dViaje.Eliminar(id_viaje);
        }

        public List<Viajes> ListarTodo()
        {
            return dViaje.ListarTodo();
        }

        public string ValidarViaje(Viajes viaje)
        {
            if (!viaje.Fecha_Salida.HasValue || !viaje.Fecha_LLegada.HasValue)
            {
                return "Las fechas de salida y llegada son obligatorias.";
            }

            /*TimeSpan diferencia = DateTime.Now - viaje.Fecha_Salida.Value;
            if (Math.Abs(diferencia.TotalMinutes) > 5)
            {
                return "La fecha de salida debe ser el momento actual (máximo 5 minutos de diferencia).";
            }*/

            var asignacion = new DAsignacion().BuscarAsignacion(
                viaje.Id_Conductor,
                viaje.Id_Bus,
                viaje.Fecha_Salida.Value.Date
            );
            if (asignacion == null)
            {
                return "No existe una asignación válida para el conductor y bus en la fecha indicada.";
            }

            var bus = new DBus().BuscarPorId(viaje.Id_Bus);
            if (bus == null || bus.Estado != "Activo")
            {
                return "El bus no se encuentra activo.";
            }

            var conductor = new DConductor().BuscarPorId(viaje.Id_Conductor);
            if (conductor == null || conductor.Estado != "Activo")
            {
                return "El conductor no se encuentra activo.";
            }

            var viajes = dViaje.ListarTodo();
            foreach (var v in viajes)
            {
                if (v.Id_Bus == viaje.Id_Bus || v.Id_Conductor == viaje.Id_Conductor)
                {
                    if (viaje.Fecha_Salida < v.Fecha_LLegada && viaje.Fecha_LLegada > v.Fecha_Salida)
                    {
                        return "El bus o el conductor ya tienen un viaje en ese rango de tiempo.";
                    }
                }
            }

            return "OK";
        }

        public string CancelarViaje(int idViaje)
        {
            var viaje = dViaje.BuscarPorId(idViaje);
            if (viaje == null)
                return "Viaje no encontrado";

            viaje.Estado = "Cancelado";
            string resultado = dViaje.Modificar(viaje);
            if (resultado != "Viaje modificado correctamente")
                return "Error al cancelar el viaje";

            var boletos = dBoleto.ListarPorViaje(idViaje);
            if (boletos != null)
            {
                foreach (var boleto in boletos)
                {
                    boleto.Estado = "Cancelado";
                    var resultadoBoleto = dBoleto.Modificar(boleto.Id_Boleto, boleto);
                    if (resultadoBoleto != "Boleto modificado correctamente")
                        return $"Error al cancelar el boleto con ID {boleto.Id_Boleto}";
                }
            }
            return "Viaje cancelado correctamente";
        }

        public string EliminarViajeSiNoTieneBoletos(int idViaje)
        {
            var viaje = dViaje.BuscarPorId(idViaje);
            if (viaje == null)
                return "Viaje no encontrado.";

            var boletos = new DBoleto().ListarPorViaje(idViaje);
            if (boletos.Count > 0)
                return "No se puede eliminar el viaje porque tiene boletos emitidos.";

            return dViaje.Eliminar(idViaje);
        }




    }

}
