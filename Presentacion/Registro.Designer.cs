namespace Presentacion
{
    partial class Registro
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
            this.datagridusuarios = new System.Windows.Forms.DataGridView();
            this.btnregistrarusuario = new System.Windows.Forms.Button();
            this.btneliminarusuarioRegistro = new System.Windows.Forms.Button();
            this.btnmodificarusuarioRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.datagridcambios = new System.Windows.Forms.DataGridView();
            this.btnrestaurarcambios = new System.Windows.Forms.Button();
            this.btnAsignarArea = new System.Windows.Forms.Button();
            this.cmbAsignarAreas = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcambios)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridusuarios
            // 
            this.datagridusuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridusuarios.Location = new System.Drawing.Point(320, 31);
            this.datagridusuarios.Margin = new System.Windows.Forms.Padding(2);
            this.datagridusuarios.Name = "datagridusuarios";
            this.datagridusuarios.ReadOnly = true;
            this.datagridusuarios.RowHeadersWidth = 62;
            this.datagridusuarios.RowTemplate.Height = 28;
            this.datagridusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridusuarios.Size = new System.Drawing.Size(371, 133);
            this.datagridusuarios.TabIndex = 0;
            this.datagridusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridusuarios_CellClick);
            this.datagridusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridusuarios_CellContentClick);
            this.datagridusuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridusuarios_RowHeaderMouseClick);
            this.datagridusuarios.TabIndexChanged += new System.EventHandler(this.datagridusuarios_TabIndexChanged);
            // 
            // btnregistrarusuario
            // 
            this.btnregistrarusuario.Location = new System.Drawing.Point(221, 22);
            this.btnregistrarusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnregistrarusuario.Name = "btnregistrarusuario";
            this.btnregistrarusuario.Size = new System.Drawing.Size(79, 34);
            this.btnregistrarusuario.TabIndex = 1;
            this.btnregistrarusuario.Tag = "btnRegistrarUsuarioRegistro";
            this.btnregistrarusuario.Text = "Registrar usuario";
            this.btnregistrarusuario.UseVisualStyleBackColor = true;
            this.btnregistrarusuario.Click += new System.EventHandler(this.btnregistrarusuario_Click);
            // 
            // btneliminarusuarioRegistro
            // 
            this.btneliminarusuarioRegistro.Location = new System.Drawing.Point(221, 63);
            this.btneliminarusuarioRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminarusuarioRegistro.Name = "btneliminarusuarioRegistro";
            this.btneliminarusuarioRegistro.Size = new System.Drawing.Size(79, 38);
            this.btneliminarusuarioRegistro.TabIndex = 2;
            this.btneliminarusuarioRegistro.Tag = "btnBorrarUsuarioRegistro";
            this.btneliminarusuarioRegistro.Text = "Borrar usuario";
            this.btneliminarusuarioRegistro.UseVisualStyleBackColor = true;
            this.btneliminarusuarioRegistro.Click += new System.EventHandler(this.btneliminarusuario_Click);
            // 
            // btnmodificarusuarioRegistro
            // 
            this.btnmodificarusuarioRegistro.Location = new System.Drawing.Point(221, 105);
            this.btnmodificarusuarioRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificarusuarioRegistro.Name = "btnmodificarusuarioRegistro";
            this.btnmodificarusuarioRegistro.Size = new System.Drawing.Size(79, 34);
            this.btnmodificarusuarioRegistro.TabIndex = 3;
            this.btnmodificarusuarioRegistro.Tag = "btnModificarUsuarioRegistro";
            this.btnmodificarusuarioRegistro.Text = "Modificar contraseña";
            this.btnmodificarusuarioRegistro.UseVisualStyleBackColor = true;
            this.btnmodificarusuarioRegistro.Click += new System.EventHandler(this.btnmodificarusuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "labelUsuarioRegistroUsuario";
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Tag = "labelContraseñaRegistroUsuario";
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(118, 36);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(68, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(118, 81);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(68, 20);
            this.txtcontraseña.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(36, 228);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(284, 49);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // datagridcambios
            // 
            this.datagridcambios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridcambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcambios.Location = new System.Drawing.Point(326, 228);
            this.datagridcambios.Margin = new System.Windows.Forms.Padding(2);
            this.datagridcambios.Name = "datagridcambios";
            this.datagridcambios.ReadOnly = true;
            this.datagridcambios.RowHeadersWidth = 62;
            this.datagridcambios.RowTemplate.Height = 28;
            this.datagridcambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridcambios.Size = new System.Drawing.Size(371, 133);
            this.datagridcambios.TabIndex = 12;
            // 
            // btnrestaurarcambios
            // 
            this.btnrestaurarcambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnrestaurarcambios.Location = new System.Drawing.Point(221, 316);
            this.btnrestaurarcambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnrestaurarcambios.Name = "btnrestaurarcambios";
            this.btnrestaurarcambios.Size = new System.Drawing.Size(85, 42);
            this.btnrestaurarcambios.TabIndex = 13;
            this.btnrestaurarcambios.Tag = "btnRestaurarcontraseñaRegistro";
            this.btnrestaurarcambios.Text = "Restablecer contraseña";
            this.btnrestaurarcambios.UseVisualStyleBackColor = true;
            this.btnrestaurarcambios.Click += new System.EventHandler(this.btnrestaurarcambios_Click);
            // 
            // btnAsignarArea
            // 
            this.btnAsignarArea.Location = new System.Drawing.Point(612, 169);
            this.btnAsignarArea.Name = "btnAsignarArea";
            this.btnAsignarArea.Size = new System.Drawing.Size(79, 36);
            this.btnAsignarArea.TabIndex = 14;
            this.btnAsignarArea.Text = "Asignar Area";
            this.btnAsignarArea.UseVisualStyleBackColor = true;
            this.btnAsignarArea.Visible = false;
            this.btnAsignarArea.Click += new System.EventHandler(this.btnAsignarArea_Click);
            // 
            // cmbAsignarAreas
            // 
            this.cmbAsignarAreas.FormattingEnabled = true;
            this.cmbAsignarAreas.Location = new System.Drawing.Point(474, 178);
            this.cmbAsignarAreas.Name = "cmbAsignarAreas";
            this.cmbAsignarAreas.Size = new System.Drawing.Size(121, 21);
            this.cmbAsignarAreas.TabIndex = 15;
            this.cmbAsignarAreas.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(727, 369);
            this.Controls.Add(this.cmbAsignarAreas);
            this.Controls.Add(this.btnAsignarArea);
            this.Controls.Add(this.btnrestaurarcambios);
            this.Controls.Add(this.datagridcambios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificarusuarioRegistro);
            this.Controls.Add(this.btneliminarusuarioRegistro);
            this.Controls.Add(this.btnregistrarusuario);
            this.Controls.Add(this.datagridusuarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridusuarios;
        private System.Windows.Forms.Button btnregistrarusuario;
        private System.Windows.Forms.Button btneliminarusuarioRegistro;
        private System.Windows.Forms.Button btnmodificarusuarioRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView datagridcambios;
        private System.Windows.Forms.Button btnrestaurarcambios;
        private System.Windows.Forms.Button btnAsignarArea;
        private System.Windows.Forms.ComboBox cmbAsignarAreas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}