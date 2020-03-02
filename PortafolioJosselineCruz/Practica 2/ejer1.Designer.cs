namespace Practica_2
{
    partial class ejer1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblromano = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblromano
            // 
            this.lblromano.AutoSize = true;
            this.lblromano.Location = new System.Drawing.Point(63, 84);
            this.lblromano.Name = "lblromano";
            this.lblromano.Size = new System.Drawing.Size(35, 13);
            this.lblromano.TabIndex = 9;
            this.lblromano.Text = "label2";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(246, 75);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(246, 30);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 7;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(96, 30);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 132);
            this.Controls.Add(this.lblromano);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblromano;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
    }
}

