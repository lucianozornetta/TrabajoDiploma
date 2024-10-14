using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEOrdenTrabajoModerado : BEOrdenDeTrabajo
    {
        public BEOrdenTrabajoModerado()
        {
            this.Tags = new List<BETag>();
        }

        public BEOrdenTrabajoModerado(int numero, DateTime inicio) : base(numero, inicio)
        {
            this.Numero = numero;
            this.FechaInicio = inicio;
            this.Tags = new List<BETag>();
            CalcularFechaLimite();
        }
        public override void CalcularFechaLimite()
        {
            this.FechaLimite = this.FechaInicio.AddDays(2);
        }
    }
}
