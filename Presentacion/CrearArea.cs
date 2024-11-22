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
using Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace Presentacion
{
    public partial class CrearArea : Form,IObserver
    {
        public CrearArea()
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            bllarea = new BLLArea();
            bllrepositorio = new BLLRepositorioIdioma();

        }
        public CrearArea(BEIdioma idioma)
        {
            InitializeComponent();
            bllusuario = new BLLUsuario();
            bllarea = new BLLArea();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLUsuario bllusuario;
        BLLArea bllarea;
        BLLRepositorioIdioma bllrepositorio;
        private void CrearArea_Load(object sender, EventArgs e)
        {
            Actualizar();
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
        void Actualizar()
        {
            cmbResponsable.DataSource = null;
            cmbResponsable.DataSource = bllusuario.ListarUsuarios();
            cmbResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCrearArea_Click(object sender, EventArgs e)
        {
            BEArea area = new BEArea();
            area.Nombre = txtNombreArea.Text;
            area.Responsable = (BEUsuario)cmbResponsable.SelectedItem;
            if (area.Responsable.Area == null)
            {
                if (bllarea.ValidarNombre(area.Nombre))
                {
                    bllarea.CrearArea(area);
                    bllusuario.AsignarAreaUsuario(area.Responsable, area);
                    MessageBox.Show("Se creo al area.");
                }
                else
                {
                    MessageBox.Show("Ya existe un area con ese nombre");
                }
               
                
            }
            else
            {
                MessageBox.Show("El empleado no puede ser responsable del area porque ya pertenece a otra area.");
            }
            
            Actualizar();
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
