using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class FabricaOrdenesTrabajo
    {
        public BEOrdenDeTrabajo CrearOrdenTrabajo(int costo)
        {
            if(costo <= 3)
            {
                return new BEOrdenTrabajoBaja();
            }
            if(costo == 4)
            {
                return new BEOrdenTrabajoModerado();
            }
            if(costo >= 5)
            {
                return new BEOrdenTrabajoCritico();
            }
            return null;
        }

        
    }
}
