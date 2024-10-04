using BLL;
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
using Interfaces;

namespace Presentacion
{
    public partial class ListadoAreas : Form
    {
        public ListadoAreas()
        {
            InitializeComponent();
            bllarea = new BLLArea();
            BLLUsuario = new BLLUsuario();
        }
        BLLArea bllarea;
        BLLUsuario BLLUsuario;
        private void ListadoAreas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        void CargarGrilla()
        {
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = bllarea.ListarAreas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BEArea area = (BEArea)dgvAreas.SelectedRows[0].DataBoundItem;
            //bllarea.ListarEmpleados(area);

            var datosFiltrados = area.EmpleadosDelArea.Select(u => new
            {
                u.Usuario,
                u.Contraseña,
                u.Permiso,
                u.DVH
            }).ToList();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = datosFiltrados;
        }
    }
}
