namespace Presentacion
{
    partial class AsignarEmpleadoArea
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignarArea = new System.Windows.Forms.Button();
            this.btnRemoverArea = new System.Windows.Forms.Button();
            this.btnHacerResponsable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(314, 72);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(455, 201);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // cmbAreas
            // 
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(32, 72);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(178, 21);
            this.cmbAreas.TabIndex = 2;
            this.cmbAreas.SelectedIndexChanged += new System.EventHandler(this.cmbAreas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // btnAsignarArea
            // 
            this.btnAsignarArea.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarArea.Location = new System.Drawing.Point(32, 99);
            this.btnAsignarArea.Name = "btnAsignarArea";
            this.btnAsignarArea.Size = new System.Drawing.Size(178, 34);
            this.btnAsignarArea.TabIndex = 4;
            this.btnAsignarArea.Text = "Asignar Area";
            this.btnAsignarArea.UseVisualStyleBackColor = true;
            this.btnAsignarArea.Click += new System.EventHandler(this.btnAsignarArea_Click);
            // 
            // btnRemoverArea
            // 
            this.btnRemoverArea.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverArea.Location = new System.Drawing.Point(641, 290);
            this.btnRemoverArea.Name = "btnRemoverArea";
            this.btnRemoverArea.Size = new System.Drawing.Size(128, 38);
            this.btnRemoverArea.TabIndex = 5;
            this.btnRemoverArea.Text = "Remover Area";
            this.btnRemoverArea.UseVisualStyleBackColor = true;
            this.btnRemoverArea.Click += new System.EventHandler(this.btnRemoverArea_Click);
            // 
            // btnHacerResponsable
            // 
            this.btnHacerResponsable.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerResponsable.Location = new System.Drawing.Point(32, 150);
            this.btnHacerResponsable.Name = "btnHacerResponsable";
            this.btnHacerResponsable.Size = new System.Drawing.Size(178, 51);
            this.btnHacerResponsable.TabIndex = 6;
            this.btnHacerResponsable.Text = "Asignar Como Responsable de Area";
            this.btnHacerResponsable.UseVisualStyleBackColor = true;
            this.btnHacerResponsable.Click += new System.EventHandler(this.btnHacerResponsable_Click);
            // 
            // AsignarEmpleadoArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnHacerResponsable);
            this.Controls.Add(this.btnRemoverArea);
            this.Controls.Add(this.btnAsignarArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAreas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "AsignarEmpleadoArea";
            this.Text = "AsignarEmpleadoArea";
            this.Load += new System.EventHandler(this.AsignarEmpleadoArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignarArea;
        private System.Windows.Forms.Button btnRemoverArea;
        private System.Windows.Forms.Button btnHacerResponsable;
    }
}