﻿namespace Practica_3
{
    partial class ejer3
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.lstNumero = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(21, 317);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar.TabIndex = 3;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // lstNumero
            // 
            this.lstNumero.FormattingEnabled = true;
            this.lstNumero.Location = new System.Drawing.Point(21, 23);
            this.lstNumero.Name = "lstNumero";
            this.lstNumero.Size = new System.Drawing.Size(89, 277);
            this.lstNumero.TabIndex = 2;
            // 
            // ejer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 351);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lstNumero);
            this.Name = "ejer3";
            this.Text = "ejer3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.ListBox lstNumero;
    }
}