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
    public partial class UsuariosAlterados : Form, IObserver
    {
        BLLUsuario oBLLusuario = new BLLUsuario();
        BEUsuario usu;
        BLLRepositorioIdioma bllrepositorio;
        public UsuariosAlterados()
        {
            InitializeComponent();
            oBLLusuario=new BLLUsuario();
            usu=new BEUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public UsuariosAlterados(BEIdioma idioma)
        {
            InitializeComponent();
            oBLLusuario = new BLLUsuario();
            usu = new BEUsuario();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }

        private void UsuariosAlterados_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            actualizar();
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
        private void actualizar()
        {
            datagridalterados.DataSource = null;
            datagridalterados.DataSource= oBLLusuario.chequearDVH();
        }
        private void btnrecalcular_Click(object sender, EventArgs e)
        {
            usu = (BEUsuario)datagridalterados.CurrentRow.DataBoundItem;
            oBLLusuario.RecalcularDVH(usu);
            actualizar();
        }
    }
}
