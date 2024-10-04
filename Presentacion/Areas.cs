using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        private CrearArea creararea;
        private AsignarEmpleadoArea asignararea;
        private ListadoAreas listadoareas;
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
    }   


}
