namespace Presentacion
{
    partial class Areas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEmpleadosAAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAreaToolStripMenuItem,
            this.asignarEmpleadosAAreaToolStripMenuItem,
            this.listadoAreasToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearAreaToolStripMenuItem
            // 
            this.crearAreaToolStripMenuItem.Name = "crearAreaToolStripMenuItem";
            this.crearAreaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.crearAreaToolStripMenuItem.Text = "Crear Area";
            this.crearAreaToolStripMenuItem.Click += new System.EventHandler(this.crearAreaToolStripMenuItem_Click);
            // 
            // asignarEmpleadosAAreaToolStripMenuItem
            // 
            this.asignarEmpleadosAAreaToolStripMenuItem.Name = "asignarEmpleadosAAreaToolStripMenuItem";
            this.asignarEmpleadosAAreaToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.asignarEmpleadosAAreaToolStripMenuItem.Text = "Asignar Empleados A Area";
            this.asignarEmpleadosAAreaToolStripMenuItem.Click += new System.EventHandler(this.asignarEmpleadosAAreaToolStripMenuItem_Click);
            // 
            // listadoAreasToolStripMenuItem
            // 
            this.listadoAreasToolStripMenuItem.Name = "listadoAreasToolStripMenuItem";
            this.listadoAreasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.listadoAreasToolStripMenuItem.Text = "Listado Areas";
            this.listadoAreasToolStripMenuItem.Click += new System.EventHandler(this.listadoAreasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Areas";
            this.Text = "Areas";
            this.Load += new System.EventHandler(this.Areas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarEmpleadosAAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
    }
}