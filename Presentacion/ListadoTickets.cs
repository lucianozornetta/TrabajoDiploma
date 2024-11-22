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
using Interfaces;

namespace Presentacion
{
    public partial class ListadoTickets : Form, IObserver
    {
        public ListadoTickets()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            bllwo = new BLLOrdenDeTrabajo();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public ListadoTickets(BEIdioma idiomaa)
        {
            InitializeComponent();
            idioma = idiomaa;
            bllusuario = new BLLUsuario();
            area = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            bllwo = new BLLOrdenDeTrabajo();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        Ticket Tickets;
        BLLRepositorioIdioma bllrepositorio;
        BEIdioma idioma;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        BLLUsuario bllusuario;
        BEArea area;
        BLLOrdenDeTrabajo bllwo;
        private void ListadoTickets_Load(object sender, EventArgs e)
        {
            //GuardarPalabras();
            Sesion.getinstace().AgregarObservador(this);
            cargargrilla();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
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
            if(idioma != null)
            {
                Tickets = new Ticket(WO,idioma);
            }
            else
            {
                Tickets = new Ticket(WO);
            }
            
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
