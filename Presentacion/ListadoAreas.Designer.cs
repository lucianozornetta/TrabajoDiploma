namespace Presentacion
{
    partial class ListadoAreas
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
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAsignarTag = new System.Windows.Forms.Button();
            this.btnCrearTag = new System.Windows.Forms.Button();
            this.btnListarTagsEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAreas
            // 
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Location = new System.Drawing.Point(91, 76);
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.Size = new System.Drawing.Size(414, 343);
            this.dgvAreas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "AREAS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar Empleados Del Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(686, 76);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(305, 343);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(773, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleados";
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(745, 444);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(239, 21);
            this.cmbTags.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tags";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1153, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 329);
            this.listBox1.TabIndex = 7;
            // 
            // btnAsignarTag
            // 
            this.btnAsignarTag.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTag.Location = new System.Drawing.Point(725, 471);
            this.btnAsignarTag.Name = "btnAsignarTag";
            this.btnAsignarTag.Size = new System.Drawing.Size(290, 43);
            this.btnAsignarTag.TabIndex = 8;
            this.btnAsignarTag.Text = "Asignar Tag a Empleado";
            this.btnAsignarTag.UseVisualStyleBackColor = true;
            this.btnAsignarTag.Click += new System.EventHandler(this.btnAsignarTag_Click);
            // 
            // btnCrearTag
            // 
            this.btnCrearTag.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTag.Location = new System.Drawing.Point(725, 520);
            this.btnCrearTag.Name = "btnCrearTag";
            this.btnCrearTag.Size = new System.Drawing.Size(290, 33);
            this.btnCrearTag.TabIndex = 9;
            this.btnCrearTag.Text = "Crear Nuevo Tag";
            this.btnCrearTag.UseVisualStyleBackColor = true;
            this.btnCrearTag.Click += new System.EventHandler(this.btnCrearTag_Click);
            // 
            // btnListarTagsEmpleado
            // 
            this.btnListarTagsEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTagsEmpleado.Location = new System.Drawing.Point(1009, 77);
            this.btnListarTagsEmpleado.Name = "btnListarTagsEmpleado";
            this.btnListarTagsEmpleado.Size = new System.Drawing.Size(121, 49);
            this.btnListarTagsEmpleado.TabIndex = 10;
            this.btnListarTagsEmpleado.Text = "Listar Tags";
            this.btnListarTagsEmpleado.UseVisualStyleBackColor = true;
            this.btnListarTagsEmpleado.Click += new System.EventHandler(this.btnListarTagsEmpleado_Click);
            // 
            // ListadoAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 565);
            this.Controls.Add(this.btnListarTagsEmpleado);
            this.Controls.Add(this.btnCrearTag);
            this.Controls.Add(this.btnAsignarTag);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAreas);
            this.Name = "ListadoAreas";
            this.Text = "ListadoAreas";
            this.Load += new System.EventHandler(this.ListadoAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAsignarTag;
        private System.Windows.Forms.Button btnCrearTag;
        private System.Windows.Forms.Button btnListarTagsEmpleado;
    }
}