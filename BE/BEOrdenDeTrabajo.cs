using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEOrdenDeTrabajo
    {

        public BEOrdenDeTrabajo(int numero, DateTime inicio)
        {
            this.Numero = numero;
            this.FechaInicio = inicio;
            this.Tags = new List<BETag>();
            this.DetallesWO = new List<BEDetalleWO>();
            CalcularFechaLimite();
        }
        public BEOrdenDeTrabajo()
        {
            this.Tags = new List<BETag> ();
            this.DetallesWO = new List<BEDetalleWO> ();
        }
        public int Numero { get; set; }
        public BEUsuario Cliente { get; set; }

        public BEUsuario EmpleadoAsignado { get; set; }

        public string Resumen { get; set; }

        public string Notas { get; set; }

        public List<BEDetalleWO> DetallesWO { get; set; }

        public List<BETag> Tags { get; set; }

        public BEArea area { get; set; }

        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFin { get; set; }

        public string Resolucion { get; set; }

        public DateTime FechaLimite { get; set; }

        public string Estado { get; set; }
        public abstract void CalcularFechaLimite();
    }
}
