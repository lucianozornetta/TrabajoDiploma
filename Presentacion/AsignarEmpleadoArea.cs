using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Servicios;
using BLL;

namespace Presentacion
{
    public partial class AsignarEmpleadoArea : Form
    {
        public AsignarEmpleadoArea()
        {
            InitializeComponent();
            bllarea = new BLLArea();
            bllusuario = new BLLUsuario();
        }
        BLLArea bllarea;
        BLLUsuario bllusuario;

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void CargarGrilla()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = bllusuario.ListarUsuarios();
        }
        void CargarCMB()
        {
            cmbAreas.DataSource = null;
            cmbAreas.DataSource = bllarea.ListarAreas();
        }
        void Actualizar()
        {
            CargarGrilla();
            CargarCMB();
        }
        private void AsignarEmpleadoArea_Load(object sender, EventArgs e)
        {
            Actualizar();
            label1.Show();
        }

        private void btnAsignarArea_Click(object sender, EventArgs e)
        {
            BEUsuario usuario = (BEUsuario)dgvEmpleados.SelectedRows[0].DataBoundItem;
            BEArea area = (BEArea)cmbAreas.SelectedItem;
            if (usuario.Area == null)
            {
                bllusuario.AsignarAreaUsuario(usuario, area);
                MessageBox.Show("Se asigno el area correspondiente");
            }
            else
            {
                MessageBox.Show("El empleado ya tiene un area asignada");
            }
            Actualizar();
        }

        private void btnRemoverArea_Click(object sender, EventArgs e)
        {
            BEUsuario usuario = (BEUsuario)dgvEmpleados.SelectedRows[0].DataBoundItem;
            if(usuario.Area == null)
            {
                MessageBox.Show("El usuario seleccionado no pertenece a ningun area");
            }
            else
            {
                if(usuario.Usuario == usuario.Area.Responsable.Usuario)
                {
                    MessageBox.Show("No puede remover el area dado que es el responsable de la misma");
                }
                else
                {
                    bllusuario.RemoverDeArea(usuario);
                    MessageBox.Show("El empleado dejo de pertenecer al area.");
                }
            }

            Actualizar();
            
        }

        private void btnHacerResponsable_Click(object sender, EventArgs e)
        {
            BEUsuario usuario = (BEUsuario)dgvEmpleados.SelectedRows[0].DataBoundItem;
            BEArea area = (BEArea)cmbAreas.SelectedItem;
            if (usuario.Area == null || usuario.Area.Nombre == area.Nombre)
            {
                bllusuario.HacerResponsable(usuario, area);
                MessageBox.Show("Se asigno responsable del area.");
            }
            else
            {
                MessageBox.Show("El empleado ya tiene un area asignada");
            }
            Actualizar();
        }
    }
}
