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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            dgvDetalleWO.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvDetalleWO.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvDetalleWO.ReadOnly = true;
            dgvDetalleWO.RowHeadersVisible = false;
            dgvDetalleWO.Columns.Add("RelationshipType", "Relationship Type");
            dgvDetalleWO.Columns.Add("RequestType", "Request Type");
            dgvDetalleWO.Columns.Add("RequestSummary", "Request Summary");
            dgvDetalleWO.Columns.Add("Status", "Status");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Columns[0].Width = 150; // Ajusta según sea necesario
            dgvDetalleWO.Columns[1].Width = 100;
            dgvDetalleWO.Columns[2].Width = 300;
            dgvDetalleWO.Columns[3].Width = 100;
        }
        //        //AGREGAR COLUMNAS dataGridView1.Columns.Add("RelationshipType", "Relationship Type");
        //        dataGridView1.Columns.Add("RequestType", "Request Type");
        //        dataGridView1.Columns.Add("RequestSummary", "Request Summary");
        //        dataGridView1.Columns.Add("Status", "Status");

        //AGREGAR FILAS dataGridView1.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");




        //REGULAR TAMAÑO COLUMNAS

        //        dataGridView1.Columns[0].Width = 150; // Ajusta según sea necesario
        //dataGridView1.Columns[1].Width = 100;
        //dataGridView1.Columns[2].Width = 300;
        //dataGridView1.Columns[3].Width = 100;
    }
}
