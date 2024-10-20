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
    public partial class VerTexto : Form
    {
        public VerTexto(string a)
        {
            InitializeComponent();
            richTextBox1.Text = a;
            richTextBox1.ReadOnly = true;
        }

        private void VerTexto_Load(object sender, EventArgs e)
        {

        }
    }
}
