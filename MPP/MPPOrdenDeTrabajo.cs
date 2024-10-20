using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
using Servicios;

namespace MPP
{
    public class MPPOrdenDeTrabajo
    {
        Acceso acceso;
        Hashtable hasdatos;

        public bool GuardarWorkOrder(BEOrdenDeTrabajo WO)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();
            List<string> ListaConsultas = new List<string>();
            List<Hashtable> ListaHash = new List<Hashtable>();
            string consulta = "S_CrearOrdenTrabajo";

            hasdatos.Add("@Numero", WO.Numero);
            if (WO is BEOrdenTrabajoBaja)
            {
                hasdatos.Add("@Costo", 3);
            }
            if (WO is BEOrdenTrabajoModerado)
            {
                hasdatos.Add("@Costo", 4);
            }
            if (WO is BEOrdenTrabajoCritico)
            {
                hasdatos.Add("@Costo", 5);
            }

            hasdatos.Add("@FechaInicio", WO.FechaInicio);
            hasdatos.Add("@Cliente", WO.Cliente.Usuario);
            hasdatos.Add("@Resumen", WO.Resumen);
            hasdatos.Add("@Notas", WO.Notas);
            hasdatos.Add("@Area", WO.area.ID);
            hasdatos.Add("@FechaLimite", WO.FechaLimite);
            hasdatos.Add("@Estado", WO.Estado);

            ListaConsultas.Add(consulta);
            ListaHash.Add(hasdatos);

            if (WO.EmpleadoAsignado != null)
            {
                string consultanueva = "S_AsignarEmpleadoWO";
                hasdatos = new Hashtable();
                hasdatos.Add("@NumeroWO", WO.Numero);
                hasdatos.Add("@UsuarioAsignado", WO.EmpleadoAsignado.Usuario);
                ListaConsultas.Add(consultanueva);
                ListaHash.Add(hasdatos);
            }
            if (WO.Tags.Count > 0)
            {
                foreach (BETag TAG in WO.Tags)
                {
                    hasdatos = new Hashtable();
                    string a = "AsignarTags_Ticket";
                    hasdatos.Add("@NumeroTicket", WO.Numero);
                    hasdatos.Add("@NombreTag", TAG.Nombre);
                    ListaConsultas.Add(a);
                    ListaHash.Add(hasdatos);
                }
            }

            return acceso.Transaccion(ListaConsultas, ListaHash);


        }

        public int ObtenerProximoNumeroWO()
        {
            acceso = new Acceso();
            string consulta = "S_DevolverUltimoNumeroWO";
            int a = 0;
            DataTable grilla = acceso.Leer(consulta, null);



            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    try
                    {
                        a = Convert.ToInt32(row["ProximaOrden"].ToString());
                    }
                    catch (Exception)
                    {

                        return 1;
                    }


                }

            }
            return a;

        }


        public List<BEOrdenDeTrabajo> ListarOrdenesDeTrabajo(BEArea area)
        {
            FabricaOrdenesTrabajo fabrica = new FabricaOrdenesTrabajo();
            List<BEOrdenDeTrabajo> ListaOrdenTrabajo = new List<BEOrdenDeTrabajo>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarTicketsXArea";
            Hashtable hasdatos = new Hashtable();
            hasdatos.Add("@IDArea", area.ID);
            DataTable grilla = acceso.Leer(sqlconsulta, hasdatos);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    int costo = Convert.ToInt32(row["Costo"].ToString());
                    BEOrdenDeTrabajo WO = fabrica.CrearOrdenTrabajo(costo);
                    WO.Numero = Convert.ToInt32(row["Numero"].ToString());
                    WO.Resumen = row["Resumen"].ToString();
                    WO.Notas = row["Notas"].ToString();
                    WO.area = area;
                    WO.Cliente = new BEUsuario(row["Cliente"].ToString());
                    WO.FechaInicio = Convert.ToDateTime(row["FechaInicio"]);
                    WO.FechaLimite = Convert.ToDateTime(row["FechaLimite"]);
                    if (row["FechaFin"] != DBNull.Value)
                    {
                        WO.FechaFin = Convert.ToDateTime(row["FechaFin"]);
                    }
                    WO.Resolucion = row["Resolucion"] != DBNull.Value ? row["Resolucion"].ToString() : string.Empty;
                    WO.Estado = row["Estado"] != DBNull.Value ? row["Estado"].ToString() : string.Empty;
                    WO.EmpleadoAsignado = new BEUsuario(row["EmpleadoAsignado"] != DBNull.Value ? row["EmpleadoAsignado"].ToString() : string.Empty);
                    ListaOrdenTrabajo.Add(WO);

                }
            }
            CargarTagsTicket(ListaOrdenTrabajo);
            return ListaOrdenTrabajo;
        }
        public List<BEOrdenDeTrabajo> ListarOrdenesDeTrabajoSinArea()
        {
            FabricaOrdenesTrabajo fabrica = new FabricaOrdenesTrabajo();
            List<BEOrdenDeTrabajo> ListaOrdenTrabajo = new List<BEOrdenDeTrabajo>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarTickets";
            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    int costo = Convert.ToInt32(row["Costo"].ToString());
                    BEOrdenDeTrabajo WO = fabrica.CrearOrdenTrabajo(costo);
                    WO.Numero = Convert.ToInt32(row["Numero"].ToString());
                    WO.Resumen = row["Resumen"].ToString();
                    WO.Notas = row["Notas"].ToString();
                    WO.area = new BEArea (Convert.ToInt32(row["IDArea"].ToString()));
                    WO.Cliente = new BEUsuario(row["Cliente"].ToString());
                    WO.FechaInicio = Convert.ToDateTime(row["FechaInicio"]);
                    WO.FechaLimite = Convert.ToDateTime(row["FechaLimite"]);
                    if (row["FechaFin"] != DBNull.Value)
                    {
                        WO.FechaFin = Convert.ToDateTime(row["FechaFin"]);
                    }
                    WO.Resolucion = row["Resolucion"] != DBNull.Value ? row["Resolucion"].ToString() : string.Empty;
                    WO.Estado = row["Estado"] != DBNull.Value ? row["Estado"].ToString() : string.Empty;
                    WO.EmpleadoAsignado = new BEUsuario(row["EmpleadoAsignado"] != DBNull.Value ? row["EmpleadoAsignado"].ToString() : string.Empty);
                    ListaOrdenTrabajo.Add(WO);

                }
            }
            CargarTagsTicket(ListaOrdenTrabajo);
            return ListaOrdenTrabajo;
        }

        void CargarTagsTicket(List<BEOrdenDeTrabajo> ListaWO)
        {
            acceso = new Acceso();
            MPPTag mPPTag = new MPPTag();
            List<BETag> ListaTags = mPPTag.ListarTags();
            string consulta = "S_ListarTagsXWO";
            DataTable grilla = acceso.Leer(consulta, null);

            if (grilla.Rows.Count > 0)
            {

                foreach (BEOrdenDeTrabajo orden in ListaWO)
                {

                    orden.Tags = new List<BETag>();


                    foreach (DataRow row in grilla.Rows)
                    {

                        if (Convert.ToInt32(row["IDOrden"]) == orden.Numero)
                        {

                            string nombreTag = row["NombreTag"].ToString();


                            BETag tagAsociado = ListaTags.FirstOrDefault(tag => tag.Nombre == nombreTag);


                            if (tagAsociado != null)
                            {
                                orden.Tags.Add(tagAsociado);
                            }
                        }
                    }
                }
            }
        }

        public bool AsignarEmpleado(BEOrdenDeTrabajo WO)
        {
            if (WO.EmpleadoAsignado != null)
            {
                acceso = new Acceso();
                string consultanueva = "S_AsignarEmpleadoWO";
                hasdatos = new Hashtable();
                hasdatos.Add("@NumeroWO", WO.Numero);
                hasdatos.Add("@UsuarioAsignado", WO.EmpleadoAsignado.Usuario);
                return acceso.Escribir(consultanueva, hasdatos);
            }
            else
            {
                return false;
            }
        }

        public bool AsignarArea(BEOrdenDeTrabajo WO)
        {
            string consultanueva = "S_AsignarAreaWO";
            acceso = new Acceso();

            hasdatos = new Hashtable();
            hasdatos.Add("@Numero", WO.Numero);
            hasdatos.Add("@IDArea", WO.area.ID);
            return acceso.Escribir(consultanueva, hasdatos);
        }

        public bool AgregarDetalle(BEDetalleWO detalle, BEOrdenDeTrabajo WO)
        {
            string consultanueva = "S_AgregarDetalle";
            acceso = new Acceso();

            hasdatos = new Hashtable();
            hasdatos.Add("@Numero", WO.Numero);
            hasdatos.Add("@Detalle", detalle.Detalle);
            hasdatos.Add("@FechaDetalle", detalle.FechaDetalle);
            if (detalle.Usuario != null)
            {
                hasdatos.Add("@Usuario", detalle.Usuario.Usuario);
            }
            if(detalle.TieneArchivo)
            {
                hasdatos.Add("@TieneArchivo", 1);
                
            }


            return acceso.Escribir(consultanueva, hasdatos);
        }

        public List<BEDetalleWO> ListarDetallesWO(BEOrdenDeTrabajo WO)
        {
            acceso = new Acceso();
            string consulta = "S_ListarDetallesWO";
            hasdatos = new Hashtable();
            hasdatos.Add("NumeroWO", WO.Numero);

            DataTable grilla = acceso.Leer(consulta, hasdatos);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    BEDetalleWO detalle = new BEDetalleWO();
                    detalle.Detalle = row["Detalle"].ToString();
                    string ID = row["IDDetalle"].ToString();
                    detalle.Usuario = new BEUsuario(" ");
                    detalle.Usuario.Usuario = row["Usuario"] != DBNull.Value ? row["Usuario"].ToString() : string.Empty;
                    detalle.FechaDetalle = Convert.ToDateTime(row["FechaDetalle"]);
                    detalle.ObtenerID(Convert.ToInt32(ID));
                    string i = row["TieneArchivo"] != DBNull.Value ? row["TieneArchivo"].ToString() : string.Empty;
                    if(i != null && i != "")
                    {
                        if (i == "True")
                        {
                            detalle.TieneArchivo = true;
                        }
                        else
                        {
                            detalle.TieneArchivo = false;
                        }
                    }
                    WO.DetallesWO.Add(detalle);


                }
            }

            return WO.DetallesWO;
        }

        public bool CambiarEstado(BEOrdenDeTrabajo orden)
        {
            acceso = new Acceso();
            string consulta = "S_CambiarEstadoWO";
            hasdatos = new Hashtable();
            hasdatos.Add("@Estado", orden.Estado);
            hasdatos.Add("@NumeroOrden", orden.Numero);
            return acceso.Escribir(consulta, hasdatos);
        }

        public bool SubirArchivo(Archivo archivo, BEOrdenDeTrabajo orden)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();
            List<string> ListaConsultas = new List<string>();
            List<Hashtable> ListaHash = new List<Hashtable>();
            string consulta = "S_AgregarDetalle";
            int i = ObtenerIDdetalle();

            hasdatos = new Hashtable();
            hasdatos.Add("@Numero", orden.Numero);
            hasdatos.Add("@Detalle", archivo.detalle.Detalle);
            hasdatos.Add("@FechaDetalle", archivo.detalle.FechaDetalle);
            hasdatos.Add("@TieneArchivo", 1);
            if (archivo.detalle.Usuario != null)
            {
                hasdatos.Add("@Usuario", archivo.detalle.Usuario.Usuario);
            }


            ListaConsultas.Add(consulta);
            ListaHash.Add(hasdatos);

            Hashtable hasdatos2 = new Hashtable();
            string consulta2 = "S_SubirArchivo";

            hasdatos2.Add("@NombreArchivo", archivo.Nombre);
            hasdatos2.Add("@Extension", archivo.Extension);
            hasdatos2.Add("Archivo", archivo.DatosArchivo);
            hasdatos2.Add("IDDetalle", i);
            ListaConsultas.Add(consulta2);
            ListaHash.Add(hasdatos2);

            return acceso.Transaccion(ListaConsultas, ListaHash);

        }
        int ObtenerIDdetalle()
        {
            acceso = new Acceso();
            int a = 0;
            string consulta = "S_DevolverUltimoIDDetalle";
            DataTable grilla = acceso.Leer(consulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    BEDetalleWO detalle = new BEDetalleWO();
                    a = Convert.ToInt32(row["ProximoDetalle"].ToString());
                    return a;
                }
            }
            return a;
        }

        public Archivo DescargarArchivo(BEDetalleWO detalle)
        {
            string consulta = "S_DescargarArchivo";
            acceso = new Acceso();
            hasdatos = new Hashtable();
            hasdatos.Add("@Id", detalle.DevolverID());

            DataTable grilla = acceso.Leer(consulta, hasdatos);
            if(grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    Archivo archivo = new Archivo();
                    archivo.Extension = row["Extension"].ToString();
                    archivo.Nombre = row["NombreArchivo"].ToString();
                    archivo.DatosArchivo = (byte[]) row["Archivo"];
                    return archivo;
                }
                
            }
            return null;
        }

        public bool CerrarOrden(BEOrdenDeTrabajo orden)
        {
            acceso = new Acceso();
            List<string> consultas = new List<string>();
            List<Hashtable> hashtables = new List<Hashtable>();
            string consulta = "S_CambiarEstadoWO";
            hasdatos = new Hashtable();
            hasdatos.Add("@Estado", orden.Estado);
            hasdatos.Add("@NumeroOrden", orden.Numero);

            consultas.Add(consulta);
            hashtables.Add(hasdatos);

            string consulta1 = "S_CerrarOrden";
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("@IDOrden", orden.Numero);
            hashtable1.Add("@FechaFin", DateTime.Now);
            hashtable1.Add("@Resolucion", orden.Resolucion);

            consultas.Add(consulta1);
            hashtables.Add(hashtable1);


            return acceso.Transaccion(consultas, hashtables);
        }
    }
}
