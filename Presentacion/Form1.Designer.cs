namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.crearAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.verBitacoraToolStripMenuItem,
            this.gestionPermisosToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem,
            this.gestionarIdiomasToolStripMenuItem,
            this.alteradosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.crearAreaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.registroToolStripMenuItem.Tag = "btnManejoDeUsuarios";
            this.registroToolStripMenuItem.Text = "Manejo de usuarios";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // verBitacoraToolStripMenuItem
            // 
            this.verBitacoraToolStripMenuItem.Name = "verBitacoraToolStripMenuItem";
            this.verBitacoraToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.verBitacoraToolStripMenuItem.Tag = "btnVerBitacora";
            this.verBitacoraToolStripMenuItem.Text = "Ver Bitacora";
            this.verBitacoraToolStripMenuItem.Click += new System.EventHandler(this.verBitacoraToolStripMenuItem_Click_1);
            // 
            // gestionPermisosToolStripMenuItem
            // 
            this.gestionPermisosToolStripMenuItem.Name = "gestionPermisosToolStripMenuItem";
            this.gestionPermisosToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.gestionPermisosToolStripMenuItem.Tag = "btnGestionPermisos";
            this.gestionPermisosToolStripMenuItem.Text = "Gestion Permisos";
            this.gestionPermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionPermisosToolStripMenuItem_Click);
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.asignarPermisosToolStripMenuItem.Tag = "btnAsignarPermisos";
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            this.asignarPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosToolStripMenuItem_Click);
            // 
            // gestionarIdiomasToolStripMenuItem
            // 
            this.gestionarIdiomasToolStripMenuItem.Name = "gestionarIdiomasToolStripMenuItem";
            this.gestionarIdiomasToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gestionarIdiomasToolStripMenuItem.Tag = "btnGestionarIdiomas";
            this.gestionarIdiomasToolStripMenuItem.Text = "GestionarIdiomas";
            this.gestionarIdiomasToolStripMenuItem.Click += new System.EventHandler(this.gestionarIdiomasToolStripMenuItem_Click);
            // 
            // alteradosToolStripMenuItem
            // 
            this.alteradosToolStripMenuItem.Name = "alteradosToolStripMenuItem";
            this.alteradosToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.alteradosToolStripMenuItem.Tag = "btnUsuariosalteradosfrom1";
            this.alteradosToolStripMenuItem.Text = "UsuariosAlterados";
            this.alteradosToolStripMenuItem.Click += new System.EventHandler(this.alteradosToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.cerrarSesionToolStripMenuItem.Tag = "btnCerrarSesion";
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1059, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // crearAreaToolStripMenuItem
            // 
            this.crearAreaToolStripMenuItem.Name = "crearAreaToolStripMenuItem";
            this.crearAreaToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.crearAreaToolStripMenuItem.Text = "Crear Area";
            this.crearAreaToolStripMenuItem.Click += new System.EventHandler(this.crearAreaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 292);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verBitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarIdiomasToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem alteradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAreaToolStripMenuItem;
    }
}

