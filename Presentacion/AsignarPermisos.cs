using BE;
using BLL;
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
using Interfaces;

namespace Presentacion
{
    public partial class AsignarPermisos : Form , IObserver
    {
        public AsignarPermisos()
        {
            InitializeComponent();
            bllpermiso = new BLLPermiso();
            BLLUsuario = new BLLUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public AsignarPermisos(BEIdioma idioma)
        {
            InitializeComponent();
            bllpermiso = new BLLPermiso();
            BLLUsuario = new BLLUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLPermiso bllpermiso;
        BLLUsuario BLLUsuario;
        BLLRepositorioIdioma bllrepositorio;
        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = (BEUsuario)cmbUsuario.SelectedItem;
                if ( usuario.Area == null) 
                {
                    MessageBox.Show("No puede asignarle un permiso sin antes asignarle un area");
                }
                else
                {
                    if (BLLUsuario.AsignarPermisoAUsuario((BEPermiso)cmbPermiso.SelectedItem, (BEUsuario)cmbUsuario.SelectedItem))
                    {
                        MessageBox.Show("Se le asigno el permiso correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya tiene un permiso asignado");
                    }
                }
                
            }
            catch (Exception)
            {

                
            }
            cmbPermiso.DataSource = bllpermiso.ListarPermisosCompuestos();
            cmbUsuario.DataSource = BLLUsuario.ListarUsuarios();
        }

        private void AsignarPermisos_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            cmbPermiso.DataSource = bllpermiso.ListarPermisosCompuestos();
            cmbPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.DataSource = BLLUsuario.ListarUsuarios();
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
           
            
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

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLLUsuario.QuitarPermisos((BEUsuario)cmbUsuario.SelectedItem))
                {
                    MessageBox.Show("Se le quitaron los permisos al usuario");
                }
            }
            catch (Exception)
            {

                throw;
            }
            cmbPermiso.DataSource = bllpermiso.ListarPermisosCompuestos();
            cmbUsuario.DataSource = BLLUsuario.ListarUsuarios();
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
