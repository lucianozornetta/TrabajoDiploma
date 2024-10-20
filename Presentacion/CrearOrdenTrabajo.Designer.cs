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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListTags = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Criticidad = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RtxtNotasWO
            // 
            this.RtxtNotasWO.Location = new System.Drawing.Point(161, 182);
            this.RtxtNotasWO.Name = "RtxtNotasWO";
            this.RtxtNotasWO.Size = new System.Drawing.Size(315, 237);
            this.RtxtNotasWO.TabIndex = 2;
            this.RtxtNotasWO.Text = "";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNotas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(102, 178);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(53, 23);
            this.lblNotas.TabIndex = 3;
            this.lblNotas.Text = "Notas";
            // 
            // txtResumenWO
            // 
            this.txtResumenWO.Location = new System.Drawing.Point(161, 132);
            this.txtResumenWO.Name = "txtResumenWO";
            this.txtResumenWO.Size = new System.Drawing.Size(315, 20);
            this.txtResumenWO.TabIndex = 4;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblResumen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(84, 128);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(71, 23);
            this.lblResumen.TabIndex = 5;
            this.lblResumen.Text = "Resumen";
            // 
            // cmbAreaWO
            // 
            this.cmbAreaWO.FormattingEnabled = true;
            this.cmbAreaWO.Location = new System.Drawing.Point(161, 455);
            this.cmbAreaWO.Name = "cmbAreaWO";
            this.cmbAreaWO.Size = new System.Drawing.Size(315, 21);
            this.cmbAreaWO.TabIndex = 6;
            // 
            // lblAreaWO
            // 
            this.lblAreaWO.AutoSize = true;
            this.lblAreaWO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAreaWO.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaWO.Location = new System.Drawing.Point(102, 451);
            this.lblAreaWO.Name = "lblAreaWO";
            this.lblAreaWO.Size = new System.Drawing.Size(46, 23);
            this.lblAreaWO.TabIndex = 7;
            this.lblAreaWO.Text = "Area";
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(518, 562);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(315, 21);
            this.cmbTags.TabIndex = 8;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTags.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(46, 498);
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
            this.cmbImpacto.Location = new System.Drawing.Point(124, 74);
            this.cmbImpacto.Name = "cmbImpacto";
            this.cmbImpacto.Size = new System.Drawing.Size(196, 21);
            this.cmbImpacto.TabIndex = 10;
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cmbUrgencia.Location = new System.Drawing.Point(124, 124);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(196, 21);
            this.cmbUrgencia.TabIndex = 11;
            // 
            // lblImpacto
            // 
            this.lblImpacto.AutoSize = true;
            this.lblImpacto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpacto.Location = new System.Drawing.Point(9, 70);
            this.lblImpacto.Name = "lblImpacto";
            this.lblImpacto.Size = new System.Drawing.Size(70, 23);
            this.lblImpacto.TabIndex = 12;
            this.lblImpacto.Text = "Impacto";
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUrgencia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencia.Location = new System.Drawing.Point(9, 122);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(75, 23);
            this.lblUrgencia.TabIndex = 13;
            this.lblUrgencia.Text = "Urgencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "NUEVA ORDEN DE TRABAJO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear Orden de Trabajo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(161, 76);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(315, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Numero";
            // 
            // ListTags
            // 
            this.ListTags.FormattingEnabled = true;
            this.ListTags.Location = new System.Drawing.Point(161, 498);
            this.ListTags.Name = "ListTags";
            this.ListTags.Size = new System.Drawing.Size(315, 199);
            this.ListTags.TabIndex = 18;
            this.ListTags.SelectedIndexChanged += new System.EventHandler(this.ListTags_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(42, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 668);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.Criticidad);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmbUrgencia);
            this.panel2.Controls.Add(this.cmbImpacto);
            this.panel2.Controls.Add(this.lblUrgencia);
            this.panel2.Controls.Add(this.lblImpacto);
            this.panel2.Location = new System.Drawing.Point(611, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 271);
            this.panel2.TabIndex = 30;
            // 
            // Criticidad
            // 
            this.Criticidad.AutoSize = true;
            this.Criticidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Criticidad.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criticidad.Location = new System.Drawing.Point(160, 11);
            this.Criticidad.Name = "Criticidad";
            this.Criticidad.Size = new System.Drawing.Size(112, 29);
            this.Criticidad.TabIndex = 31;
            this.Criticidad.Text = "Criticidad";
            // 
            // CrearOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 725);
            this.Controls.Add(this.ListTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.lblAreaWO);
            this.Controls.Add(this.cmbAreaWO);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.txtResumenWO);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.RtxtNotasWO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CrearOrdenTrabajo";
            this.Text = "CrearOrdenTrabajo";
            this.Load += new System.EventHandler(this.CrearOrdenTrabajo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ListTags;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Criticidad;
    }
}