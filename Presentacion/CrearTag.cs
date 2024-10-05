using BE;
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

namespace Presentacion
{
    public partial class CrearTag : Form
    {
        public CrearTag()
        {
            InitializeComponent();
            blltag = new BLLTag();
        }
        BLLTag blltag;
        private void button1_Click(object sender, EventArgs e)
        {
            BETag tag = new BETag();
            try
            {
                tag.Nombre = txtTag.Text;
                blltag.GuardarTag(tag);
                MessageBox.Show("Se creo el tag correctamente");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
