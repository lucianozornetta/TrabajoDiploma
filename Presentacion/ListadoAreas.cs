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
using BE;
using Servicios;
using Interfaces;
using System.Text.Json;
using System.Collections;
using System.IO;



namespace Presentacion
{
    public partial class ListadoAreas : Form
    {
        public ListadoAreas()
        {
            InitializeComponent();
            bllarea = new BLLArea();
            bLLUsuario = new BLLUsuario();
            blltag = new BLLTag();
        }
        CrearTag creartag;
        BLLArea bllarea;
        BLLUsuario bLLUsuario;
        BLLTag blltag;
        private void ListadoAreas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ActualizarCMB();
        }
        void CargarGrilla()
        {
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = bllarea.ListarAreas();
            dgvAreas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAreas.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvAreas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvAreas.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BEArea area = (BEArea)dgvAreas.SelectedRows[0].DataBoundItem;
                //bllarea.ListarEmpleados(area);

                var datosFiltrados = area.EmpleadosDelArea.Select(u => new
                {
                    u.Usuario,
                    u.Contraseña,
                    u.Permiso,
                    u.DVH
                }).ToList();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = datosFiltrados;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmpleados.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvEmpleados.ReadOnly = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Area seleccionada no valida");
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void ActualizarCMB() 
        {
            cmbTags.DataSource = null;
            cmbTags.DataSource = blltag.ListarTags();
            cmbTags.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnCrearTag_Click(object sender, EventArgs e)
        {
            if (creartag == null)
            {
                creartag = new CrearTag();
                creartag.FormClosed += (s, args) => this.ActualizarCMB();
                creartag.FormClosed += new FormClosedEventHandler(CerrarCrearTag);
                creartag.Show();
            }
            else
            {
                creartag.Activate();
            }
            

        }
        void CerrarCrearTag(object sender, FormClosedEventArgs e)
        {
            creartag = null;
        }
        void ActualizarListBox()
        {

        }
        private void btnAsignarTag_Click(object sender, EventArgs e)
        {
            BETag tag = (BETag)cmbTags.SelectedItem;
            BEUsuario usuario = new BEUsuario(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                 if(bLLUsuario.AsignarTag(usuario, tag))
                 {
                    MessageBox.Show("Se asigno el tag correctamente");
                 }
                else
                {
                    MessageBox.Show("El empleado ya posee ese Tag.");
                }
                 
            }
            catch(Exception ex)
            {

                MessageBox.Show("ERROR 404");
            }
           
            
        }

        private void btnListarTagsEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = new BEUsuario(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());

                listBox1.DataSource = null;
                listBox1.DataSource = blltag.DevolverTagsDeUsuario(usuario);
            }
            catch (Exception)
            {

                MessageBox.Show("Empleado seleccionado no valido");
            }
           

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<BETag> ListaTags = blltag.ListarTags();
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos JSON (*.json)|*.json"; 
                    saveFileDialog.Title = "Guardar archivo JSON";
                    saveFileDialog.FileName = "archivo.json"; 

                   
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivo = saveFileDialog.FileName;

                       
                        string json = JsonSerializer.Serialize(ListaTags, new JsonSerializerOptions
                        {
                            WriteIndented = true 
                        });
                        File.WriteAllText(rutaArchivo, json);

                        MessageBox.Show("Archivo JSON exportado con éxito en: " + rutaArchivo, "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar el archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos JSON (*.json)|*.json"; 
                    openFileDialog.Title = "Seleccionar archivo JSON";


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivo = openFileDialog.FileName;


                        string contenidoJson = File.ReadAllText(rutaArchivo);

                        List<BETag> lista = JsonSerializer.Deserialize<List<BETag>>(contenidoJson);
                        blltag.ImportarListaTags(lista);
                        MessageBox.Show("Archivo JSON importado con éxito.", "Importación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarCMB();
                        ActualizarListBox();
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al importar el archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
    
}
