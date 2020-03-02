namespace Practica_3
{
    partial class ejer2
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
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lstletras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.White;
            this.btnmostrar.Location = new System.Drawing.Point(30, 261);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lstletras
            // 
            this.lstletras.BackColor = System.Drawing.Color.MediumOrchid;
            this.lstletras.FormattingEnabled = true;
            this.lstletras.Location = new System.Drawing.Point(12, 12);
            this.lstletras.Name = "lstletras";
            this.lstletras.Size = new System.Drawing.Size(120, 225);
            this.lstletras.TabIndex = 2;
            // 
            // ejer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 299);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lstletras);
            this.Name = "ejer2";
            this.Text = "ejer2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.ListBox lstletras;
    }
}