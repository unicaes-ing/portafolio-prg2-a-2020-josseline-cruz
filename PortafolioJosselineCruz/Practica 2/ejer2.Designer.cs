namespace Practica_2
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdodesc5 = new System.Windows.Forms.RadioButton();
            this.rdodesc4 = new System.Windows.Forms.RadioButton();
            this.rdodesc3 = new System.Windows.Forms.RadioButton();
            this.rdodesc2 = new System.Windows.Forms.RadioButton();
            this.rdodesc1 = new System.Windows.Forms.RadioButton();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(204, 285);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(71, 285);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 22;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(97, 225);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 21;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(97, 190);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 20);
            this.txtdesc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descuento";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(106, 108);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 17;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdodesc5);
            this.groupBox1.Controls.Add(this.rdodesc4);
            this.groupBox1.Controls.Add(this.rdodesc3);
            this.groupBox1.Controls.Add(this.rdodesc2);
            this.groupBox1.Controls.Add(this.rdodesc1);
            this.groupBox1.Location = new System.Drawing.Point(296, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 190);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento";
            // 
            // rdodesc5
            // 
            this.rdodesc5.AutoSize = true;
            this.rdodesc5.Location = new System.Drawing.Point(7, 166);
            this.rdodesc5.Name = "rdodesc5";
            this.rdodesc5.Size = new System.Drawing.Size(45, 17);
            this.rdodesc5.TabIndex = 4;
            this.rdodesc5.TabStop = true;
            this.rdodesc5.Text = "20%";
            this.rdodesc5.UseVisualStyleBackColor = true;
            // 
            // rdodesc4
            // 
            this.rdodesc4.AutoSize = true;
            this.rdodesc4.Location = new System.Drawing.Point(7, 130);
            this.rdodesc4.Name = "rdodesc4";
            this.rdodesc4.Size = new System.Drawing.Size(45, 17);
            this.rdodesc4.TabIndex = 3;
            this.rdodesc4.TabStop = true;
            this.rdodesc4.Text = "15%";
            this.rdodesc4.UseVisualStyleBackColor = true;
            // 
            // rdodesc3
            // 
            this.rdodesc3.AutoSize = true;
            this.rdodesc3.Location = new System.Drawing.Point(7, 93);
            this.rdodesc3.Name = "rdodesc3";
            this.rdodesc3.Size = new System.Drawing.Size(45, 17);
            this.rdodesc3.TabIndex = 2;
            this.rdodesc3.TabStop = true;
            this.rdodesc3.Text = "10%";
            this.rdodesc3.UseVisualStyleBackColor = true;
            // 
            // rdodesc2
            // 
            this.rdodesc2.AutoSize = true;
            this.rdodesc2.Location = new System.Drawing.Point(7, 65);
            this.rdodesc2.Name = "rdodesc2";
            this.rdodesc2.Size = new System.Drawing.Size(39, 17);
            this.rdodesc2.TabIndex = 1;
            this.rdodesc2.TabStop = true;
            this.rdodesc2.Text = "5%";
            this.rdodesc2.UseVisualStyleBackColor = true;
            // 
            // rdodesc1
            // 
            this.rdodesc1.AutoSize = true;
            this.rdodesc1.Location = new System.Drawing.Point(7, 30);
            this.rdodesc1.Name = "rdodesc1";
            this.rdodesc1.Size = new System.Drawing.Size(39, 17);
            this.rdodesc1.TabIndex = 0;
            this.rdodesc1.TabStop = true;
            this.rdodesc1.Text = "0%";
            this.rdodesc1.UseVisualStyleBackColor = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(97, 67);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 15;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(97, 20);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad";
            // 
            // ejer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ejer2";
            this.Text = "ejer2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdodesc5;
        private System.Windows.Forms.RadioButton rdodesc4;
        private System.Windows.Forms.RadioButton rdodesc3;
        private System.Windows.Forms.RadioButton rdodesc2;
        private System.Windows.Forms.RadioButton rdodesc1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}