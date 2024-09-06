using BE;
using DAL;
using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPPermiso
    {
        Acceso acceso;
        Hashtable hasdatos;
        public virtual void AgregarPermiso(BEPermiso permisoPadre)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_GuardarPermiso";
            hasdatos.Add("@Nombre", permisoPadre.Nombre);
            hasdatos.Add("@EsPadre", 1);
            acceso.Escribir(consultasql, hasdatos);
            ObtenerID(permisoPadre);
            GuardarRelaciones(permisoPadre);

        }
        void GuardarRelaciones(BEPermiso PermisoPadre)
        {
           
            string consultasql = "S_GuardarPermisoRelacion";
            foreach (BEPermiso permiso in PermisoPadre.PermisosHijos)
            {
                hasdatos = new Hashtable();
                hasdatos.Add("@PermisoPadre", PermisoPadre.ID);
                hasdatos.Add("@PermisoHijo", permiso.ID);
                acceso.Escribir(consultasql, hasdatos);
            }


        }

        public void ObtenerID(BEPermiso permiso)
        {
            List<BEPermiso> l = ListarPermisos();
            foreach (BEPermiso p in l)
            {
                if (p.Nombre == permiso.Nombre)
                {
                    permiso.ID = p.ID;
                }

            }
        }
        public virtual bool EliminarPermiso(BEPermiso permisoPadre)
        {

            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_EliminarPermiso";
            ObtenerID(permisoPadre);
            hasdatos.Add("@ID", permisoPadre.ID);
            return acceso.Escribir(consultasql, hasdatos);

        }

        public List<BEPermiso> ListarPermisos()
        {
            List<BEPermiso> ListaDePermisos = new List<BEPermiso>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarPermisos";

            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    if (Convert.ToInt32(row["EsPadre"]) == 0)
                    {
                        BEPermiso permisoSimple = new BEPermisoSimple();
                        permisoSimple.Nombre = row["Nombre"].ToString();
                        permisoSimple.ID = Convert.ToInt32(row["ID_Permiso"].ToString());
                        permisoSimple.EsPadre = false;
                        ListaDePermisos.Add(permisoSimple);
                    }
                    else
                    {
                        BEPermiso permisoCompuesto = new BEPermisoCompuesto();
                        permisoCompuesto.Nombre = row["Nombre"].ToString();
                        permisoCompuesto.ID = Convert.ToInt32(row["ID_Permiso"].ToString());
                        permisoCompuesto.EsPadre = true;
                        ListaDePermisos.Add(permisoCompuesto);
                    }

                }
            }
            ListarHijos_Padres(ListaDePermisos);

            return ListaDePermisos;
        }

        public void ListarHijos_Padres(List<BEPermiso> listadepermisos)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarPermisosPadre_Hijo";
            int j = 0;
            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    dict.Add(Convert.ToInt32(row["PermisoPadre"].ToString()), Convert.ToInt32(row["PermisoHijo"].ToString()));
                    foreach (BEPermiso per in listadepermisos)
                    {
                        if (per is BEPermisoCompuesto)
                        {
                            foreach (int i in dict.Keys)
                            {
                                if (per.ID == i)
                                {

                                    per.AgregarHijo(SeleccionarHijo(dict[i], listadepermisos));
                                }
                                j++;
                            }
                        }

                    }
                    dict.Clear();
                }
            }
        }

        BEPermiso SeleccionarHijo(int ID, List<BEPermiso> lista)
        {
            foreach (BEPermiso p in lista)
            {
                if (p.ID == ID)
                {
                    return p;
                }
            }
            return null;
        }



       
    }

}
