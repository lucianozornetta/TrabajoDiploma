namespace Presentacion
{
    partial class MDITicketera
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaOrdenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenDeTrabajoToolStripMenuItem,
            this.verTicketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nuevaOrdenDeTrabajoToolStripMenuItem
            // 
            this.nuevaOrdenDeTrabajoToolStripMenuItem.Name = "nuevaOrdenDeTrabajoToolStripMenuItem";
            this.nuevaOrdenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.nuevaOrdenDeTrabajoToolStripMenuItem.Tag = "MDITicketeraNuevaWO";
            this.nuevaOrdenDeTrabajoToolStripMenuItem.Text = "Nueva Orden De Trabajo";
            this.nuevaOrdenDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenDeTrabajoToolStripMenuItem_Click);
            // 
            // verTicketsToolStripMenuItem
            // 
            this.verTicketsToolStripMenuItem.Name = "verTicketsToolStripMenuItem";
            this.verTicketsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.verTicketsToolStripMenuItem.Tag = "MDITicketeraVerTickets";
            this.verTicketsToolStripMenuItem.Text = "Ver Tickets";
            this.verTicketsToolStripMenuItem.Click += new System.EventHandler(this.verTicketsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MDITicketera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 558);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDITicketera";
            this.Text = "MDITicketera";
            this.Load += new System.EventHandler(this.MDITicketera_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verTicketsToolStripMenuItem;
    }
}