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
            CalcularFechaLimite();
        }
        public BEOrdenDeTrabajo()
        {

        }
        public int Numero { get; set; }
        public BEUsuario Cliente { get; set; }

        public BEUsuario EmpleadoAsignado { get; set; }

        public string Resumen { get; set; }

        public string Notas { get; set; }

        public List<BEDetalleWO> DetallesWO { get; set; }

        public List<BEArea> Tags { get; set; }

        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFin { get; set; }

        public string Resolucion { get; set; }

        public DateTime FechaLimite { get; set; }


        public abstract void CalcularFechaLimite();
    }
}
