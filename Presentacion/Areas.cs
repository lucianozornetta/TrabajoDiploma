using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;
using Interfaces;

namespace Presentacion
{
    public partial class Areas : Form, IObserver
    {
        public Areas()
        {
            InitializeComponent();
            crearAreaToolStripMenuItem.Enabled = false;
            asignarEmpleadosAAreaToolStripMenuItem.Enabled = false;
            listadoAreasToolStripMenuItem.Enabled = false;
            informesToolStripMenuItem.Enabled = false;
            bllrepositorio = new BLLRepositorioIdioma();
            ActivarControles();
        }
        public Areas(BEIdioma idiomaa)
        {
            InitializeComponent();
            idioma = idiomaa;
            crearAreaToolStripMenuItem.Enabled = false;
            asignarEmpleadosAAreaToolStripMenuItem.Enabled = false;
            listadoAreasToolStripMenuItem.Enabled = false;
            informesToolStripMenuItem.Enabled = false;
            bllrepositorio = new BLLRepositorioIdioma();
            ActivarControles();
            Update(idioma.ID);
        }
        BEIdioma idioma;
        private CrearArea creararea;
        private AsignarEmpleadoArea asignararea;
        private ListadoAreas listadoareas;
        private static MdiClient mdi;
        private Informes informe;
        BLLRepositorioIdioma bllrepositorio;

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
                    if (perm.ID == 61)
                    {
                        crearAreaToolStripMenuItem.Enabled = true;
                    }
                    if(perm.ID == 63 )
                    {
                        asignarEmpleadosAAreaToolStripMenuItem.Enabled = true;
                    }
                    if(perm.ID == 65)
                    {
                        listadoAreasToolStripMenuItem.Enabled = true;
                    }
                    if (perm.ID == 71)
                    {
                        informesToolStripMenuItem.Enabled = true;
                    }
                    

                }
            }
        }



        private void crearAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (creararea == null)
            {
                if(idioma != null)
                {
                    creararea = new CrearArea(idioma);
                }
                else
                {
                    creararea = new CrearArea();
                }
                
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

        private void asignarEmpleadosAAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (asignararea == null)
            {
                if(idioma != null)
                {
                    asignararea = new AsignarEmpleadoArea(idioma);
                }
                else
                {
                    asignararea = new AsignarEmpleadoArea();
                }
                
                asignararea.MdiParent = this;
                asignararea.FormClosed += new FormClosedEventHandler(CerrarAsignarArea);
                asignararea.Show();
            }
            else
            {
                asignararea.Activate();

            }
        }
        void CerrarAsignarArea(object sender, FormClosedEventArgs e)
        {
            asignararea = null;
        }

        private void listadoAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listadoareas == null)
            {
                if(idioma != null)
                {
                    listadoareas = new ListadoAreas(idioma);
                }
                else
                {
                    listadoareas = new ListadoAreas();
                }
                
                listadoareas.MdiParent = this;
                listadoareas.FormClosed += new FormClosedEventHandler(CerrarListadoAreas);
                listadoareas.Show();
            }
            else
            {
                listadoareas.Activate();

            }
        }
        void CerrarListadoAreas(object sender, FormClosedEventArgs e)
        {
            listadoareas = null;
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
        private void Areas_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            foreach (Control control in this.Controls)
            {

                try
                {
                    mdi = (MdiClient)control;
                    mdi.BackColor = Color.FromArgb(120, 150, 200);

                }
                catch (Exception)
                {


                }

            }
            //GuardarPalabras();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (informe == null)
            {
                if(idioma != null)
                {
                    informe = new Informes(idioma);
                }
                else
                {
                    informe = new Informes();
                }
                informe.MdiParent = this;
                informe.FormClosed += new FormClosedEventHandler(CerrarInformes);
                informe.Show();
            }
            else
            {
                informe.Activate();

            }
        }
        void CerrarInformes(object sender, FormClosedEventArgs e)
        {
            informe = null;
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
    }   


}
