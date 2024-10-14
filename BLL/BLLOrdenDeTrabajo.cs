using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Servicios;

namespace BLL
{
    public class BLLOrdenDeTrabajo
    {
        public int ObtenerProximoNumeroWO()
        {
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            return mppWO.ObtenerProximoNumeroWO();
        }

        public bool GuardarWorkOrder(BEOrdenDeTrabajo WO)
        {
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            return mppWO.GuardarWorkOrder(WO);
        }

        public List<BEOrdenDeTrabajo> ListarOrdenesTrabajo(BEArea area)
        {
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            return mppWO.ListarOrdenesDeTrabajo(area);
        }
    }
}
