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
    public partial class Idiomas : Form , IObserver
    {
        public Idiomas()
        {
            InitializeComponent();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public Idiomas(BEIdioma idioma)
        {
            InitializeComponent();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLRepositorioIdioma bllrepositorio;
        private void btnCrearIdioma_Click(object sender, EventArgs e)
        {
            BEIdioma idioma = new BEIdioma();
            idioma.nombre = txtNombreIdiomaCrear.Text;
            bllrepositorio.GuardarIdioma(idioma);
            MessageBox.Show("Idioma creado con exito");

        }

        private void Idiomas_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            cmbIdiomaAModificar.DataSource = null;
            cmbIdiomaAModificar.DataSource = bllrepositorio.ListarIdiomas();
            CargarGrilla();
            labelnombreidioma.Hide();
            lblidioma.Hide();
            btnCrearIdioma.Hide();
            btnModificarIdioma.Hide();
            txtNombreIdiomaCrear.Hide();
            cmbIdiomaAModificar.Hide();
            ActivarControles();
            ColorearGrilla();
            
        }
        void ColorearGrilla()
        {
            dgvIdiomas.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvIdiomas.AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush;
        }

        void ActivarControles()
        {
            if (Sesion.ObtenerUsername().Permiso != null)
            {
                Recursiva(Sesion.ObtenerUsername().Permiso);
            }

        }
        void Recursiva(BEPermiso permiso)
        {
            foreach (BEPermiso perm in permiso.PermisosHijos)
            {
                if (perm.EsPadre == true)
                {
                    Recursiva(perm);
                }
                else
                {
                    if (perm.ID == 50)
                    {
                        btnCrearIdioma.Show();
                        labelnombreidioma.Show();                       
                        txtNombreIdiomaCrear.Show();
                        


                    }
                    if (perm.ID == 51)
                    {
                     
                        lblidioma.Show();
                        cmbIdiomaAModificar.Show();                       
                        btnModificarIdioma.Show();
                    }
                   

                }
            }
        }
        void GuardarPalabras()
        {
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c.Tag != null)
                {
                    bllrepositorio.GuardarPalabra(c.Tag.ToString());
                }
            }
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c.Tag != null)
                {
                    bllrepositorio.GuardarPalabra(c.Tag.ToString());
                }
            }
        }

        public void Update(int a)
        {
            foreach (Control c in this.groupBox1.Controls)
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
            foreach (Control c in this.groupBox2.Controls)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbIdiomaAModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BETraduccion> lista = bllrepositorio.ListarTraducciones((BEIdioma) cmbIdiomaAModificar.SelectedItem);
            dgvIdiomas.DataSource = null;
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            dgvIdiomas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdiomas.AllowUserToAddRows = false;
            dgvIdiomas.AllowUserToDeleteRows = false;
            dgvIdiomas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIdiomas.RowHeadersVisible = false;
            dgvIdiomas.Columns.Clear();
            dgvIdiomas.Rows.Clear();

            DataGridViewTextBoxColumn parameterColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Parámetro",
                Name = "Parámetro",
                ReadOnly = true
            };
            dgvIdiomas.Columns.Add(parameterColumn);

            DataGridViewTextBoxColumn valueColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Valor",
                Name = "Valor",
                ReadOnly = false
            };
            dgvIdiomas.Columns.Add(valueColumn);

            Dictionary<int, string> dic = bllrepositorio.ListarPalabras();
            List<BETraduccion> listatraducciones = bllrepositorio.ListarTraducciones((BEIdioma)cmbIdiomaAModificar.SelectedItem);
            foreach (var d in dic)
            {
                
                BETraduccion traduccion = listatraducciones.Find(t => t.tag == d.Value);             
                dgvIdiomas.Rows.Add(d.Value, traduccion != null ? traduccion.Texto : "");
            }
        }

        private void btnModificarIdioma_Click(object sender, EventArgs e)
        {
            BEIdioma idioma = (BEIdioma) cmbIdiomaAModificar.SelectedItem;
            idioma.ListaTraducciones = new List<BETraduccion>();
            
            foreach(DataGridViewRow row in dgvIdiomas.Rows)
            {
                BETraduccion traduccion = new BETraduccion();
                traduccion.tag = row.Cells[0].Value.ToString();
                if(row.Cells[1].Value.ToString() != null)
                {
                    traduccion.Texto = row.Cells[1].Value.ToString();
                }
                else
                {
                    traduccion.Texto = "";
                }
                
                idioma.ListaTraducciones.Add(traduccion);
            }
            if (bllrepositorio.ModificarIdioma(idioma))
            {
                MessageBox.Show("Se realizaron los cambios en el idioma");
            }
           
        }

        private void dgvIdiomas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
