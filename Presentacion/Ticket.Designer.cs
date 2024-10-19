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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleWO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 469);
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
            this.dgvDetalleWO.Size = new System.Drawing.Size(705, 337);
            this.dgvDetalleWO.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(220, 152);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(183, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(220, 79);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(183, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 75);
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
            this.cmbUsuarioAsignado.Location = new System.Drawing.Point(220, 469);
            this.cmbUsuarioAsignado.Name = "cmbUsuarioAsignado";
            this.cmbUsuarioAsignado.Size = new System.Drawing.Size(183, 21);
            this.cmbUsuarioAsignado.TabIndex = 8;
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
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(220, 219);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(183, 20);
            this.txtResumen.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Resumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Notas";
            // 
            // btnAbrirResumen
            // 
            this.btnAbrirResumen.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirResumen.Image")));
            this.btnAbrirResumen.Location = new System.Drawing.Point(409, 204);
            this.btnAbrirResumen.Name = "btnAbrirResumen";
            this.btnAbrirResumen.Size = new System.Drawing.Size(49, 48);
            this.btnAbrirResumen.TabIndex = 18;
            this.btnAbrirResumen.UseVisualStyleBackColor = true;
            // 
            // btnAbrirNotas
            // 
            this.btnAbrirNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirNotas.Image")));
            this.btnAbrirNotas.Location = new System.Drawing.Point(409, 277);
            this.btnAbrirNotas.Name = "btnAbrirNotas";
            this.btnAbrirNotas.Size = new System.Drawing.Size(49, 48);
            this.btnAbrirNotas.TabIndex = 19;
            this.btnAbrirNotas.UseVisualStyleBackColor = true;
            // 
            // RtxtNotas
            // 
            this.RtxtNotas.Location = new System.Drawing.Point(220, 288);
            this.RtxtNotas.Name = "RtxtNotas";
            this.RtxtNotas.Size = new System.Drawing.Size(183, 23);
            this.RtxtNotas.TabIndex = 20;
            this.RtxtNotas.Text = "";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 622);
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
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleWO)).EndInit();
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
    }
}