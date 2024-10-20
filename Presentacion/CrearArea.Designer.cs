namespace Presentacion
{
    partial class CrearArea
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
            this.txtNombreArea = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblNombreArea = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Location = new System.Drawing.Point(142, 41);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(118, 20);
            this.txtNombreArea.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblNombreArea
            // 
            this.lblNombreArea.AutoSize = true;
            this.lblNombreArea.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArea.Location = new System.Drawing.Point(12, 41);
            this.lblNombreArea.Name = "lblNombreArea";
            this.lblNombreArea.Size = new System.Drawing.Size(109, 23);
            this.lblNombreArea.TabIndex = 2;
            this.lblNombreArea.Text = "Nombre Area";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(142, 114);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(118, 21);
            this.cmbResponsable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Responsable";
            // 
            // btnCrearArea
            // 
            this.btnCrearArea.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArea.Location = new System.Drawing.Point(142, 157);
            this.btnCrearArea.Name = "btnCrearArea";
            this.btnCrearArea.Size = new System.Drawing.Size(118, 23);
            this.btnCrearArea.TabIndex = 5;
            this.btnCrearArea.Text = "Crear Area";
            this.btnCrearArea.UseVisualStyleBackColor = true;
            this.btnCrearArea.Click += new System.EventHandler(this.btnCrearArea_Click);
            // 
            // CrearArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(341, 192);
            this.Controls.Add(this.btnCrearArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.lblNombreArea);
            this.Controls.Add(this.txtNombreArea);
            this.Name = "CrearArea";
            this.Text = "CrearArea";
            this.Load += new System.EventHandler(this.CrearArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreArea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblNombreArea;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearArea;
    }
}