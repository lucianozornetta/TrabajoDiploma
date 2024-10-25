using BE;
using BLL;
using Interfaces;
using Servicios;
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
    public partial class Bitacora : Form , IObserver
    {
        BLLBitacora obllbitacora;
        BLLUsuario obllusuario;
        BLLRepositorioIdioma bllrepositorio;
        string texto;
        public Bitacora()
        {
            InitializeComponent();
            obllbitacora = new BLLBitacora();
            obllusuario = new BLLUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
            cmbUsuario.DataSource = obllusuario.ListarUsuariosConEliminados();            
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }
        public Bitacora(BEIdioma idioma)
        {
            InitializeComponent();
            obllbitacora = new BLLBitacora();
            obllusuario = new BLLUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
            cmbUsuario.DataSource = obllusuario.ListarUsuariosConEliminados();
            Update(idioma.ID);
        }



        private void Bitacora_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            cmbUsuario.SelectedIndex = -1;
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
        void ColorearGrilla()
        {
            datagridBitacora.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            datagridBitacora.AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush;
            datagridBitacora.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<BEBitacora> listabitacoras = new List<BEBitacora>();


            FiltroBitacora filtro = new FiltroBitacora();
            filtro.Desde = Convert.ToDateTime(dateTimeDesde.Value.ToShortDateString());
            filtro.Hasta = Convert.ToDateTime(dateTimeHasta.Value.ToShortDateString());
            if (cmbUsuario.SelectedIndex != -1)
            {
                filtro.usuario = cmbUsuario.SelectedItem.ToString();
            }//aa
            
            if (cmbTipo.SelectedIndex == 0)
            {
                filtro.tipo = BitacoraTipo.INFO;
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                filtro.tipo = BitacoraTipo.ERROR;

            }
            else
            {
                filtro.tipo = BitacoraTipo.ALL;
            }
            listabitacoras = obllbitacora.ListarBitacoras(filtro);

            datagridBitacora.DataSource = null;
            datagridBitacora.DataSource = listabitacoras;
            ColorearGrilla();

        }
        
       
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
