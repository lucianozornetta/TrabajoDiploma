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

namespace Presentacion
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            bllorden = new BLLOrdenDeTrabajo();
        }

        BLLUsuario bllusuario;
        BEArea area;
        BLLOrdenDeTrabajo bllorden;
        private void button1_Click(object sender, EventArgs e)
        {
            List<BEOrdenDeTrabajo> ListaOrdenesTrabajo = bllorden.ListarOrdenesTrabajoConCerrados(area);
            bllorden.CrearInformeEmpleado(area);
        }
       
    }
}
