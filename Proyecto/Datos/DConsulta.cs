using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DConsulta
    {
        public List<ReporteBusDTO> ObtenerReporteBuses()
        {
            using (var context = new BDEFEntities2())
            {
                var reporte = (from viaje in context.Viajes
                               join bus in context.Buses on viaje.Id_Bus equals bus.Id_Bus
                               join conductor in context.Conductores on viaje.Id_Conductor equals conductor.Id_Conductor
                               join ruta in context.Rutas on viaje.Id_Ruta equals ruta.Id_Ruta
                               select new ReporteBusDTO
                               {
                                   PlacaBus = bus.Placa,
                                   Chofer = conductor.Nombre,
                                   Ruta = ruta.Origen + " - " + ruta.Destino,
                                   AsientosVendidos = context.Boletos.Count(b => b.Id_Viaje == viaje.Id_Viaje),
                                   MontoRecaudado = context.Boletos.Where(b => b.Id_Viaje == viaje.Id_Viaje).Sum(b => (decimal?)b.Precio) ?? 0
                               }).ToList();

                return reporte;
            }
        }
    }

    public class ReporteBusDTO
    {
        public string PlacaBus { get; set; }
        public string Chofer { get; set; }
        public string Ruta { get; set; }
        public int AsientosVendidos { get; set; }
        public decimal MontoRecaudado { get; set; }
    }
}