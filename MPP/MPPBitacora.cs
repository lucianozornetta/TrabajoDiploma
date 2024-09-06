using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Collections;
using Interfaces;
using System.Data;

namespace MPP
{
    public class MPPBitacora
    {
        Acceso acceso;
        Hashtable hasdatos;
        public bool GuardarBitacora(BEBitacora bitacora)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_CrearBitacora";
            hasdatos.Add("@Tipo", bitacora.Tipo);
            hasdatos.Add("@Usuario", bitacora.Usuario);
            hasdatos.Add("@Mensaje", bitacora.Mensaje);
            return acceso.Escribir(consultasql, hasdatos);
        }
        public List<BEBitacora> ListarBitacoras(FiltroBitacora f)
        {
            List<BEBitacora> listabitacoras = new List<BEBitacora>();
            string consulta = "ListarBitacorasFiltro";
            hasdatos = new Hashtable();
            hasdatos.Add("@Desde", f.Desde);
            hasdatos.Add("@Hasta", f.Hasta);
            hasdatos.Add("@Usuario", f.usuario);
            hasdatos.Add("@Tipo", f.tipo);
            Acceso acceso = new Acceso();
            DataTable grilla = acceso.Leer(consulta, hasdatos);

            if (grilla.Rows.Count > 0)
            {
                int i = 1;
                foreach (DataRow row in grilla.Rows)
                {
                    BEBitacora bitacora = new BEBitacora();
                    bitacora.Index = i;
                    bitacora.Usuario = row["Usuario"].ToString();
                    bitacora.Tipo = (BitacoraTipo)Enum.ToObject(typeof(BitacoraTipo), Convert.ToInt32(row["Tipo"].ToString()));
                    bitacora.Mensaje = row["Mensaje"].ToString();
                    bitacora.Fecha = Convert.ToDateTime(row["Fecha"].ToString());
                    listabitacoras.Add(bitacora);
                    i++;
                }
            }
            return listabitacoras;
        }

    }
}
