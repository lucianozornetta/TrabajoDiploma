using BE;
using BLL;
using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Loguin : Form
    {


        public Loguin()
        {
            InitializeComponent();

            obllusuario = new BLLUsuario();
            obllbitacora = new BLLBitacora();
        }
        BLLUsuario obllusuario;
        BLLBitacora obllbitacora;


        private void button2_Click(object sender, EventArgs e)
        {
            string texto2 = txtcontraseña.Text;
            string texto = txtusuario.Text;

            if (txtusuario.Text != "" && txtcontraseña.Text != "")
            {
                try
                {
                    BEUsuario usuario = new BEUsuario();

                    usuario.Usuario = txtusuario.Text;
                    if (string.IsNullOrEmpty(txtusuario.Text)) throw new Exception("Ponga los datos como corresponde");
                    if (!Regex.IsMatch(texto, "^([a-zA-Z]+$)")) throw new Exception("Ponga los datos como corresponde");


                    usuario.Contraseña = txtcontraseña.Text;
                    if (string.IsNullOrEmpty(txtcontraseña.Text)) throw new Exception("Ponga los datos como corresponde");
                    if (!Regex.IsMatch(texto2, "^([a-zA-Z0-9]+$)")) throw new Exception("Ponga los datos como corresponde");


                    if (obllusuario.VerificarUsuarioRegistrado(usuario) == true)
                    {
                        MessageBox.Show("Nombre de usuario no disponible");
                    }
                    else
                    {
                        obllusuario.Guardar(usuario);
                        obllusuario.Guardardvv();

                        MessageBox.Show("Registro Exitoso");
                        BEBitacora bitacora = new BEBitacora();

                        bitacora.Usuario = usuario.Usuario;
                        bitacora.Mensaje = "Se ha registrado";
                        bitacora.Tipo = BitacoraTipo.INFO;
                        obllbitacora.GuardarBitacora(bitacora);

                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("datos incorrectos,corrobore lo ingresado");
                }
                limpiar();

            }
        }
        private void limpiar()
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario osu = new BEUsuario();
                osu.Usuario = txtusuario.Text;

                osu.Contraseña = txtcontraseña.Text;
                int i = 0;

                string texto2 = txtcontraseña.Text;
                bool respuesta = Regex.IsMatch(texto2, "^([a-zA-Z0-9]+$)");
                string texto = txtusuario.Text;

                if (obllusuario.VerificarUsuario(osu))
                {
                    if (texto.Length > 0)
                    {
                        bool respuesta2 = false;
                        respuesta2 = Regex.IsMatch(texto, "^([a-zA-Z]+$)");
                        if (respuesta2 == false)
                        { throw new Exception(); }
                    }
                    if (respuesta == false)
                    {
                        throw new Exception();

                    }
                    i = 1;
                    Sesion.Login(osu);
                    if(ChequearIntegridad())
                    {
                        iniciosesion();
                        
                    }
                    else
                    {
                        if (Sesion.ObtenerUsername().Permiso != null)
                        {
                            Recursiva(Sesion.ObtenerUsername().Permiso);
                        }
                        else
                        {
                            MessageBox.Show("Los datos fueron alterados, su usuario no tiene permiso para acceder.");
                            Sesion.Logout();

                        }
                        //if (Sesion.ObtenerUsername().permiso.ID == 53)
                        //{
                        //    MessageBox.Show("Desea solucionarlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //}
                    }
                  

                    

                }
                else if (i == 0)
                {
                    MessageBox.Show("Nombre De Usuario O Contraseña Equivocados");
                    BEBitacora bitacora = new BEBitacora();

                    bitacora.Usuario = osu.Usuario;
                    bitacora.Mensaje = "Intento fallido de inicio de sesion";
                    bitacora.Tipo = BitacoraTipo.ERROR;
                    obllbitacora.GuardarBitacora(bitacora);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void iniciosesion()
        {
            MessageBox.Show("Se ingreso de manera correcta");
            BEBitacora bitacora = new BEBitacora();

            bitacora.Usuario = Sesion.ObtenerUsername().Usuario;
            bitacora.Mensaje = "Inicio de sesion";
            bitacora.Tipo = BitacoraTipo.INFO;
            obllbitacora.GuardarBitacora(bitacora);

            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
            limpiar();
        }
        UsuariosAlterados frmUsuariosAlterados;
        private void Loguin_Load(object sender, EventArgs e)
        {


        }
        bool ChequearIntegridad()
        {
            bool usuariosAlterados = false;
            obllusuario = new BLLUsuario();
            usuariosAlterados = obllusuario.chequearDVV();
            if (usuariosAlterados)
            {
                MessageBox.Show("Los usuarios fueron vulnerados por fuera del sistema. Solo lo puede solucionar el administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
            
           

        }
        void Recursiva(BEPermiso permiso)
        {
            foreach (BEPermiso perm in permiso.PermisosHijos)
            {
                if (perm.EsPadre == true)
                {
                    Recursiva(perm);
                }
                else
                {
                    if (perm.ID == 55)
                    {
                        iniciosesion();
                    }
                }
            }
        }
    }
}
