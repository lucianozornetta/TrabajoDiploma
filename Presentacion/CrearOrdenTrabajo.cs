using BLL;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Presentacion
{
    public partial class CrearOrdenTrabajo : Form
    {
        public CrearOrdenTrabajo()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            blltag = new BLLTag();
            bllarea = new BLLArea();
        }
        BLLUsuario bllusuario;
        BLLTag blltag;
        BLLArea bllarea;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearOrdenTrabajo_Load(object sender, EventArgs e)
        {
            ActualizarControladores();
            cmbAreaWO.SelectedIndex = -1;
            cmbTags.SelectedIndex = -1;
        }
        void ActualizarControladores()
        {
            ActualizarCMBArea();
            ActualizarCMBTags();
        }
        void ActualizarCMBArea()
        {
            cmbAreaWO.DataSource = null;
            cmbAreaWO.DataSource = bllarea.ListarAreas();

        }
        void ActualizarCMBTags()
        {
            cmbTags.DataSource = null;
            cmbTags.DataSource = blltag.ListarTags();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int costo = 0;
            switch (cmbImpacto.SelectedIndex)
            {
                case 0: costo += 1;break;
                case 1: costo += 2; break; 
                case 2: costo += 3; ; break;
            }

            switch(cmbUrgencia.SelectedIndex)
            {
                case 0: costo += 1; break;
                case 1: costo += 2; break;
                case 2: costo += 3; ; break;
            }
            FabricaOrdenesTrabajo fabrica = new FabricaOrdenesTrabajo();
            BEOrdenDeTrabajo WO = fabrica.CrearOrdenTrabajo(costo);
        }
    }
}
