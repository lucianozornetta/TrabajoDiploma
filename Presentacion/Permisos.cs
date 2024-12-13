using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Servicios;
using Interfaces;

namespace Presentacion
{
    public partial class Permisos : Form , IObserver
    {
        BEPermisoCompuesto permisocompuesto;
        BLLRepositorioIdioma bllrepositorio;
        public Permisos()
        {
            InitializeComponent();
            bllrepositorio = new BLLRepositorioIdioma();
        }
        BLLPermiso bLLPermiso;
        public Permisos(BEIdioma idioma)
        {
            InitializeComponent();
            bllrepositorio = new BLLRepositorioIdioma();
            Update(idioma.ID);
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
        private void Permisos_Load(object sender, EventArgs e)
        {
            bLLPermiso = new BLLPermiso();
            Sesion.getinstace().AgregarObservador(this);
            Actualizar();
            btnAsignarPermiso.Hide();
            btnCrearPermiso.Hide();
            btnEliminarPermiso.Hide();
            btnReasignar.Hide();
            cmbEliminarPermiso.Hide();
            comboBox1.Hide();
            textBox1.Hide();
            label1.Hide();
            ActivarControles();
            cmbEliminarPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        void ActivarControles()
        {
            if (Sesion.ObtenerUsername().Permiso != null)
            {
                Recursiva(Sesion.ObtenerUsername().Permiso);
            }
            else
            {
               

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
                    if (perm.ID == 7)
                    {
                        btnCrearPermiso.Show();
                        comboBox1.Show();
                        textBox1.Show();
                        btnAsignarPermiso.Show();
                        btnReasignar.Show();
                        label1.Show();
                        
                    }
                    if (perm.ID == 8)
                    {
                        cmbEliminarPermiso.Show();
                        btnEliminarPermiso.Show();
                    }

                }
            }
        }
        private void CargarTreeView(List<BEPermiso> permisos)
        {
            treeView1.Nodes.Clear();

            
            Dictionary<int, TreeNode> nodoDict = new Dictionary<int, TreeNode>();

            
            foreach (var permiso in permisos)
            {
                var nodo = new TreeNode(permiso.Nombre)
                {
                    Tag = permiso
                };
                nodoDict[permiso.ID] = nodo;
            }

            
            foreach (var permiso in permisos)
            {
                if (permiso.EsPadre)
                {
                    var permisoCompuesto = permiso as BEPermisoCompuesto;
                    var nodoPadre = nodoDict[permiso.ID];

                    foreach (var hijo in permisoCompuesto.PermisosHijos)
                    {
                        var nodoHijo = nodoDict[hijo.ID].Clone() as TreeNode;

                       
                        nodoPadre.Nodes.Add(nodoHijo);
                    }

                    
                    if (nodoPadre.Parent == null)
                    {
                        treeView1.Nodes.Add(nodoPadre);
                    }
                }
                else
                {
                    var nodoHijo = nodoDict[permiso.ID];

                   
                    if (nodoHijo.Parent == null)
                    {
                        treeView1.Nodes.Add(nodoHijo);
                    }
                }
            }

            treeView1.ExpandAll();
        }

        private void btnCrearPermiso_Click(object sender, EventArgs e)
        {
            bLLPermiso.AgregarPermiso(permisocompuesto);
            CargarTreeView(bLLPermiso.ListarPermisos());
            LimparAsignacion();
            Actualizar();

        }
        void Actualizar()
        {
            List<BEPermiso> ListaPermisos = bLLPermiso.ListarPermisos();
            comboBox1.DataSource = null;
            comboBox1.DataSource = ListaPermisos;
            cmbEliminarPermiso.DataSource = null;
            cmbEliminarPermiso.DataSource = ListaPermisos;
            CargarTreeView(ListaPermisos);
        }
        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {

            try               
            {
                BEPermiso p = (BEPermiso)comboBox1.SelectedItem;
                if (permisocompuesto == null)
                {
                    permisocompuesto = new BEPermisoCompuesto();
                    permisocompuesto.Nombre = textBox1.Text;
                    textBox1.Enabled = false;
                    
                }
                if(bLLPermiso.VerificarNombrePermiso(permisocompuesto) && bLLPermiso.VerificarRepeticion(permisocompuesto , p))
                {
                    permisocompuesto.AgregarHijo(p);
                    MessageBox.Show("Permiso Asignado Correctamente");
                }
                else
                {
                    MessageBox.Show("Nombre de Permiso no disponible o Permiso ya asignado");
                    
                }

            }
            catch (Exception)
            {

     
            }
            Actualizar();
        }
        void LimparAsignacion()
        {
            permisocompuesto = null;
            textBox1.Enabled = true;

        }
        private void btnReasignar_Click(object sender, EventArgs e)
        {
            LimparAsignacion();
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            BEPermiso permiso = (BEPermiso) cmbEliminarPermiso.SelectedItem;
            if(!bLLPermiso.SePuedeEliminar(permiso.ID))
            {
                if(permiso.EsPadre == true)
                {
                    if(permiso.ID != 58)
                    {
                        if (bLLPermiso.EliminarPermiso(permiso))
                        {
                            MessageBox.Show("Permiso Eliminado Correctamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar el permiso Admin");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se puede eliminar permisos base del sistema");
                }

            }
            else
            {
                MessageBox.Show("No puede eliminar el permiso porque esta siendo utilizado por otros permisos o un usuario lo tiene asignado");
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
