namespace Presentacion
{
    partial class Permisos
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearPermiso = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.btnReasignar = new System.Windows.Forms.Button();
            this.cmbEliminarPermiso = new System.Windows.Forms.ComboBox();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.CadetBlue;
            this.treeView1.Location = new System.Drawing.Point(332, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(423, 328);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "labelNombrePermisos";
            this.label1.Text = "Nombre";
            // 
            // btnCrearPermiso
            // 
            this.btnCrearPermiso.Location = new System.Drawing.Point(91, 201);
            this.btnCrearPermiso.Name = "btnCrearPermiso";
            this.btnCrearPermiso.Size = new System.Drawing.Size(162, 23);
            this.btnCrearPermiso.TabIndex = 4;
            this.btnCrearPermiso.Tag = "btnCrearNuevoPermisoPermisos";
            this.btnCrearPermiso.Text = "Crear Nuevo Permiso";
            this.btnCrearPermiso.UseVisualStyleBackColor = true;
            this.btnCrearPermiso.Click += new System.EventHandler(this.btnCrearPermiso_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(91, 109);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(162, 23);
            this.btnAsignarPermiso.TabIndex = 6;
            this.btnAsignarPermiso.Tag = "btnAsignarPermisoPermisos";
            this.btnAsignarPermiso.Text = "Asignar Permiso";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // btnReasignar
            // 
            this.btnReasignar.Location = new System.Drawing.Point(91, 152);
            this.btnReasignar.Name = "btnReasignar";
            this.btnReasignar.Size = new System.Drawing.Size(162, 22);
            this.btnReasignar.TabIndex = 7;
            this.btnReasignar.Tag = "btnLimpiarAsignacionPermisos";
            this.btnReasignar.Text = "Limpar Asignacion";
            this.btnReasignar.UseVisualStyleBackColor = true;
            this.btnReasignar.Click += new System.EventHandler(this.btnReasignar_Click);
            // 
            // cmbEliminarPermiso
            // 
            this.cmbEliminarPermiso.FormattingEnabled = true;
            this.cmbEliminarPermiso.Location = new System.Drawing.Point(100, 350);
            this.cmbEliminarPermiso.Name = "cmbEliminarPermiso";
            this.cmbEliminarPermiso.Size = new System.Drawing.Size(167, 21);
            this.cmbEliminarPermiso.TabIndex = 8;
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(100, 391);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(167, 23);
            this.btnEliminarPermiso.TabIndex = 9;
            this.btnEliminarPermiso.Tag = "btnEliminarPermisoPermisos";
            this.btnEliminarPermiso.Text = "Eliminar Permiso";
            this.btnEliminarPermiso.UseVisualStyleBackColor = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.cmbEliminarPermiso);
            this.Controls.Add(this.btnReasignar);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCrearPermiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearPermiso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Button btnReasignar;
        private System.Windows.Forms.ComboBox cmbEliminarPermiso;
        private System.Windows.Forms.Button btnEliminarPermiso;
    }
}