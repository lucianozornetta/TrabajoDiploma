using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace Presentacion
{
    public partial class Informes : Form, IObserver
    {
        public Informes()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            bllorden = new BLLOrdenDeTrabajo();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public Informes(BEIdioma idioma)
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            bllorden = new BLLOrdenDeTrabajo();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLRepositorioIdioma bllrepositorio;

        BLLUsuario bllusuario;
        BEArea area;
        BLLOrdenDeTrabajo bllorden;
        private void button1_Click(object sender, EventArgs e)
        {
            List<BEOrdenDeTrabajo> ListaOrdenesTrabajo = bllorden.ListarOrdenesTrabajoConCerrados(area);
            bllorden.CrearInformeEmpleado(area);
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            //GuardarPalabras();
            Sesion.getinstace().AgregarObservador(this);
        }
        void GuardarPalabras()
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag != null)
                {
                    bllrepositorio.GuardarPalabra(c.Tag.ToString());
                }
            }
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
    }
}
