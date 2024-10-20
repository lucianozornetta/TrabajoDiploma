using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
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
            int i = 0;
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            List<BEOrdenDeTrabajo> lista;
            lista = mppWO.ListarOrdenesDeTrabajo(area);
            while (i == 0)
            {
                
                foreach (BEOrdenDeTrabajo WO in lista)
                {
                    if (WO.Estado != null)
                    {
                        if (WO.Estado == "Cerrado")
                        {
                            lista.Remove(WO);
                            i = 0;
                            break;
                        }
                        i = 1;
                    }
                }
            }
            
            return lista;
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
                                        usuario.carga -= 1;
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
                WO.Estado = "Asignado";
                BEDetalleWO detalleWO = new BEDetalleWO();
                detalleWO.Detalle = "La orden de trabajo fue asignada automaticamente al empleado " + WO.EmpleadoAsignado;
                detalleWO.FechaDetalle = DateTime.Now;
                MPPOrdenDeTrabajo mpp = new MPPOrdenDeTrabajo();
                mpp.AgregarDetalle(detalleWO , WO);
                return true;
            }
            catch (Exception)
            {
                WO.Estado = "Sin Asignar";
                return false;
            }
          
        }


        public List<BEOrdenDeTrabajo> ListarOrdenTrabajoCliente(BEArea area)
        {
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            List<BEOrdenDeTrabajo> lista  = mppWO.ListarOrdenesDeTrabajoSinArea();
            List<BEOrdenDeTrabajo> ListaSoloCliente = new List<BEOrdenDeTrabajo>();
            CargarAreaACliente(lista);
            CargarAreasAWO(lista);
            
            foreach(BEOrdenDeTrabajo WO in lista)
            {
                if(area.ID == WO.Cliente.Area.ID)
                {
                    ListaSoloCliente.Add(WO);
                }
            }
            return ListaSoloCliente;

        }
        public List<BEOrdenDeTrabajo> ListarOrdenesTrabajoConCerrados(BEArea area)
        {
            int i = 0;
            MPPOrdenDeTrabajo mppWO = new MPPOrdenDeTrabajo();
            List<BEOrdenDeTrabajo> lista;
            lista = mppWO.ListarOrdenesDeTrabajo(area);

            return lista;
        }
        void CargarAreaACliente(List<BEOrdenDeTrabajo> lista)
        {
            BLLUsuario bllusuarios = new BLLUsuario();
            List<BEUsuario> listausuarios = bllusuarios.ListarUsuarios();
            foreach(BEOrdenDeTrabajo WO in lista)
            {
                foreach(BEUsuario usuario in listausuarios)
                {
                    if(WO.Cliente.Usuario == usuario.Usuario)
                    {
                        WO.Cliente = usuario;
                    }
                }
            }

        }
        void CargarAreasAWO(List<BEOrdenDeTrabajo> ordenes)
        {
            BLLArea bLLArea = new BLLArea();
            List<BEArea> areas = bLLArea.ListarAreas();
            foreach (BEOrdenDeTrabajo WO in ordenes)
            {
                foreach (BEArea are in areas)
                {
                    if (are.ID == WO.area.ID)
                    {
                        WO.area = are;
                    }
                }
            }
        }
        public bool AsignarTicket(BEOrdenDeTrabajo orden)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            if(mPPOrdenDeTrabajo.AsignarEmpleado(orden))
            {
                orden.Estado = "Asignado";
                mPPOrdenDeTrabajo.CambiarEstado(orden);
                return true;
            }
            return false;
        }

        public bool CambiarArea(BEOrdenDeTrabajo orden)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            return mPPOrdenDeTrabajo.AsignarArea(orden);
        }

        public bool AgregarDetalle(BEDetalleWO detalle , BEOrdenDeTrabajo orden)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            return mPPOrdenDeTrabajo.AgregarDetalle(detalle, orden);
        }
        public List<BEDetalleWO> ListarDetallesWO(BEOrdenDeTrabajo WO)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            return mPPOrdenDeTrabajo.ListarDetallesWO(WO);
        }

        public bool CambiarEstado(BEOrdenDeTrabajo orden)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            if( mPPOrdenDeTrabajo.CambiarEstado(orden))
            {
                BEDetalleWO detalle = new BEDetalleWO();
                detalle.Detalle = "Orden de Trabajo cambio a estado " +  orden.Estado;
                detalle.FechaDetalle = DateTime.Now;
                detalle.Usuario = Sesion.ObtenerUsername();
                mPPOrdenDeTrabajo.AgregarDetalle(detalle, orden);
                return true;
            }
            return false;
        }

        public bool SubirArchivo(Archivo archivo, BEOrdenDeTrabajo orden)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            return mPPOrdenDeTrabajo.SubirArchivo(archivo, orden);
        }
        public Archivo DescargarArchivo(BEDetalleWO detalle)
        {
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            return mPPOrdenDeTrabajo.DescargarArchivo(detalle);
        }

        public bool CerrarOrden(BEOrdenDeTrabajo orden)
        {
            
            MPPOrdenDeTrabajo mPPOrdenDeTrabajo = new MPPOrdenDeTrabajo();
            if (mPPOrdenDeTrabajo.CerrarOrden(orden))
            {
                BEDetalleWO detalle = new BEDetalleWO();
                detalle.Detalle = "Orden de Trabajo cambio a estado " + orden.Estado;
                detalle.FechaDetalle = DateTime.Now;
                detalle.Usuario = Sesion.ObtenerUsername();
                mPPOrdenDeTrabajo.AgregarDetalle(detalle, orden);
                return true;
            }
            return false;
        }

        public bool CrearInformeEmpleado(BEArea area)
        {
            try
            {
                BLLUsuario bllusuario = new BLLUsuario();
                BLLArea bllarea = new BLLArea();
                List<BEOrdenDeTrabajo> listaWO = ListarOrdenesTrabajoConCerrados(area);
                List<BEInformeEmpleado> ListaInformes = new List<BEInformeEmpleado>();
                foreach (BEUsuario usuario in area.EmpleadosDelArea)
                {
                    BEInformeEmpleado informe = new BEInformeEmpleado();
                    informe.CasosAbiertos = 0;
                    informe.CasosCerrados = 0;
                    informe.Usuario = usuario.Usuario;
                    foreach (BEOrdenDeTrabajo WO in listaWO)
                    {
                        if(WO.EmpleadoAsignado.Usuario == usuario.Usuario)
                        {
                            if (WO.Estado != null)
                            {
                                if (WO.Estado != "Cerrado")
                                {
                                    informe.CasosAbiertos += 1;
                                }
                                else
                                {
                                    informe.CasosCerrados += 1;
                                }
                            }
                            else
                            {
                                informe.CasosAbiertos += 1;
                            }
                        }
                       
                        
                    }
                    ListaInformes.Add(informe);
                }
                PDF pdf = new PDF();
                pdf.GenerarPrimerTabla(ListaInformes);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
