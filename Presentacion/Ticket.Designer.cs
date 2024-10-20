namespace Presentacion
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetalleWO = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbUsuarioAsignado = new System.Windows.Forms.ComboBox();
            this.RtxtDetalles = new System.Windows.Forms.RichTextBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.btnAbrirNota = new System.Windows.Forms.Button();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAbrirResumen = new System.Windows.Forms.Button();
            this.btnAbrirNotas = new System.Windows.Forms.Button();
            this.RtxtNotas = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaLimite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCriticidad = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RtxtboxResolucion = new System.Windows.Forms.RichTextBox();
            this.Resolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleWO)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario Asignado";
            // 
            // dgvDetalleWO
            // 
            this.dgvDetalleWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleWO.Location = new System.Drawing.Point(638, 37);
            this.dgvDetalleWO.Name = "dgvDetalleWO";
            this.dgvDetalleWO.ReadOnly = true;
            this.dgvDetalleWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleWO.Size = new System.Drawing.Size(705, 337);
            this.dgvDetalleWO.TabIndex = 3;
            this.dgvDetalleWO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleWO_CellContentClick);
            this.dgvDetalleWO.SelectionChanged += new System.EventHandler(this.dgvDetalleWO_SelectionChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(220, 133);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(183, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(220, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(183, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(220, 382);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(183, 21);
            this.cmbArea.TabIndex = 7;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbUsuarioAsignado
            // 
            this.cmbUsuarioAsignado.FormattingEnabled = true;
            this.cmbUsuarioAsignado.Location = new System.Drawing.Point(220, 421);
            this.cmbUsuarioAsignado.Name = "cmbUsuarioAsignado";
            this.cmbUsuarioAsignado.Size = new System.Drawing.Size(183, 21);
            this.cmbUsuarioAsignado.TabIndex = 8;
            this.cmbUsuarioAsignado.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarioAsignado_SelectedIndexChanged);
            // 
            // RtxtDetalles
            // 
            this.RtxtDetalles.Location = new System.Drawing.Point(824, 380);
            this.RtxtDetalles.Name = "RtxtDetalles";
            this.RtxtDetalles.Size = new System.Drawing.Size(296, 197);
            this.RtxtDetalles.TabIndex = 9;
            this.RtxtDetalles.Text = "";
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNota.Location = new System.Drawing.Point(1126, 380);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(136, 41);
            this.btnAgregarNota.TabIndex = 10;
            this.btnAgregarNota.Text = "Agregar Detalle.";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // btnAbrirNota
            // 
            this.btnAbrirNota.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirNota.Location = new System.Drawing.Point(1126, 438);
            this.btnAbrirNota.Name = "btnAbrirNota";
            this.btnAbrirNota.Size = new System.Drawing.Size(136, 39);
            this.btnAbrirNota.TabIndex = 11;
            this.btnAbrirNota.Text = "Abrir Detalle";
            this.btnAbrirNota.UseVisualStyleBackColor = true;
            this.btnAbrirNota.Click += new System.EventHandler(this.btnAbrirNota_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArchivo.Location = new System.Drawing.Point(1126, 500);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(136, 39);
            this.btnSubirArchivo.TabIndex = 12;
            this.btnSubirArchivo.Text = "Subir Archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // txtResumen
            // 
            this.txtResumen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResumen.Location = new System.Drawing.Point(220, 171);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ReadOnly = true;
            this.txtResumen.Size = new System.Drawing.Size(183, 20);
            this.txtResumen.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Resumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Notas";
            // 
            // btnAbrirResumen
            // 
            this.btnAbrirResumen.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirResumen.Image")));
            this.btnAbrirResumen.Location = new System.Drawing.Point(426, 156);
            this.btnAbrirResumen.Name = "btnAbrirResumen";
            this.btnAbrirResumen.Size = new System.Drawing.Size(49, 48);
            this.btnAbrirResumen.TabIndex = 18;
            this.btnAbrirResumen.UseVisualStyleBackColor = true;
            this.btnAbrirResumen.Click += new System.EventHandler(this.btnAbrirResumen_Click);
            // 
            // btnAbrirNotas
            // 
            this.btnAbrirNotas.Image = global::Presentacion.Properties.Resources.detail_icon_215012;
            this.btnAbrirNotas.Location = new System.Drawing.Point(426, 210);
            this.btnAbrirNotas.Name = "btnAbrirNotas";
            this.btnAbrirNotas.Size = new System.Drawing.Size(49, 48);
            this.btnAbrirNotas.TabIndex = 19;
            this.btnAbrirNotas.UseVisualStyleBackColor = true;
            this.btnAbrirNotas.Click += new System.EventHandler(this.btnAbrirNotas_Click);
            // 
            // RtxtNotas
            // 
            this.RtxtNotas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RtxtNotas.Location = new System.Drawing.Point(220, 220);
            this.RtxtNotas.Name = "RtxtNotas";
            this.RtxtNotas.ReadOnly = true;
            this.RtxtNotas.Size = new System.Drawing.Size(183, 23);
            this.RtxtNotas.TabIndex = 20;
            this.RtxtNotas.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha Limite";
            // 
            // txtFechaLimite
            // 
            this.txtFechaLimite.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFechaLimite.Enabled = false;
            this.txtFechaLimite.Location = new System.Drawing.Point(220, 477);
            this.txtFechaLimite.Name = "txtFechaLimite";
            this.txtFechaLimite.Size = new System.Drawing.Size(191, 20);
            this.txtFechaLimite.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Criticidad";
            // 
            // txtCriticidad
            // 
            this.txtCriticidad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCriticidad.Enabled = false;
            this.txtCriticidad.Location = new System.Drawing.Point(220, 41);
            this.txtCriticidad.Name = "txtCriticidad";
            this.txtCriticidad.ReadOnly = true;
            this.txtCriticidad.Size = new System.Drawing.Size(183, 20);
            this.txtCriticidad.TabIndex = 24;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Estado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(67, 516);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(59, 23);
            this.Estado.TabIndex = 25;
            this.Estado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Sin Asignar",
            "Asignado",
            "En Curso",
            "Cerrado"});
            this.cmbEstado.Location = new System.Drawing.Point(220, 520);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(191, 21);
            this.cmbEstado.TabIndex = 26;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1126, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Descargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 271);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.Resolucion);
            this.panel2.Controls.Add(this.RtxtboxResolucion);
            this.panel2.Location = new System.Drawing.Point(46, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 310);
            this.panel2.TabIndex = 29;
            // 
            // RtxtboxResolucion
            // 
            this.RtxtboxResolucion.Location = new System.Drawing.Point(174, 238);
            this.RtxtboxResolucion.Name = "RtxtboxResolucion";
            this.RtxtboxResolucion.Size = new System.Drawing.Size(191, 45);
            this.RtxtboxResolucion.TabIndex = 30;
            this.RtxtboxResolucion.Text = "";
            // 
            // Resolucion
            // 
            this.Resolucion.AutoSize = true;
            this.Resolucion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Resolucion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolucion.Location = new System.Drawing.Point(24, 248);
            this.Resolucion.Name = "Resolucion";
            this.Resolucion.Size = new System.Drawing.Size(86, 23);
            this.Resolucion.TabIndex = 30;
            this.Resolucion.Text = "Resolucion";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1402, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.txtCriticidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFechaLimite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RtxtNotas);
            this.Controls.Add(this.btnAbrirNotas);
            this.Controls.Add(this.btnAbrirResumen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.btnAbrirNota);
            this.Controls.Add(this.btnAgregarNota);
            this.Controls.Add(this.RtxtDetalles);
            this.Controls.Add(this.cmbUsuarioAsignado);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dgvDetalleWO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleWO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDetalleWO;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbUsuarioAsignado;
        private System.Windows.Forms.RichTextBox RtxtDetalles;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Button btnAbrirNota;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbrirResumen;
        private System.Windows.Forms.Button btnAbrirNotas;
        private System.Windows.Forms.RichTextBox RtxtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaLimite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCriticidad;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Resolucion;
        private System.Windows.Forms.RichTextBox RtxtboxResolucion;
    }
}