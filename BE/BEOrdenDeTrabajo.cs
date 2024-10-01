using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEOrdenDeTrabajo
    {

        public BEUsuario Cliente { get; set; }

        public BEUsuario EmpleadoAsignado { get; set; }

        public string Resumen { get; set; }

        public string Notas { get; set; }

        public List<BEDetalleWO> DetallesWO { get; set; }


        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFin { get; set; }

        public string Resolucion { get; set; }


    }
}
