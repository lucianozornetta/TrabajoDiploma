using BE;
using DAL;
using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPUsuario
    {
        public MPPUsuario()
        {
            acceso = new Acceso();
        }
        Acceso acceso;
        Hashtable hasdatos;
        MPPPermiso mpperm;
        public bool Guardar(BEUsuario usuario)
        {


            string consultasql = "S_CrearUsuario";

            int nombreDvh = GenerarASCII(usuario.Usuario);
            int emailDvh = GenerarASCII(usuario.Contraseña);

            usuario.DVH = calcularDvh(usuario);

            hasdatos = new Hashtable();
            hasdatos.Add("@Usuario", usuario.Usuario);
            hasdatos.Add("@Contraseña", usuario.Contraseña);
            hasdatos.Add("@DVH", usuario.DVH);
            return acceso.Escribir(consultasql, hasdatos);
        }
        public int GenerarASCII(string atributo)

        {
            int valor = 0;

            byte[] ValoresASCII = Encoding.ASCII.GetBytes(atributo);
            foreach (byte b in ValoresASCII)
            {
                valor = valor + b;
            }

            return valor;
        }
        public int calcularDvh(BEUsuario oUsuario)
        {
            int nombreDvh = GenerarASCII(oUsuario.Usuario);

            int passwordDvh = GenerarASCII(oUsuario.Contraseña);

            return nombreDvh + passwordDvh;
        }
        public List<BEUsuario> chequearDVH()
        {
            List<BEUsuario> lstUsuarios = new List<BEUsuario>();
            List<BEUsuario> lstUsuariosAlterados = new List<BEUsuario>();
            lstUsuarios = ListarUsuarios();

            foreach (var user in lstUsuarios)
            {
                int dvh = new int();
                dvh = calcularDvh(user);
                if (user.DVH != dvh)
                {
                    lstUsuariosAlterados.Add(user);
                }


            }
            return lstUsuariosAlterados;

        }
        public bool Eliminar(BEUsuario osu)
        {
            hasdatos = new Hashtable();
            string consultasql = "S_Eliminarusuarios";
            hasdatos.Add("@Usuario", osu.Usuario);

            return acceso.Escribir(consultasql, hasdatos);
        }
        public bool Actualizar(BEUsuarioHistorico osu)
        {
            hasdatos = new Hashtable();
            string consultasql = "Actualizar_contraseña";
            hasdatos.Add("@Id", osu.Id);
            hasdatos.Add("@UsuarioRestaurar", osu.Usuario);


            return acceso.Escribir(consultasql, hasdatos);
        }


        public bool Modificar(BEUsuario usuario)
        {
            string consultasql = "S_Modificarusuarios";

            int nombreDvh = GenerarASCII(usuario.Usuario);
            int emailDvh = GenerarASCII(usuario.Contraseña);

            usuario.DVH = calcularDvh(usuario);

            hasdatos = new Hashtable();
            hasdatos.Add("@Usuario", usuario.Usuario);
            hasdatos.Add("@Contraseña", usuario.Contraseña);
            hasdatos.Add("@DVH", usuario.DVH);
            return acceso.Escribir(consultasql, hasdatos);
        }

        public bool VerificarUsuario(BEUsuario usuario)
        {

            hasdatos = new Hashtable();

            hasdatos.Add("@Usuario", usuario.Usuario);
            hasdatos.Add("@Contraseña", usuario.Contraseña);
            LeerPermisos(usuario);

            return acceso.LeerScalar("S_VerificarUsu", hasdatos);

        }
        public bool VerificarUsuarioRegistrado(BEUsuario usuario)
        {

            hasdatos = new Hashtable();

            hasdatos.Add("@Usuario", usuario.Usuario);


            return acceso.LeerScalar("S_VerificarUsuarioRegistrado", hasdatos);

        }
        public List<BEUsuario> ListarUsuarios()
        {
            List<BEUsuario> ListaDeUsuarios = new List<BEUsuario>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarUsuario";

            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    if (Convert.ToInt32(row["Eliminado"]) == 0)
                    {
                        BEUsuario usuario = new BEUsuario();
                        usuario.Usuario = row["Usuario"].ToString();
                        usuario.Contraseña = row["Contraseña"].ToString();
                        usuario.DVH = Convert.ToInt32(row["DVH"].ToString());

                        usuario.Area = row["Area"] != DBNull.Value ? new BEArea(Convert.ToInt32(row["Area"])) : null;



                        LeerPermisos(usuario);
                        
                        ListaDeUsuarios.Add(usuario);
                    }
                }
            }
            return ListaDeUsuarios;
        }
        public void AsignarAreaUsuario(BEUsuario usuario, List<BEArea> areas)
        {
            foreach (BEArea area in areas)
            {
                if (usuario.Area.ID == area.ID)
                {
                    usuario.Area = area;
                }

            }
        }
        public List<BEUsuario> ListarUsuariosConEliminados()
        {
            List<BEUsuario> ListaDeUsuarios = new List<BEUsuario>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_ListarUsuario";

            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    BEUsuario usuario = new BEUsuario();
                    usuario.Usuario = row["Usuario"].ToString();
                    usuario.Contraseña = row["Contraseña"].ToString();
                    ListaDeUsuarios.Add(usuario);

                }
            }
            return ListaDeUsuarios;
        }
        public List<BEUsuarioHistorico> Listarcambios(BEUsuario usuario1)
        {
            List<BEUsuarioHistorico> lusu = new List<BEUsuarioHistorico>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "Listar_cambios";
            hasdatos = new Hashtable();
            hasdatos.Add("@nombre", usuario1.Usuario);

            DataTable grilla = acceso.Leer(sqlconsulta, hasdatos);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {

                    BEUsuarioHistorico usuario = new BEUsuarioHistorico();
                    usuario.Id = Convert.ToInt32(row["Id"].ToString());
                    usuario.Usuario = row["Usuario"].ToString();
                    usuario.Contraseña = row["Contraseña"].ToString();
                    usuario.DVH = Convert.ToInt32(row["DVH"].ToString());

                    //LeerPermisos(usuario);
                    lusu.Add(usuario);



                }
            }
            return lusu;
        }
        public bool QuitarPermisos(BEUsuario usuario)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();
            string consultasql = "S_QuitarPermisos";
            hasdatos.Add("@Usuario", usuario.Usuario);
            return acceso.Escribir(consultasql, hasdatos);
        }
        public bool AsignarPermisoAUsuario(BEPermiso permiso, BEUsuario usuario)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_AsignarPermiso";
            mpperm = new MPPPermiso();
            mpperm.ObtenerID(permiso);
            hasdatos.Add("@Usuario", usuario.Usuario);
            hasdatos.Add("@Id_Permiso", permiso.ID);
            return acceso.Escribir(consultasql, hasdatos);
        }
        public void LeerPermisos(BEUsuario usuario)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Acceso acceso = new Acceso();
            string sqlconsulta = "S_LeerUsuario_Permiso";
            int j = 0;
            DataTable grilla = acceso.Leer(sqlconsulta, null);
            if (grilla.Rows.Count > 0)
            {
                foreach (DataRow row in grilla.Rows)
                {
                    dict.Add(row["Usuario"].ToString(), Convert.ToInt32(row["Id_Permiso"].ToString()));

                    foreach (string i in dict.Keys)
                    {
                        if (usuario.Usuario == i)
                        {
                            usuario.Permiso = CrearPermiso(dict[i]);
                        }
                        j++;
                    }



                    dict.Clear();
                }
            }

        }

        public bool AsignarAreaUsuario(BEUsuario usu, BEArea area)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            if(area.ID <= 0)
            {
                area.ID = ObtenerIDArea(area);
            }
            string consultasql = "S_AsignarArea";
            hasdatos.Add("@Usuario", usu.Usuario);
            hasdatos.Add("@Area", area.ID);
            return acceso.Escribir(consultasql, hasdatos);
        }
        int ObtenerIDArea(BEArea area)
        {
            MPPArea mparea = new MPPArea();
            List<BEArea> lstarea = mparea.ListarAreas();
            foreach(BEArea a in lstarea)
            {
                if(a.Nombre == area.Nombre)
                {
                    return a.ID;
                }
            }
            return -1;
        }
        BEPermiso CrearPermiso(int idPermiso)
        {
            mpperm = new MPPPermiso();
            List<BEPermiso> permiso = mpperm.ListarPermisos();
            foreach (BEPermiso p in permiso)
            {
                if (p.ID == idPermiso)
                {
                    return p;
                }
            }
            return null;
        }
        public bool GuardarDVV()
        {
            List<BEUsuario> lstUsuarios = new List<BEUsuario>();
            int dvv = 0;
            lstUsuarios = ListarUsuarios();

            foreach (var user in lstUsuarios)
            {
                int dvh = new int();
                dvh = calcularDvh(user);
                dvv = dvv + dvh;
            }
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consulta = "S_GuardarDVV";

            hasdatos.Add("@dvv", dvv);

            return acceso.Escribir(consulta, hasdatos);


        }
        public bool chequearDVV()
        {
            List<BEUsuario> lstUsuarios = new List<BEUsuario>();
            int dvv = 0;
            int dvvDeBDD = 0;
            lstUsuarios = ListarUsuarios();

            foreach (var user in lstUsuarios)
            {
                int dvh = new int();
                dvh = user.DVH;
                dvv = dvv + dvh;
            }

            acceso = new Acceso();
            Hashtable hDatos = new Hashtable();

            DataTable ds = acceso.Leer("Traer_dvv", null);

            if (ds.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Rows)
                {
                    dvvDeBDD = Convert.ToInt32(item["dv"]);
                }
            }
            if (dvv == dvvDeBDD)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool RemoverDeArea(BEUsuario usuario)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_RemoverArea";
            hasdatos.Add("@Usuario", usuario.Usuario);
            return acceso.Escribir(consultasql, hasdatos);
        }

        public bool HacerResponsable(BEUsuario usuario, BEArea area)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            if (area.ID <= 0)
            {
                area.ID = ObtenerIDArea(area);
            }
            string consultasql = "S_CambiarResponsable";
            hasdatos.Add("@Usuario", usuario.Usuario);
            hasdatos.Add("@Area", area.ID);
            return acceso.Escribir(consultasql, hasdatos);
        }

    }
    
    
}
