using BE;
using BLL;
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
using BLL;
using Interfaces; 

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class MDITicketera : Form, IObserver
    {

        public MDITicketera()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public MDITicketera(BEIdioma idiomaa)
        {
            InitializeComponent();
            idioma = idiomaa;
            bllusuario = new BLLUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BEIdioma idioma;
        BLLRepositorioIdioma bllrepositorio;
        private static MdiClient mdi;
        private CrearOrdenTrabajo crearWO;
        private ListadoTickets listartickets;
        BLLUsuario bllusuario;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        void CerrarCrearWO(object sender, FormClosedEventArgs e)
        {
            crearWO = null;
        }

        private void nuevaOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            BEArea area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            if (area == null)
            {
                MessageBox.Show("Su usuario no puede acceder a este menu");
            }
            else
            {
                if (crearWO == null)
                {
                    if(idioma != null)
                    {
                        crearWO = new CrearOrdenTrabajo(idioma);
                    }
                    else
                    {
                        crearWO = new CrearOrdenTrabajo();
                    }
                    
                    crearWO.MdiParent = this;
                    crearWO.FormClosed += new FormClosedEventHandler(CerrarCrearWO);
                    crearWO.Show();

                }
                else
                {
                    crearWO.Activate();

                }
            }

        }

        private void verTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {



            BEArea area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            if (area == null)
            {
                MessageBox.Show("Su usuario no puede acceder a este menu");
            }
            else
            {
                if (listartickets == null)
                {
                    if(idioma != null)
                    {
                        listartickets = new ListadoTickets(idioma);
                    }
                    else
                    {
                        listartickets = new ListadoTickets();
                    }
                    
                    listartickets.MdiParent = this;
                    listartickets.FormClosed += new FormClosedEventHandler(CerrarListarTickets);
                    listartickets.Show();

                }
                else
                {
                    listartickets.Activate();

                }
            }

        }
        void CerrarListarTickets(object sender, FormClosedEventArgs e)
        {
            listartickets = null;
        }

        private void MDITicketera_Load(object sender, EventArgs e)
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
                //GuardarPalabras();
            }

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
