﻿using System;
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
using Interfaces;

namespace Presentacion
{
    public partial class AsignarEmpleadoArea : Form,IObserver
    {
        public AsignarEmpleadoArea()
        {
            InitializeComponent();
            bllarea = new BLLArea();
            bllusuario = new BLLUsuario();
            btnHacerResponsable.Hide();
            ActivarControles();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        public AsignarEmpleadoArea(BEIdioma idioma)
        {
            InitializeComponent();
            bllarea = new BLLArea();
            bllusuario = new BLLUsuario();
            btnHacerResponsable.Hide();
            ActivarControles();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
        }
        BLLArea bllarea;
        BLLUsuario bllusuario;
        BLLRepositorioIdioma bllrepositorio;

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ActivarControles()
        {
            if (Sesion.ObtenerUsername().Permiso != null)
            {
                Recursiva(Sesion.ObtenerUsername().Permiso);
            }
            else
            {
                MessageBox.Show("Su usuario no tiene permisos asignados");

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
                    if (perm.ID == 64)
                    {
                        btnHacerResponsable.Show();
                    }
                   

                }
            }
        }

        void CargarGrilla()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = bllusuario.ListarUsuarios();
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvEmpleados.ReadOnly = true;

        }
        void CargarCMB()
        {
            cmbAreas.DataSource = null;
            cmbAreas.DataSource = bllarea.ListarAreas();
            cmbAreas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void Actualizar()
        {
            CargarGrilla();
            CargarCMB();
        }
        private void AsignarEmpleadoArea_Load(object sender, EventArgs e)
        {
            Sesion.getinstace().AgregarObservador(this);
            Actualizar();
            label1.Show();
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
        private void btnAsignarArea_Click(object sender, EventArgs e)
        {
            BEUsuario usuario = (BEUsuario)dgvEmpleados.SelectedRows[0].DataBoundItem;
            BEArea area = (BEArea)cmbAreas.SelectedItem;
            if (usuario.Area == null)
            {
                bllusuario.AsignarAreaUsuario(usuario, area);
                bllusuario.AsignarPermisoAUsuario(new BEPermisoCompuesto(76), usuario);
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
                if(bllusuario.VerificarEmpleadoLibre(usuario))
                {
                    if (usuario.Usuario == usuario.Area.Responsable.Usuario)
                    {
                        MessageBox.Show("No puede remover el area dado que es el responsable de la misma");
                    }
                    else
                    {
                        bllusuario.RemoverDeArea(usuario);
                        MessageBox.Show("El empleado dejo de pertenecer al area.");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede cambiar de area un empleado con Ordenes de Trabajo asignadas");
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
                bllusuario.AsignarPermisoAUsuario(new BEPermisoCompuesto(75), usuario);
                MessageBox.Show("Se asigno responsable del area.");
            }
            else
            {
                MessageBox.Show("El empleado ya tiene un area asignada");
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
