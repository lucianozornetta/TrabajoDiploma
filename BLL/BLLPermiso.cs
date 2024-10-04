using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLPermiso
    {
        public virtual void AgregarPermiso(BEPermisoCompuesto permisoPadre)
        {
            MPPPermiso mp = new MPPPermiso();
            mp.AgregarPermiso(permisoPadre);
        }

        public virtual bool EliminarPermiso(BEPermiso permisoPadre)
        {

            MPPPermiso mp = new MPPPermiso();
            return mp.EliminarPermiso(permisoPadre);
        }
        public bool SePuedeEliminar(int id)
        {
            MPPPermiso mp = new MPPPermiso();
            List<BEPermiso> lp = mp.ListarPermisos();
            foreach (BEPermiso permiso in lp)
            {
                if (permiso.EsPadre)
                {
                    foreach (BEPermiso per in permiso.PermisosHijos)
                    {                     
                        if (per.ID == id)
                        {
                            return true;
                        }

                    }
                }

            }
            MPPUsuario mpusuario = new MPPUsuario();

            foreach (BEUsuario user in mpusuario.ListarUsuarios())
            {
                if(user.Permiso != null)
                {
                    if (user.Permiso.ID == id)
                    {
                        return true;
                    }
                }
               
            }


            return false;
        }
        public bool VerificarNombrePermiso(BEPermiso permiso)
        {
            MPPPermiso mp = new MPPPermiso();
            List<BEPermiso> lp = mp.ListarPermisos();
            foreach (BEPermiso per in lp)
            {
                if (per.Nombre == permiso.Nombre)
                {
                    return false;
                }
            }
            return true;

        }



        public virtual List<BEPermiso> ListarPermisos()
        {
            MPPPermiso mp = new MPPPermiso();
            List<BEPermiso> lista = mp.ListarPermisos();
            return lista;

        }

        public bool VerificarRepeticion(BEPermiso permisocompuesto, BEPermiso permisohijo)
        {
            foreach (BEPermiso permiso in permisocompuesto.PermisosHijos)
            {
                if (permiso.ID == permisohijo.ID)
                {
                    return false;
                }
            }
            return true;
        }

        public List<BEPermiso> ListarPermisosCompuestos()
        {
            MPPPermiso mp = new MPPPermiso();
            List<BEPermiso> lp = mp.ListarPermisos();
            List<BEPermiso> permisoscompuestos = new List<BEPermiso>();

            foreach (BEPermiso a in lp)
            {
                if (a is BEPermisoCompuesto)
                {
                    permisoscompuestos.Add(a);
                }
            }
            return permisoscompuestos;
        }



    }
}
