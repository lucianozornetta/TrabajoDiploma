namespace Presentacion
{
    partial class CrearOrdenTrabajo
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
            this.RtxtNotasWO = new System.Windows.Forms.RichTextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtResumenWO = new System.Windows.Forms.TextBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.cmbAreaWO = new System.Windows.Forms.ComboBox();
            this.lblAreaWO = new System.Windows.Forms.Label();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.cmbImpacto = new System.Windows.Forms.ComboBox();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            this.lblImpacto = new System.Windows.Forms.Label();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RtxtNotasWO
            // 
            this.RtxtNotasWO.Location = new System.Drawing.Point(161, 104);
            this.RtxtNotasWO.Name = "RtxtNotasWO";
            this.RtxtNotasWO.Size = new System.Drawing.Size(315, 237);
            this.RtxtNotasWO.TabIndex = 2;
            this.RtxtNotasWO.Text = "";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(102, 100);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(53, 23);
            this.lblNotas.TabIndex = 3;
            this.lblNotas.Text = "Notas";
            // 
            // txtResumenWO
            // 
            this.txtResumenWO.Location = new System.Drawing.Point(161, 58);
            this.txtResumenWO.Name = "txtResumenWO";
            this.txtResumenWO.Size = new System.Drawing.Size(294, 20);
            this.txtResumenWO.TabIndex = 4;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(87, 58);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(71, 23);
            this.lblResumen.TabIndex = 5;
            this.lblResumen.Text = "Resumen";
            // 
            // cmbAreaWO
            // 
            this.cmbAreaWO.FormattingEnabled = true;
            this.cmbAreaWO.Location = new System.Drawing.Point(161, 391);
            this.cmbAreaWO.Name = "cmbAreaWO";
            this.cmbAreaWO.Size = new System.Drawing.Size(315, 21);
            this.cmbAreaWO.TabIndex = 6;
            // 
            // lblAreaWO
            // 
            this.lblAreaWO.AutoSize = true;
            this.lblAreaWO.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaWO.Location = new System.Drawing.Point(102, 391);
            this.lblAreaWO.Name = "lblAreaWO";
            this.lblAreaWO.Size = new System.Drawing.Size(46, 23);
            this.lblAreaWO.TabIndex = 7;
            this.lblAreaWO.Text = "Area";
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(161, 446);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(315, 21);
            this.cmbTags.TabIndex = 8;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(49, 446);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(109, 23);
            this.lblTags.TabIndex = 9;
            this.lblTags.Text = "Agregar Tags";
            // 
            // cmbImpacto
            // 
            this.cmbImpacto.FormattingEnabled = true;
            this.cmbImpacto.Items.AddRange(new object[] {
            "Menor",
            "Moderado",
            "Extenso"});
            this.cmbImpacto.Location = new System.Drawing.Point(707, 74);
            this.cmbImpacto.Name = "cmbImpacto";
            this.cmbImpacto.Size = new System.Drawing.Size(144, 21);
            this.cmbImpacto.TabIndex = 10;
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cmbUrgencia.Location = new System.Drawing.Point(707, 132);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(144, 21);
            this.cmbUrgencia.TabIndex = 11;
            // 
            // lblImpacto
            // 
            this.lblImpacto.AutoSize = true;
            this.lblImpacto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpacto.Location = new System.Drawing.Point(620, 72);
            this.lblImpacto.Name = "lblImpacto";
            this.lblImpacto.Size = new System.Drawing.Size(70, 23);
            this.lblImpacto.TabIndex = 12;
            this.lblImpacto.Text = "Impacto";
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencia.Location = new System.Drawing.Point(620, 132);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(75, 23);
            this.lblUrgencia.TabIndex = 13;
            this.lblUrgencia.Text = "Urgencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "NUEVA ORDEN DE TRABAJO";
            // 
            // CrearOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUrgencia);
            this.Controls.Add(this.lblImpacto);
            this.Controls.Add(this.cmbUrgencia);
            this.Controls.Add(this.cmbImpacto);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.lblAreaWO);
            this.Controls.Add(this.cmbAreaWO);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.txtResumenWO);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.RtxtNotasWO);
            this.Name = "CrearOrdenTrabajo";
            this.Text = "CrearOrdenTrabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox RtxtNotasWO;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtResumenWO;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.ComboBox cmbAreaWO;
        private System.Windows.Forms.Label lblAreaWO;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.ComboBox cmbImpacto;
        private System.Windows.Forms.ComboBox cmbUrgencia;
        private System.Windows.Forms.Label lblImpacto;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.Label label1;
    }
}