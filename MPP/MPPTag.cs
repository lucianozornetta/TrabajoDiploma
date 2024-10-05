using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPTag
    {
        Acceso acceso;
        Hashtable hasdatos;
        public bool GuardarTag(BETag tag)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_CrearTag";

            hasdatos.Add("@Nombre", tag.Nombre);
            return acceso.Escribir(consultasql, hasdatos);
        }

        public List<BETag> ListarTags()
        {
            List<BETag> ListaDeTags = new List<BETag>();
            acceso = new Acceso();
            string sqlconsulta = "S_ListarTags";

            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    BETag tag = new BETag();
                    tag.Nombre = row["Nombre"].ToString();
                    ListaDeTags.Add(tag);

                }
            }
            return ListaDeTags;
        }
       
        
    }


}
