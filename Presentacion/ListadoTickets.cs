using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Servicios;
using BLL;

namespace Presentacion
{
    public partial class ListadoTickets : Form
    {
        public ListadoTickets()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            bllwo = new BLLOrdenDeTrabajo();
        }
        Ticket Tickets;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        BLLUsuario bllusuario;
        BEArea area;
        BLLOrdenDeTrabajo bllwo;
        private void ListadoTickets_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllwo.ListarOrdenesTrabajo(area);
            
        }

        private void btnAbrirWO_Click(object sender, EventArgs e)
        {
            
            Tickets = new Ticket();
            Tickets.Show();
           
        }
    }
}
