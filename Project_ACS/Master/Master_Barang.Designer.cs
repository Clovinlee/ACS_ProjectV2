﻿namespace Project_ACS.Master
{
    partial class Master_Barang
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
            this.pl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.Fuchsia;
            this.pl.Controls.Add(this.label1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(832, 453);
            this.pl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Master_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.pl);
            this.Name = "Master_Barang";
            this.Text = "Master_Barang";
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label label1;
    }
}