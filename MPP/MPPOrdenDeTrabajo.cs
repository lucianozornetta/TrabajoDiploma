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
            ListaConsultas.Add(consulta);
            ListaHash.Add(hasdatos);

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

    }
}
