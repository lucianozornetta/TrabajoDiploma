namespace Presentacion
{
    partial class CrearTag
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblNombreTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Nuevo Tag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(55, 60);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(122, 20);
            this.txtTag.TabIndex = 1;
            // 
            // lblNombreTag
            // 
            this.lblNombreTag.AutoSize = true;
            this.lblNombreTag.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTag.Location = new System.Drawing.Point(61, 39);
            this.lblNombreTag.Name = "lblNombreTag";
            this.lblNombreTag.Size = new System.Drawing.Size(101, 18);
            this.lblNombreTag.TabIndex = 2;
            this.lblNombreTag.Text = "Nombre de Tag";
            // 
            // CrearTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 177);
            this.Controls.Add(this.lblNombreTag);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.button1);
            this.Name = "CrearTag";
            this.Text = "CrearTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblNombreTag;
    }
}