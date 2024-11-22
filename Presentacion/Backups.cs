using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Interfaces;
using Servicios;

namespace Presentacion
{
    public partial class Backups : Form, IObserver
    {
        public Backups()
        {
            InitializeComponent();
            Sesion.getinstace().AgregarObservador(this);
            backups = new BLLBackups();
        }
        public Backups(BEIdioma idioma)
        {
            InitializeComponent();
            Sesion.getinstace().AgregarObservador(this);
            backups = new BLLBackups();
            Update(idioma.ID);
        }
        BLLRepositorioIdioma bllidioma;
        BLLBackups backups;
        private void btnGuardarBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione la carpeta donde desea guardar el backup";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = System.IO.Path.Combine(folderDialog.SelectedPath, "BackupBD.bak");

                    try
                    {
                        backups.CrearBackup(ruta);
                        MessageBox.Show($"Backup guardado exitosamente en: {ruta}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el backup: {ex.Message}");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                openFileDialog.Title = "Seleccione el archivo de respaldo para restaurar";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openFileDialog.FileName;

                    try
                    {
                        if (backups.RestoreBackup(ruta))
                        {
                            MessageBox.Show("Base de datos restaurada exitosamente.");
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo hacer el restore");
                        }
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al restaurar la base de datos: {ex.Message}");
                    }

                }
            }
        }

        private void Backups_Load(object sender, EventArgs e)
        {
            button1.Hide();
        }

        //private void CargarBackupsEnListBox(string carpeta)
        //{
        //    lstBoxBackups.Items.Clear();

        //    if (Directory.Exists(carpeta))
        //    {
        //        string[] archivos = Directory.GetFiles(carpeta, "*.bak");

        //        foreach (string archivo in archivos)
        //        {
        //            lstBoxBackups.Items.Add(Path.GetFileName(archivo)); // Muestra solo el nombre del archivo
        //        }

        //        if (archivos.Length == 0)
        //        {
        //            MessageBox.Show("No se encontraron archivos de respaldo en la carpeta seleccionada.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("La carpeta especificada no existe.");
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione la carpeta que contiene los archivos de respaldo";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string carpetaSeleccionada = folderDialog.SelectedPath;
                    //CargarBackupsEnListBox(carpetaSeleccionada);
                }
            }
        }

        public void Update(int a)
        {
            bllidioma = new BLLRepositorioIdioma();
            foreach (Control c in this.Controls)
            {
                if (c.Tag != null)
                {
                    BEIdioma idioma = new BEIdioma();
                    idioma.ID = a;
                    foreach (BETraduccion traduccion in bllidioma.ListarTraducciones(idioma))
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
