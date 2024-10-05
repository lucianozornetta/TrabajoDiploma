using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEOrdenTrabajoCritico :  BEOrdenDeTrabajo
    {
        public BEOrdenTrabajoCritico()
        {
        }

        public BEOrdenTrabajoCritico(int numero, DateTime inicio) : base(numero, inicio)
        {
            this.Numero = numero;
            this.FechaInicio = inicio;
            CalcularFechaLimite();
        }
        public override void CalcularFechaLimite()
        {
            this.FechaLimite = this.FechaInicio.AddHours(12);
        }
    }
}
