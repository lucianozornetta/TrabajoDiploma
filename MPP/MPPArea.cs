using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPArea
    {
        Acceso acceso;
        Hashtable hasdatos;
        public bool CrearArea(BEArea area)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_CrearArea";

            hasdatos.Add("@Nombre", area.Nombre);
            hasdatos.Add("@Responsable", area.Responsable.Usuario);

            return acceso.Escribir(consultasql, hasdatos);
        }

        public List<BEArea> ListarAreas()
        {
            List<BEArea> ListaDeAreas = new List<BEArea>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarAreas";

            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    BEArea area = new BEArea();
                    area.ID = Convert.ToInt32(row["ID"].ToString());
                    area.Nombre = row["Nombre"].ToString();
                    area.Responsable = new BEUsuario(row["Responsable"].ToString());
                    LeerUsuarios(area);
                    asignarResponsable(area);
                    
                    ListaDeAreas.Add(area);

                }
            }
            return ListaDeAreas;
        }

        void LeerUsuarios(BEArea area)
        {
            MPPUsuario mpusuario = new MPPUsuario();
            List<BEUsuario> ListaUsu = mpusuario.ListarUsuarios();
            foreach(BEUsuario usu in ListaUsu)
            {
                if(usu.Area != null)
                {
                    if (usu.Area.ID == area.ID)
                    {
                        area.EmpleadosDelArea.Add(usu);
                    }
                }
               
            }
        }
        void asignarResponsable(BEArea area)
        {
            MPPUsuario mppusuario = new MPPUsuario();
            List<BEUsuario> ListaUsuarios = mppusuario.ListarUsuarios();
            foreach(BEUsuario usu in ListaUsuarios)
            {

                if(usu.Usuario == area.Responsable.Usuario)
                {
                    area.Responsable = usu;
                }
            }
        }

    }
}

