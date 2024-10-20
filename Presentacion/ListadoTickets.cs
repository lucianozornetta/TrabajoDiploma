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
            cargargrilla();
            
        }
        void cargargrilla()
        {
            dataGridView1.DataSource = bllwo.ListarOrdenesTrabajo(area);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ReadOnly = true;
        }

        private void btnAbrirWO_Click(object sender, EventArgs e)
        {
            BEOrdenDeTrabajo WO = (BEOrdenDeTrabajo) dataGridView1.SelectedRows[0].DataBoundItem;
            Tickets = new Ticket(WO);
            Tickets.FormClosed += (s, args) => Tickets = null;
            Tickets.Show();
            WO = null;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bllwo.ListarOrdenesTrabajo(area);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bllwo.ListarOrdenTrabajoCliente(area);
            }
        }
    }
}
