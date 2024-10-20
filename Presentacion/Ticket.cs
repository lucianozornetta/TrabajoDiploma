using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        BEOrdenDeTrabajo orden;
        BLLArea bllarea;
        BLLUsuario bllusuario;
        bool Usuarios = false;
        bool Areas = false;
        bool Estados = false;


        void BloquearControlesCliente()
        {
            
        }
        public Ticket(BEOrdenDeTrabajo WO)
        {
            InitializeComponent();
            orden = WO;
            bllarea = new BLLArea();
            bllorden = new BLLOrdenDeTrabajo();
            bllusuario = new BLLUsuario();
            BEArea areasesion = bllusuario.BuscarArea(Sesion.ObtenerUsername());
            if (areasesion.ID != WO.area.ID)
            {
                txtCliente.Enabled = false;
                txtResumen.Enabled = false;
                RtxtNotas.Enabled = false;
                cmbArea.Enabled = false;
                cmbUsuarioAsignado.Enabled = false;
                txtFechaLimite.Enabled = false;
                cmbEstado.Enabled = false;
                RtxtboxResolucion.Enabled = false;
                RtxtDetalles.Enabled = false;
                btnAgregarNota.Enabled = false;
                btnSubirArchivo.Enabled = false;
                
            }
        }

        void Actualizar()
        {
            Usuarios = false;
            Areas = false;
            Estados = false;
            txtNumero.Text = orden.Numero.ToString();
            txtCliente.Text = orden.Cliente.Usuario;
            txtResumen.Text = orden.Resumen.ToString();
            RtxtNotas.Text = orden.Notas.ToString();
            cmbEstado.SelectedIndex = -1;
            CMBEstados();
            txtFechaLimite.Text = orden.FechaLimite.ToString();
            cargarCMBAreas();
            cargarCMBUsuarios();
            CargarGrilla();
            if (orden is BEOrdenTrabajoBaja)
            {
                txtCriticidad.Text = "Baja";
            }
            if (orden is BEOrdenTrabajoModerado)
            {
                txtCriticidad.Text = "Media";
            }
            if (orden is BEOrdenTrabajoCritico)
            {
                txtCriticidad.Text = "Critica";

            }
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            txtNumero.Text = orden.Numero.ToString();
            txtCliente.Text = orden.Cliente.Usuario;
            txtResumen.Text = orden.Resumen.ToString();
            RtxtNotas.Text = orden.Notas.ToString();
            cmbEstado.SelectedIndex = -1;
            CMBEstados();
            txtFechaLimite.Text = orden.FechaLimite.ToString();
            cargarCMBAreas();
            cargarCMBUsuarios();
            CargarGrilla();
            if (orden is BEOrdenTrabajoBaja)
            {
                txtCriticidad.Text = "Baja";
            }
            if (orden is BEOrdenTrabajoModerado)
            {
                txtCriticidad.Text = "Media";
            }
            if (orden is BEOrdenTrabajoCritico)
            {
                txtCriticidad.Text = "Critica";
            }

        }

        void CargarGrilla()
        {
            dgvDetalleWO.DataSource = null;
            orden.DetallesWO.Clear();
            dgvDetalleWO.DataSource = bllorden.ListarDetallesWO(orden);
            dgvDetalleWO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleWO.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvDetalleWO.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvDetalleWO.ReadOnly = true;
            dgvDetalleWO.ClearSelection();
            RtxtDetalles.Clear();
        }
        BLLOrdenDeTrabajo bllorden;
        void cargarCMBAreas()
        {
            cmbArea.DataSource = null;
            cmbArea.DataSource = bllarea.ListarAreas();
            foreach (BEArea area in cmbArea.Items)
            {
                if (area.Nombre == orden.area.Nombre)
                {
                    cmbArea.SelectedItem = area;
                    Areas = true;
                    break;
                }
            }

        }
        void cargarCMBUsuarios()
        {
            cmbUsuarioAsignado.DataSource = null;
            cmbUsuarioAsignado.DataSource = orden.area.EmpleadosDelArea;
            foreach (BEUsuario usuario in orden.area.EmpleadosDelArea)
            {
                if (orden.EmpleadoAsignado.Usuario == usuario.Usuario)
                {
                    cmbUsuarioAsignado.SelectedItem = usuario;
                    Usuarios = true;
                    break;

                }
                else
                {
                    cmbUsuarioAsignado.SelectedIndex = -1;
                }

            }
            Usuarios = true;
        }
        void CMBEstados()
        {
            foreach (string estado in cmbEstado.Items)
            {
                if (estado == orden.Estado)
                {
                    cmbEstado.SelectedItem = estado;
                }
            }
            Estados = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Areas)
            {
                orden.area = (BEArea)cmbArea.SelectedItem;
                bllorden.CambiarArea(orden);
                BEDetalleWO detalle = new BEDetalleWO();
                detalle.Detalle = "La orden de trabajo fue derivada al area " + orden.EmpleadoAsignado.Usuario;
                detalle.FechaDetalle = DateTime.Now;
                detalle.Usuario = Sesion.ObtenerUsername();
                bllorden.AgregarDetalle(detalle, orden);
                Actualizar();
            }

        }
        void PruebaGrilla()
        {
            dgvDetalleWO.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvDetalleWO.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvDetalleWO.ReadOnly = true;
            dgvDetalleWO.RowHeadersVisible = false;
            dgvDetalleWO.Columns.Add("RelationshipType", "Relationship Type");
            dgvDetalleWO.Columns.Add("RequestType", "Request Type");
            dgvDetalleWO.Columns.Add("RequestSummary", "Request Summary");
            dgvDetalleWO.Columns.Add("Status", "Status");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Rows.Add("Duplicate of", "Incident", "INC911: Association added by SAP end user", "Assigned");
            dgvDetalleWO.Columns[0].Width = 150;
            dgvDetalleWO.Columns[1].Width = 100;
            dgvDetalleWO.Columns[2].Width = 300;
            dgvDetalleWO.Columns[3].Width = 100;
        }

        private void cmbUsuarioAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Usuarios)
            {
                orden.EmpleadoAsignado = (BEUsuario)cmbUsuarioAsignado.SelectedItem;
                bllorden.AsignarTicket(orden);


                BEDetalleWO detalle = new BEDetalleWO();
                detalle.Detalle = "La orden de trabajo fue asignada al empleado " + orden.EmpleadoAsignado.Usuario;
                detalle.FechaDetalle = DateTime.Now;
                detalle.Usuario = Sesion.ObtenerUsername();
                bllorden.AgregarDetalle(detalle, orden);
                Actualizar();

            }


        }
        void actualizar()
        {

        }

        private void btnAbrirResumen_Click(object sender, EventArgs e)
        {
            VerTexto texto = new VerTexto(txtResumen.Text);
            texto.Show();
            Actualizar();
        }

        private void btnAbrirNotas_Click(object sender, EventArgs e)
        {
            VerTexto texto = new VerTexto(RtxtNotas.Text);
            texto.Show();
            Actualizar();
        }

        private void dgvDetalleWO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEDetalleWO detalleWO = (BEDetalleWO)dgvDetalleWO.SelectedRows[0].DataBoundItem;
            RtxtDetalles.Text = detalleWO.Detalle;

        }

        private void dgvDetalleWO_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                BEDetalleWO detalleWO = (BEDetalleWO)dgvDetalleWO.SelectedRows[0].DataBoundItem;
                RtxtDetalles.Text = detalleWO.Detalle;
            }
            catch (Exception)
            {


            }

        }

        private void btnAbrirNota_Click(object sender, EventArgs e)
        {
            VerTexto texto = new VerTexto(RtxtDetalles.Text);
            texto.Show();
            Actualizar();
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            BEDetalleWO detalle = new BEDetalleWO();
            detalle.Detalle = RtxtDetalles.Text;
            detalle.FechaDetalle = DateTime.Now;
            detalle.Usuario = Sesion.ObtenerUsername();
            bllorden.AgregarDetalle(detalle, orden);
            CargarGrilla();
            Actualizar();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Estados)
            {
                if ((string)cmbEstado.SelectedItem != "Cerrado")
                {
                    orden.Estado = (string)cmbEstado.SelectedItem;
                    bllorden.CambiarEstado(orden);
                    Actualizar();
                }
                else
                {
                    if(RtxtboxResolucion.Text != "" && RtxtboxResolucion.Text != null)
                    {
                        if(TieneArchivo())
                        {
                            orden.Resolucion = RtxtboxResolucion.Text;
                        }
                        else
                        {
                            MessageBox.Show("Para poder cerrar una orden de trabajo tiene que haber al menos un archivo subido a modo de postcheck");
                        }
                        
                    }
                    if (orden.Resolucion != null && orden.Resolucion != "")
                    {
                        orden.Estado = (string)cmbEstado.SelectedItem;
                        bllorden.CerrarOrden(orden);
                        Actualizar();
                        MessageBox.Show("Esta orden de trabajo se ha cerrado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No puede cerrar la orden de trabajo sin una resolucion");
                        Actualizar();
                    }
                }

            }
        }

        bool TieneArchivo()
        {
            if (orden.DetallesWO.Count > 0)
            {
                foreach(BEDetalleWO detalle in orden.DetallesWO)
                {
                    if(detalle.TieneArchivo)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Archivo archivo = new Archivo();
                string filePath = openFileDialog.FileName;
                archivo.Nombre  = Path.GetFileName(filePath);
                archivo.Extension = Path.GetExtension(filePath);
                archivo.DatosArchivo  = File.ReadAllBytes(filePath);
                BEDetalleWO detalle = new BEDetalleWO();
                detalle.Usuario = Sesion.ObtenerUsername();
                detalle.Detalle = "Subida de archivo";
                detalle.FechaDetalle = DateTime.Now;
                detalle.TieneArchivo = true;
                archivo.detalle = detalle;

                bllorden.SubirArchivo(archivo, orden);
                MessageBox.Show("Archivo subido con éxito.");
                Actualizar();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BEDetalleWO detalleWO = (BEDetalleWO)dgvDetalleWO.SelectedRows[0].DataBoundItem;
            if(detalleWO.TieneArchivo)
            {
                Archivo archivo = bllorden.DescargarArchivo(detalleWO);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = archivo.Nombre;
                saveFileDialog.Filter = "Archivos (*" + archivo.Extension + ")|*" + archivo.Extension;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, archivo.DatosArchivo);
                    MessageBox.Show("Archivo descargado con éxito.");
                }
            }
        }
    }
}
