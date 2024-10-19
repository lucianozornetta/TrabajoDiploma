using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
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
            AutoAsignarWorkOrder(WO);
            return mppWO.GuardarWorkOrder(WO);
        }

        public List<BEOrdenDeTrabajo> ListarOrdenesTrabajo(BEArea area)
        {
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            return mppWO.ListarOrdenesDeTrabajo(area);
        }

        public bool AutoAsignarWorkOrder(BEOrdenDeTrabajo WO)
        {
            try
            {
                int i = 0;
                BLLOrdenDeTrabajo bLLOrdenDeTrabajo = new BLLOrdenDeTrabajo();
                List<BEOrdenDeTrabajo> ListaWO = bLLOrdenDeTrabajo.ListarOrdenesTrabajo(WO.area);
                BLLArea bLLArea = new BLLArea();
                bLLArea.ListarEmpleados(WO.area);
                foreach (BEUsuario usuario in WO.area.EmpleadosDelArea)
                {
                    usuario.CalcularCarga(ListaWO);
                    if (WO.Tags.Count > 0)
                    {
                        foreach (BETag tag in WO.Tags)
                        {
                            if (usuario.Aptitudes.Count > 0)
                            {
                                foreach (BETag tagusuario in usuario.Aptitudes)
                                {
                                    if (tagusuario.Nombre == tag.Nombre)
                                    {
                                        usuario.carga -= 2;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach(BEUsuario usuario in WO.area.EmpleadosDelArea)
                {
                    if(WO.EmpleadoAsignado == null)
                    {
                        WO.EmpleadoAsignado = usuario;
                    }
                    else
                    {
                        if(WO.EmpleadoAsignado.carga > usuario.carga)
                        {
                            WO.EmpleadoAsignado = usuario;
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
           


          
        }

        
            
    }
}
