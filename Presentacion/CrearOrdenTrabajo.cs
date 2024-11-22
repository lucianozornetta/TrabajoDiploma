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
using Interfaces;
using System.Diagnostics.Eventing.Reader;


namespace Presentacion
{
    public partial class CrearOrdenTrabajo : Form, IObserver
    {
        public CrearOrdenTrabajo()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            blltag = new BLLTag();
            bllarea = new BLLArea();
            bllordentrabajo = new BLLOrdenDeTrabajo();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public CrearOrdenTrabajo(BEIdioma idioma)
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            blltag = new BLLTag();
            bllarea = new BLLArea();
            bllordentrabajo = new BLLOrdenDeTrabajo();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLUsuario bllusuario;
        BLLRepositorioIdioma bllrepositorio;
        BLLTag blltag;
        BLLArea bllarea;
        BLLOrdenDeTrabajo bllordentrabajo;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearOrdenTrabajo_Load(object sender, EventArgs e)
        {
            ActualizarControladores();
            Sesion.getinstace().AgregarObservador(this);
            cmbAreaWO.SelectedIndex = -1;
            cmbTags.SelectedIndex = -1;
            cmbTags.Hide();
            txtNumero.Text = Convert.ToString(bllordentrabajo.ObtenerProximoNumeroWO());
            cmbImpacto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrgencia.DropDownStyle = ComboBoxStyle.DropDownList;
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
        void CargarCheckedListbox()
        {
            ListTags.Items.Clear();
            List<BETag> tags = blltag.ListarTags();
            foreach(BETag TAG in  tags)
            {
                ListTags.Items.Add(TAG);
            }

        }
        void ActualizarControladores()
        {
            ActualizarCMBArea();
            ActualizarCMBTags();
            CargarCheckedListbox();
        }
        void ActualizarCMBArea()
        {
            cmbAreaWO.DataSource = null;
            cmbAreaWO.DataSource = bllarea.ListarAreas();
            cmbAreaWO.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        void ActualizarCMBTags()
        {
            cmbTags.DataSource = null;
            cmbTags.DataSource = blltag.ListarTags();
            cmbTags.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int costo = 0;
                switch (cmbImpacto.SelectedIndex)
                {
                    case 0: costo += 1; break;
                    case 1: costo += 2; break;
                    case 2: costo += 3; ; break;
                }

                switch (cmbUrgencia.SelectedIndex)
                {
                    case 0: costo += 1; break;
                    case 1: costo += 2; break;
                    case 2: costo += 3; ; break;
                }
                FabricaOrdenesTrabajo fabrica = new FabricaOrdenesTrabajo();
                BEOrdenDeTrabajo WO = fabrica.CrearOrdenTrabajo(costo);

                WO.Numero = bllordentrabajo.ObtenerProximoNumeroWO();
                WO.FechaInicio = DateTime.Now;
                WO.Cliente = Sesion.ObtenerUsername();
                WO.Cliente.Area = bllusuario.BuscarArea(WO.Cliente);
                WO.Resumen = txtResumenWO.Text;
                WO.Notas = RtxtNotasWO.Text;
                WO.area = (BEArea)cmbAreaWO.SelectedItem;
                WO.CalcularFechaLimite();
                foreach (BETag TAG in ListTags.CheckedItems)
                {
                    WO.Tags.Add(TAG);
                }
                bllordentrabajo.GuardarWorkOrder(WO);

            }
            catch (Exception)
            {

                MessageBox.Show("Datos no validos.");
            }
           
        }

        private void ListTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<BETag> tags = new List<BETag>();
            //foreach(BETag TAG in ListTags.CheckedItems)
            //{
            //    tags.Add(TAG);
            //}
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
