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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Registro : Form , IObserver
    {
        private static Registro instacia = null;
        private BLLUsuario obllusuario;
        private BEUsuario ousuario;
        private BLLBitacora obllbitacora;
        BLLRepositorioIdioma bllrepositorio;
        public Registro()
        {
            
            InitializeComponent();
            obllusuario= new BLLUsuario();
            ousuario = new BEUsuario();
            usuhis=new BEUsuarioHistorico();
            obllbitacora = new BLLBitacora();
            btnSalir.Hide();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public Registro(BEIdioma idiomainicial)
        {
           
            InitializeComponent();
            obllusuario = new BLLUsuario();
            ousuario = new BEUsuario();
            obllbitacora = new BLLBitacora();
            btnSalir.Hide();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idiomainicial.ID);
        }
        //public static Registro Ventanaunica()
        //{
        //    if(instacia == null) {
        //    instacia = new Registro();
        //    return instacia;}
        //    return instacia;
        //}
        private void limpiar()
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
        }

        private void btnregistrarusuario_Click(object sender, EventArgs e)
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
                        MessageBox.Show("ya se encuentra registrado");
                    }
                    else if (obllusuario.VerificarUsuarioRegistrado(usuario) == false)
                    {
                        obllusuario.Guardar(usuario);
                        obllusuario.Guardardvv();
                        cargarcambios(usuario);
                        MessageBox.Show("Registro Exitoso");
                        BEBitacora bitacora = new BEBitacora();

                        bitacora.Usuario = Sesion.ObtenerUsername().Usuario;
                        bitacora.Mensaje = "Ha registrado a usuario: " + usuario;
                        bitacora.Tipo = BitacoraTipo.INFO;
                        obllbitacora.GuardarBitacora(bitacora);

                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("datos incorrectos,corrobore lo ingresado");
                }
                cargargrilla();
                
               
                limpiar();
            }
        }
        
        private void cargargrilla()
        {
            datagridusuarios.DataSource = null;
            datagridusuarios.DataSource=obllusuario.ListarUsuarios();
            datagridusuarios.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            datagridusuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush;
            datagridusuarios.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btneliminarusuario_Click(object sender, EventArgs e)
        {
            ousuario = (BEUsuario)datagridusuarios.CurrentRow.DataBoundItem;
            obllusuario.Eliminar(ousuario);
            obllusuario.Guardardvv();
            BEBitacora bitacora = new BEBitacora();

            bitacora.Usuario = Sesion.ObtenerUsername().Usuario;
            bitacora.Mensaje = "Ha eliminado a usuario: " + ousuario;
            bitacora.Tipo = BitacoraTipo.INFO;
            obllbitacora.GuardarBitacora(bitacora);
            if (ousuario.Usuario == Sesion.ObtenerUsername().Usuario)
            {
                MessageBox.Show("Elimino el usuario de la sesion.");
                Application.Exit();
            }
            cargargrilla();
            cargarcambios(ousuario);
            limpiar();
           
        }


        void GuardarPalabras()
        {
            foreach(Control c in this.Controls)
            {
                if(c.Tag != null)
                {
                    bllrepositorio.GuardarPalabra(c.Tag.ToString());
                }
            }
        }
        private void cargarcambios(BEUsuario usuario)
        {
            datagridcambios.DataSource = null;
            datagridcambios.DataSource=obllusuario.Listarcambios(usuario);
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            
            Sesion.getinstace().AgregarObservador(this);
            cargargrilla();
            txtcontraseña.Hide();
            txtusuario.Hide();
            btneliminarusuarioRegistro.Hide();
            btnmodificarusuarioRegistro.Hide();
            btnregistrarusuario.Hide();
            label1.Hide();
            
            label2.Hide();
            //btnrestablecercontra.Hide();
            ActivarControles();
            
            

        }
        void ActivarControles()
        {
            if (Sesion.ObtenerUsername().permiso != null)
            {
                Recursiva(Sesion.ObtenerUsername().permiso);
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
                    if (perm.ID == 2)
                    {
                        btnregistrarusuario.Show();
                        label1.Show();
                        label2.Show();
                        txtusuario.Show();
                        txtcontraseña.Show();


                    }
                    if (perm.ID == 3)
                    {
                        label1.Show();
                        label2.Show();
                        txtusuario.Show();
                        txtcontraseña.Show();
                        btnmodificarusuarioRegistro.Show();
                        //btnrestablecercontra.Show();
                    }
                    if (perm.ID == 4)
                    {
                        btneliminarusuarioRegistro.Show();
                    }

                }
            }
        }

        private void btnmodificarusuario_Click(object sender, EventArgs e)
        {
           
           
           
            if (txtusuario.Text != "" || txtcontraseña.Text != "")
            {
                try
                {
                    ousuario = (BEUsuario)datagridusuarios.CurrentRow.DataBoundItem;
                    string texto2 = txtcontraseña.Text;
                    string texto = txtusuario.Text;

                    ousuario.Usuario = txtusuario.Text;
                    if (string.IsNullOrEmpty(txtusuario.Text)) throw new Exception("Ponga los datos como corresponde");
                    if (!Regex.IsMatch(texto, "^([a-zA-Z]+$)")) throw new Exception("Ponga los datos como corresponde");


                    ousuario.Contraseña = txtcontraseña.Text;
                    if (string.IsNullOrEmpty(txtcontraseña.Text)) throw new Exception("Ponga los datos como corresponde");
                    if (!Regex.IsMatch(texto2, "^([a-zA-Z0-9]+$)")) throw new Exception("Ponga los datos como corresponde");
                                       

                    obllusuario.Modificar(ousuario);
                    cargarcambios(ousuario);
                    obllusuario.Guardardvv();
                    BEBitacora bitacora = new BEBitacora();

                    bitacora.Usuario = Sesion.ObtenerUsername().Usuario;
                    bitacora.Mensaje = "Ha modificado contraseña al usuario: " + ousuario;
                    bitacora.Tipo = BitacoraTipo.INFO;
                    obllbitacora.GuardarBitacora(bitacora);
                    
                    if (ousuario.Usuario == Sesion.ObtenerUsername().Usuario)
                    {
                        MessageBox.Show("Debe volver a ingresar");
                        Application.Exit();
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("datos incorrectos,corrobore lo ingresado");
                }
                cargargrilla();
                
                limpiar();
                
            }
        }

        private void btnvolverpantallaAnterior_Click(object sender, EventArgs e)
        {
            Loguin log = new Loguin();
            log.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("estas seguro de salir?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();             

            }
        }

        private void datagridusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusuario.Text = datagridusuarios.SelectedCells[0].Value.ToString();
        }

        public void Update(int a)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag != null)
                {
                    BEIdioma idioma = new BEIdioma();
                    idioma.ID = a;
                    foreach (BETraduccion traduccion in bllrepositorio.ListarTraducciones(idioma))
                    {
                        if (c.Tag.ToString() == traduccion.tag)
                        {
                            c.Text = traduccion.Texto;
                        }
                    }

                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        BEUsuarioHistorico usuhis;
        private void btnrestaurarcambios_Click(object sender, EventArgs e)
        {
            usuhis = (BEUsuarioHistorico)datagridcambios.CurrentRow.DataBoundItem;
            obllusuario.Actualizar(usuhis);
            obllusuario.Guardardvv();
            try
            {
                cargarcambios((BEUsuario)datagridusuarios.SelectedRows[0].DataBoundItem);
            }
            catch (Exception)
            {

                throw;
            }
            

            cargargrilla();
            
        }

        private void datagridusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEUsuario usuario = (BEUsuario)datagridusuarios.SelectedRows[0].DataBoundItem;
            cargarcambios(usuario) ;
            datagridcambios.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void datagridusuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BEUsuario usuario = (BEUsuario)datagridusuarios.SelectedRows[0].DataBoundItem;
            cargarcambios(usuario);
            datagridcambios.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void datagridusuarios_TabIndexChanged(object sender, EventArgs e)
        {
            //BEUsuario usuario = (BEUsuario)datagridusuarios.SelectedRows[0].DataBoundItem;
            //cargarcambios(usuario);
        }
    }
}
