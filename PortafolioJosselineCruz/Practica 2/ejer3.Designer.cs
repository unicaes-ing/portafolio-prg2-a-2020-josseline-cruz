namespace Practica_2
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoPulgadas2 = new System.Windows.Forms.RadioButton();
            this.rdoPies2 = new System.Windows.Forms.RadioButton();
            this.rdoYardas2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPulgadas = new System.Windows.Forms.RadioButton();
            this.rdoPies = new System.Windows.Forms.RadioButton();
            this.rdoYardas = new System.Windows.Forms.RadioButton();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(145, 264);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(55, 264);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 14;
            this.btnconvertir.Text = "Convertir ";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // txtConversion
            // 
            this.txtConversion.Location = new System.Drawing.Point(145, 225);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(100, 20);
            this.txtConversion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Longitud convertida";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoPulgadas2);
            this.groupBox2.Controls.Add(this.rdoPies2);
            this.groupBox2.Controls.Add(this.rdoYardas2);
            this.groupBox2.Location = new System.Drawing.Point(190, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 131);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "a";
            // 
            // rdoPulgadas2
            // 
            this.rdoPulgadas2.AutoSize = true;
            this.rdoPulgadas2.Location = new System.Drawing.Point(7, 94);
            this.rdoPulgadas2.Name = "rdoPulgadas2";
            this.rdoPulgadas2.Size = new System.Drawing.Size(69, 17);
            this.rdoPulgadas2.TabIndex = 2;
            this.rdoPulgadas2.TabStop = true;
            this.rdoPulgadas2.Text = "Pulgadas";
            this.rdoPulgadas2.UseVisualStyleBackColor = true;
            // 
            // rdoPies2
            // 
            this.rdoPies2.AutoSize = true;
            this.rdoPies2.Location = new System.Drawing.Point(7, 55);
            this.rdoPies2.Name = "rdoPies2";
            this.rdoPies2.Size = new System.Drawing.Size(45, 17);
            this.rdoPies2.TabIndex = 1;
            this.rdoPies2.TabStop = true;
            this.rdoPies2.Text = "Pies";
            this.rdoPies2.UseVisualStyleBackColor = true;
            // 
            // rdoYardas2
            // 
            this.rdoYardas2.AutoSize = true;
            this.rdoYardas2.Location = new System.Drawing.Point(7, 20);
            this.rdoYardas2.Name = "rdoYardas2";
            this.rdoYardas2.Size = new System.Drawing.Size(58, 17);
            this.rdoYardas2.TabIndex = 0;
            this.rdoYardas2.TabStop = true;
            this.rdoYardas2.Text = "Yardas";
            this.rdoYardas2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPulgadas);
            this.groupBox1.Controls.Add(this.rdoPies);
            this.groupBox1.Controls.Add(this.rdoYardas);
            this.groupBox1.Location = new System.Drawing.Point(26, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 131);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // rdoPulgadas
            // 
            this.rdoPulgadas.AutoSize = true;
            this.rdoPulgadas.Location = new System.Drawing.Point(7, 94);
            this.rdoPulgadas.Name = "rdoPulgadas";
            this.rdoPulgadas.Size = new System.Drawing.Size(69, 17);
            this.rdoPulgadas.TabIndex = 2;
            this.rdoPulgadas.TabStop = true;
            this.rdoPulgadas.Text = "Pulgadas";
            this.rdoPulgadas.UseVisualStyleBackColor = true;
            // 
            // rdoPies
            // 
            this.rdoPies.AutoSize = true;
            this.rdoPies.Location = new System.Drawing.Point(7, 55);
            this.rdoPies.Name = "rdoPies";
            this.rdoPies.Size = new System.Drawing.Size(45, 17);
            this.rdoPies.TabIndex = 1;
            this.rdoPies.TabStop = true;
            this.rdoPies.Text = "Pies";
            this.rdoPies.UseVisualStyleBackColor = true;
            // 
            // rdoYardas
            // 
            this.rdoYardas.AutoSize = true;
            this.rdoYardas.Location = new System.Drawing.Point(7, 20);
            this.rdoYardas.Name = "rdoYardas";
            this.rdoYardas.Size = new System.Drawing.Size(58, 17);
            this.rdoYardas.TabIndex = 0;
            this.rdoYardas.TabStop = true;
            this.rdoYardas.Text = "Yardas";
            this.rdoYardas.UseVisualStyleBackColor = true;
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(190, 20);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(100, 20);
            this.txtlongitud.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduzca longitud a convertir ";
            // 
            // ejer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 324);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.label1);
            this.Name = "ejer3";
            this.Text = "ejer3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoPulgadas2;
        private System.Windows.Forms.RadioButton rdoPies2;
        private System.Windows.Forms.RadioButton rdoYardas2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPulgadas;
        private System.Windows.Forms.RadioButton rdoPies;
        private System.Windows.Forms.RadioButton rdoYardas;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.Label label1;
    }
}