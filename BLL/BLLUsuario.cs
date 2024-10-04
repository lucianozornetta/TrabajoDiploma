using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;

namespace BLL
{
    public class BLLUsuario
    {
        public BLLUsuario()
        {
            mppUsuario = new MPPUsuario();
            encriptado = new Encriptado();
        }
        Encriptado encriptado;
        MPPUsuario mppUsuario;
        public List<BEUsuario> ListarUsuarios()
        {
            List<BEUsuario> listausuarios =  mppUsuario.ListarUsuarios();
            foreach(BEUsuario usuario in listausuarios)
            {
                CompletarAreas(usuario);
            }
            return listausuarios;
        }
        public List<BEUsuarioHistorico> Listarcambios(BEUsuario usuario)
        {
            return mppUsuario.Listarcambios( usuario);
        }
        public List<BEUsuario> ListarUsuariosConEliminados()
        {
            return mppUsuario.ListarUsuariosConEliminados();
        }
        public List<BEUsuario> chequearDVH()
        {
            return mppUsuario.chequearDVH();
        }
        public bool Guardar(BEUsuario usuario)
        {
            usuario.Contraseña = encriptado.Encriptar(usuario);
            return mppUsuario.Guardar(usuario);
        }
        public bool Eliminar(BEUsuario os)
        {
            return mppUsuario.Eliminar(os);
        }
        public bool Actualizar(BEUsuarioHistorico os)
        {
            return mppUsuario.Actualizar(os);
        }
        public bool Modificar(BEUsuario usuario)
        {
            usuario.Contraseña = encriptado.Encriptar(usuario);
            return mppUsuario.Modificar(usuario);
        }
        public bool RecalcularDVH(BEUsuario usuario)
        {
            return mppUsuario.Modificar(usuario);
        }
        public bool VerificarUsuario(BEUsuario usuario)
        {
            usuario.Contraseña = encriptado.Encriptar(usuario);
            return mppUsuario.VerificarUsuario(usuario);
        }
        public bool VerificarUsuarioRegistrado(BEUsuario usuario)
        {
            return mppUsuario.VerificarUsuarioRegistrado(usuario);
        }
        public bool QuitarPermisos(BEUsuario usuario)
        {
            MPPUsuario mp = new MPPUsuario();
            return mp.QuitarPermisos(usuario);
        }
        public bool AsignarPermisoAUsuario(BEPermiso permiso, BEUsuario usuario)
        {
            MPPUsuario mp = new MPPUsuario();
            if (usuario.Permiso == null)
            {
                return mp.AsignarPermisoAUsuario(permiso, usuario);
            }
            else
            {
                return false;
            }
          
        }

        void CompletarAreas(BEUsuario usu)
        {
            MPPArea mparea = new MPPArea();
            List<BEArea> areas =  mparea.ListarAreas();
            if (usu.Area != null)
            {
                foreach (BEArea area in areas)
                {
                    if (usu.Area.ID == area.ID)
                    {
                        usu.Area = area;
                    }

                }
            }
           
        }

        public bool RemoverDeArea(BEUsuario usuario)
        {
            MPPUsuario mp = new MPPUsuario();
            return mp.RemoverDeArea(usuario);
        }
        public bool AsignarAreaUsuario(BEUsuario usu, BEArea area)
        {
            MPPUsuario mp = new MPPUsuario();
            return mp.AsignarAreaUsuario(usu,area);
        }
        public bool Guardardvv()
        {
            return mppUsuario.GuardarDVV();
        }
        public bool chequearDVV()
        {
            return mppUsuario.chequearDVV();
        }

        public bool HacerResponsable(BEUsuario usuario, BEArea area)
        {
            return mppUsuario.HacerResponsable(usuario,area);
        }
    }
}
