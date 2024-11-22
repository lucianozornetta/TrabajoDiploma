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
using Interfaces;
using Servicios;

namespace Presentacion
{
    public partial class CrearTag : Form, IObserver
    {
        public CrearTag()
        {
            InitializeComponent();
            blltag = new BLLTag();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public CrearTag(BEIdioma idioma)
        {
            InitializeComponent();
            blltag = new BLLTag();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLRepositorioIdioma bllrepositorio;
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

        private void CrearTag_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            //GuardarPalabras();
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
