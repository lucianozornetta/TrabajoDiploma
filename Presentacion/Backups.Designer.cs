﻿namespace Presentacion
{
    partial class Backups
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
            this.btnGuardarBackup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarBackup
            // 
            this.btnGuardarBackup.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBackup.Location = new System.Drawing.Point(18, 36);
            this.btnGuardarBackup.Name = "btnGuardarBackup";
            this.btnGuardarBackup.Size = new System.Drawing.Size(163, 68);
            this.btnGuardarBackup.TabIndex = 1;
            this.btnGuardarBackup.Tag = "BackupBtnGuardarBackup";
            this.btnGuardarBackup.Text = "Guardar Backup De BD";
            this.btnGuardarBackup.UseVisualStyleBackColor = true;
            this.btnGuardarBackup.Click += new System.EventHandler(this.btnGuardarBackup_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 68);
            this.button2.TabIndex = 2;
            this.button2.Tag = "BackupBtnRestaurarBackup";
            this.button2.Text = "Restaurar Base de Datos.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar Directorio Backups";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Backups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(190, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarBackup);
            this.Name = "Backups";
            this.Text = "Backups";
            this.Load += new System.EventHandler(this.Backups_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarBackup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}