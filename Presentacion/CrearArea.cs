using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using Servicios;
using System.Security.Cryptography.X509Certificates;

namespace Presentacion
{
    public partial class CrearArea : Form
    {
        public CrearArea()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            bllarea = new BLLArea();

        }
        BLLUsuario bllusuario;
        BLLArea bllarea;
        private void CrearArea_Load(object sender, EventArgs e)
        {
            cmbResponsable.DataSource = null;
            cmbResponsable.DataSource = bllusuario.ListarUsuarios();

        }

        private void btnCrearArea_Click(object sender, EventArgs e)
        {
            BEArea area = new BEArea();
            area.Nombre = txtNombreArea.Text;
            area.Responsable = (BEUsuario)cmbResponsable.SelectedItem;
            bllarea.CrearArea(area);
        }
    }
}
