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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class MDITicketera : Form
    {
        public MDITicketera()
        {
            InitializeComponent();
        }
        private CrearOrdenTrabajo crearWO;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (crearWO == null)
            {
                crearWO = new CrearOrdenTrabajo();
                crearWO.MdiParent = this;
                crearWO.FormClosed += new FormClosedEventHandler(CerrarCrearWO);
                crearWO.Show();

            }
            else
            {
                crearWO.Activate();

            }
        }

        void CerrarCrearWO(object sender, FormClosedEventArgs e)
        {
            crearWO = null;
        }

        private void nuevaOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
