using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    using System.Collections.Generic;
    using Datos;

    namespace Negocio
    {
        public class NConsulta
        {
            private DConsulta dConsulta = new DConsulta();

            public List<ReporteBusDTO> ObtenerReporteBuses()
            {
                return dConsulta.ObtenerReporteBuses();
            }
        }
    }
}