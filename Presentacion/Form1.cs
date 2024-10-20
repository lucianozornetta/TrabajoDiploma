using BE;
using Presentacion;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using BLL;

namespace Presentacion
{
    public partial class Form1 : Form, IObserver
    {
        private Registro or;
        private Bitacora bitacora;
        private  MdiClient mdi;
        private Permisos permisos;
        private AsignarPermisos asignarpermisos;
        private Idiomas idiomas;
        private BLLRepositorioIdioma bllrepositorio;
        private CrearArea creararea;
        private Areas areas;
        private MDITicketera mditicketera;
        Loguin log;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(CerrarAplicacion);
            foreach (Control control in this.Controls)
            {

                try
                {
                    mdi = (MdiClient)control;
                    mdi.BackColor = Color.LightBlue;

                }
                catch (Exception)
                {


                }
                verBitacoraToolStripMenuItem.Enabled = false;
                registroToolStripMenuItem.Enabled = false;
                gestionPermisosToolStripMenuItem.Enabled = false;
                asignarPermisosToolStripMenuItem.Enabled = false;
                gestionarIdiomasToolStripMenuItem.Enabled = false;
                alteradosToolStripMenuItem.Enabled = false;
                areasToolStripMenuItem.Enabled = false;
                ticketeraToolStripMenuItem.Enabled = false;

                int centerX = 0;
                comboBox1.Location = new System.Drawing.Point(centerX, comboBox1.Location.Y);
            }
            ActivarControles();
        }
        void CerrarAplicacion(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (or == null)
            {

                if (comboBox1.SelectedIndex >= 0)
                {
                    or = new Registro((BEIdioma)comboBox1.SelectedItem);
                }
                else
                {
                    or = new Registro();
                }
                or.MdiParent = this;
                or.FormClosed += new FormClosedEventHandler(CerrarRegistro);
                or.Show();

            }
            else
            {
                or.Activate();

            }

        }

        void CerrarRegistro(object sender, FormClosedEventArgs e)
        {
            or = null;
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Sesion.Logout();
                MessageBox.Show("Se ha cerrado la sesion");
                Loguin log = new Loguin();
                log.Show();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void verBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verBitacoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (bitacora == null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    bitacora = new Bitacora((BEIdioma)comboBox1.SelectedItem);
                }
                else
                {
                    bitacora = new Bitacora();
                }

                bitacora.MdiParent = this;
                bitacora.FormClosed += new FormClosedEventHandler(CerrarBitacora);
                bitacora.Show();

            }
            else
            {
                bitacora.Activate();

            }

        }
        void CerrarBitacora(object sender, FormClosedEventArgs e)
        {
            bitacora = null;
        }
        BLLUsuario obllusu = new BLLUsuario();
        private void Form1_Load(object sender, EventArgs e)
        {
            bllrepositorio = new BLLRepositorioIdioma();
            Sesion.getinstace().AgregarObservador(this);
            comboBox1.DataSource = null;
            comboBox1.DataSource = bllrepositorio.ListarIdiomas();
            comboBox1.SelectedIndex = -1;


            //bool usuariosAlterados = false;
            //usuariosAlterados = obllusu.chequearDVV();
            //if (usuariosAlterados)
            //{
            //    MessageBox.Show("Los usuarios fueron vulnerados por fuera del sistema. Solo lo puede solucionar el administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    UsuariosAlterados frmUsuariosAlterados = new UsuariosAlterados();
            //    frmUsuariosAlterados.MdiParent = this;
            //    frmUsuariosAlterados.Show();

            //    MessageBox.Show("Desea solucionarlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    log = new Loguin();
            //    log.MdiParent = this;
            //    log.FormClosed += new FormClosedEventHandler(cerrarLog);
            //    log.Show();

            //}
            //log = new Loguin();
            //log.MdiParent = this;
            //log.FormClosed += new FormClosedEventHandler(cerrarLog);
            //log.Show();

        }
        void cerrarLog(object sender, FormClosedEventArgs e)
        {
            log = null;
        }
        void GuardarPalabras()
        {
            foreach (ToolStripItem c in this.menuStrip1.Items)
            {
                if (c.Tag.ToString() != null)
                {
                    bllrepositorio.GuardarPalabra(c.Tag.ToString());
                }
            }
        }

        private void gestionPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    permisos = new Permisos((BEIdioma)comboBox1.SelectedItem);
                }
                else
                {
                    permisos = new Permisos();
                }

                permisos.MdiParent = this;
                permisos.FormClosed += new FormClosedEventHandler(CerrarPermisos);
                permisos.Show();

            }
            else
            {
                permisos.Activate();

            }

        }
        void CerrarPermisos(object sender, FormClosedEventArgs e)
        {
            permisos = null;
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asignarpermisos == null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    asignarpermisos = new AsignarPermisos((BEIdioma)comboBox1.SelectedItem);
                }
                else
                {
                    asignarpermisos = new AsignarPermisos();
                }

                asignarpermisos.MdiParent = this;
                asignarpermisos.FormClosed += new FormClosedEventHandler(CerrarAsignarPermisos);
                asignarpermisos.Show();

            }
            else
            {
                asignarpermisos.Activate();

            }
        }
        void CerrarAsignarPermisos(object sender, FormClosedEventArgs e)
        {
            asignarpermisos = null;
        }

        void ActivarControles()
        {
            if (Sesion.ObtenerUsername().Permiso != null)
            {
                Recursiva(Sesion.ObtenerUsername().Permiso);
            }
            else
            {
                MessageBox.Show("Su usuario no tiene permisos asignados");

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
                    if (perm.ID == 49)
                    {
                        gestionarIdiomasToolStripMenuItem.Enabled = true;
                    }
                    if (perm.ID == 1)
                    {
                        registroToolStripMenuItem.Enabled = true;
                    }
                    if (perm.ID == 5)
                    {
                        verBitacoraToolStripMenuItem.Enabled = true;
                    }
                    if (perm.ID == 6)
                    {
                        gestionPermisosToolStripMenuItem.Enabled = true;
                    }
                    if (perm.ID == 9)
                    {
                        asignarPermisosToolStripMenuItem.Enabled = true;
                    }
                    if (perm.ID == 55)
                    {
                        alteradosToolStripMenuItem.Enabled = true;
                    }
                    if(perm.ID == 60)
                    {
                        areasToolStripMenuItem.Enabled = true;
                    }
                    if(perm.ID == 73)
                    {
                        ticketeraToolStripMenuItem.Enabled = true;
                    }

                }
            }
        }

        public void Update(int a)
        {

            foreach (ToolStripItem c in this.menuStrip1.Items)
            {
                if (c.Tag != null)
                {


                    if (c.Tag.ToString() != null)
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
        }

        private void gestionarIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idiomas == null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    idiomas = new Idiomas((BEIdioma)comboBox1.SelectedItem);
                }
                else
                {
                    idiomas = new Idiomas();
                }

                idiomas.MdiParent = this;
                idiomas.FormClosed += new FormClosedEventHandler(CerrarIdiomas);
                idiomas.Show();

            }
            else
            {
                idiomas.Activate();

            }

        }
        void CerrarIdiomas(object sender, FormClosedEventArgs e)
        {
            idiomas = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Sesion.getinstace().CambioDeEstado((BEIdioma)comboBox1.SelectedItem);
            }
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        UsuariosAlterados usualt;
        private void alteradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usualt == null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    usualt = new UsuariosAlterados((BEIdioma)comboBox1.SelectedItem);
                }
                else
                {
                    usualt = new UsuariosAlterados();
                }


                usualt.MdiParent = this;
                usualt.FormClosed += new FormClosedEventHandler(cerraralt);
                usualt.Show();

            }
            else
            {
                usualt.Activate();

            }
        }
        void cerraralt(object sender, FormClosedEventArgs e)
        {
            usualt = null;
        }

        private void crearAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (creararea == null)
            {

                creararea = new CrearArea();
                creararea.MdiParent = this;
                creararea.FormClosed += new FormClosedEventHandler(CerrarCrearArea);
                creararea.Show();
            }
            else
            {
                creararea.Activate();

            }
        }
        void CerrarCrearArea(object sender, FormClosedEventArgs e)
        {
            creararea = null;
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            areas = new Areas();
            areas.FormClosed += (s, args) => this.Show();
            areas.Show();
            this.Hide();
            
        }

        private void ticketeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mditicketera = new MDITicketera();
            mditicketera.FormClosed += (s, args) => this.Show();
            mditicketera.Show();
            this.Hide();
        }
    }
}
