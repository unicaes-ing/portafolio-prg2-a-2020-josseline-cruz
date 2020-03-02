namespace Practica_4
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnumbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstlista = new System.Windows.Forms.ListBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(199, 291);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnumbuscar
            // 
            this.txtnumbuscar.Location = new System.Drawing.Point(188, 254);
            this.txtnumbuscar.Name = "txtnumbuscar";
            this.txtnumbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtnumbuscar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero";
            // 
            // lstlista
            // 
            this.lstlista.FormattingEnabled = true;
            this.lstlista.Location = new System.Drawing.Point(28, 79);
            this.lstlista.Name = "lstlista";
            this.lstlista.Size = new System.Drawing.Size(120, 212);
            this.lstlista.TabIndex = 10;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(213, 23);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(81, 25);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero ";
            // 
            // ejer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 350);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnumbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstlista);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "ejer2";
            this.Text = "ejer2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnumbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstlista;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
    }
}