namespace Presentacion
{
    partial class UsuariosAlterados
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
            this.datagridalterados = new System.Windows.Forms.DataGridView();
            this.btnrecalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalterados)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridalterados
            // 
            this.datagridalterados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datagridalterados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridalterados.Location = new System.Drawing.Point(63, 55);
            this.datagridalterados.Margin = new System.Windows.Forms.Padding(2);
            this.datagridalterados.Name = "datagridalterados";
            this.datagridalterados.ReadOnly = true;
            this.datagridalterados.RowHeadersWidth = 62;
            this.datagridalterados.RowTemplate.Height = 28;
            this.datagridalterados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridalterados.Size = new System.Drawing.Size(408, 164);
            this.datagridalterados.TabIndex = 0;
            // 
            // btnrecalcular
            // 
            this.btnrecalcular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrecalcular.Location = new System.Drawing.Point(566, 77);
            this.btnrecalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnrecalcular.Name = "btnrecalcular";
            this.btnrecalcular.Size = new System.Drawing.Size(114, 55);
            this.btnrecalcular.TabIndex = 1;
            this.btnrecalcular.Tag = "btnUsuariosAlteradosRecalcularDigito";
            this.btnrecalcular.Text = "Recalcular digito";
            this.btnrecalcular.UseVisualStyleBackColor = true;
            this.btnrecalcular.Click += new System.EventHandler(this.btnrecalcular_Click);
            // 
            // UsuariosAlterados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(750, 292);
            this.Controls.Add(this.btnrecalcular);
            this.Controls.Add(this.datagridalterados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuariosAlterados";
            this.Text = "UsuariosAlterados";
            this.Load += new System.EventHandler(this.UsuariosAlterados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridalterados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridalterados;
        private System.Windows.Forms.Button btnrecalcular;
    }
}