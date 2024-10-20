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
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
            crearAreaToolStripMenuItem.Enabled = false;
            asignarEmpleadosAAreaToolStripMenuItem.Enabled = false;
            listadoAreasToolStripMenuItem.Enabled = false;
            informesToolStripMenuItem.Enabled = false;
            ActivarControles();
        }
        private CrearArea creararea;
        private AsignarEmpleadoArea asignararea;
        private ListadoAreas listadoareas;
        private static MdiClient mdi;
        private Informes informe;


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

        private void asignarEmpleadosAAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (asignararea == null)
            {

                asignararea = new AsignarEmpleadoArea();
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

                listadoareas = new ListadoAreas();
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

        private void Areas_Load(object sender, EventArgs e)
        {
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
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (informe == null)
            {

                informe = new Informes();
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
    }   


}
