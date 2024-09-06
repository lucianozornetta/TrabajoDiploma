namespace Presentacion
{
    partial class Idiomas
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
            this.txtNombreIdiomaCrear = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelnombreidioma = new System.Windows.Forms.Label();
            this.btnCrearIdioma = new System.Windows.Forms.Button();
            this.dgvIdiomas = new System.Windows.Forms.DataGridView();
            this.cmbIdiomaAModificar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificarIdioma = new System.Windows.Forms.Button();
            this.lblidioma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreIdiomaCrear
            // 
            this.txtNombreIdiomaCrear.Location = new System.Drawing.Point(111, 55);
            this.txtNombreIdiomaCrear.Name = "txtNombreIdiomaCrear";
            this.txtNombreIdiomaCrear.Size = new System.Drawing.Size(151, 20);
            this.txtNombreIdiomaCrear.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelnombreidioma
            // 
            this.labelnombreidioma.AutoSize = true;
            this.labelnombreidioma.Location = new System.Drawing.Point(27, 58);
            this.labelnombreidioma.Name = "labelnombreidioma";
            this.labelnombreidioma.Size = new System.Drawing.Size(78, 13);
            this.labelnombreidioma.TabIndex = 2;
            this.labelnombreidioma.Tag = "labelNombreIdiomaIdiomas";
            this.labelnombreidioma.Text = "Nombre Idioma";
            // 
            // btnCrearIdioma
            // 
            this.btnCrearIdioma.Location = new System.Drawing.Point(111, 81);
            this.btnCrearIdioma.Name = "btnCrearIdioma";
            this.btnCrearIdioma.Size = new System.Drawing.Size(151, 23);
            this.btnCrearIdioma.TabIndex = 3;
            this.btnCrearIdioma.Tag = "btnCrearIdiomaIdiomas";
            this.btnCrearIdioma.Text = "Crear Idioma";
            this.btnCrearIdioma.UseVisualStyleBackColor = true;
            this.btnCrearIdioma.Click += new System.EventHandler(this.btnCrearIdioma_Click);
            // 
            // dgvIdiomas
            // 
            this.dgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdiomas.Location = new System.Drawing.Point(236, 19);
            this.dgvIdiomas.Name = "dgvIdiomas";
            this.dgvIdiomas.RowHeadersWidth = 62;
            this.dgvIdiomas.Size = new System.Drawing.Size(641, 318);
            this.dgvIdiomas.TabIndex = 4;
            this.dgvIdiomas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdiomas_CellContentClick);
            // 
            // cmbIdiomaAModificar
            // 
            this.cmbIdiomaAModificar.FormattingEnabled = true;
            this.cmbIdiomaAModificar.Location = new System.Drawing.Point(68, 71);
            this.cmbIdiomaAModificar.Name = "cmbIdiomaAModificar";
            this.cmbIdiomaAModificar.Size = new System.Drawing.Size(121, 21);
            this.cmbIdiomaAModificar.TabIndex = 5;
            this.cmbIdiomaAModificar.SelectedIndexChanged += new System.EventHandler(this.cmbIdiomaAModificar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearIdioma);
            this.groupBox1.Controls.Add(this.labelnombreidioma);
            this.groupBox1.Controls.Add(this.txtNombreIdiomaCrear);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificarIdioma);
            this.groupBox2.Controls.Add(this.lblidioma);
            this.groupBox2.Controls.Add(this.cmbIdiomaAModificar);
            this.groupBox2.Controls.Add(this.dgvIdiomas);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 363);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnModificarIdioma
            // 
            this.btnModificarIdioma.Location = new System.Drawing.Point(68, 123);
            this.btnModificarIdioma.Name = "btnModificarIdioma";
            this.btnModificarIdioma.Size = new System.Drawing.Size(121, 23);
            this.btnModificarIdioma.TabIndex = 7;
            this.btnModificarIdioma.Tag = "btnModificarIdiomaIdiomas";
            this.btnModificarIdioma.Text = "Modificar Idioma";
            this.btnModificarIdioma.UseVisualStyleBackColor = true;
            this.btnModificarIdioma.Click += new System.EventHandler(this.btnModificarIdioma_Click);
            // 
            // lblidioma
            // 
            this.lblidioma.AutoSize = true;
            this.lblidioma.Location = new System.Drawing.Point(6, 74);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(38, 13);
            this.lblidioma.TabIndex = 6;
            this.lblidioma.Tag = "labelIdiomaIdiomas";
            this.lblidioma.Text = "Idioma";
            // 
            // Idiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(685, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Idiomas";
            this.Text = "Idiomas";
            this.Load += new System.EventHandler(this.Idiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreIdiomaCrear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelnombreidioma;
        private System.Windows.Forms.Button btnCrearIdioma;
        private System.Windows.Forms.DataGridView dgvIdiomas;
        private System.Windows.Forms.ComboBox cmbIdiomaAModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.Button btnModificarIdioma;
    }
}