namespace Practica_2
{
    partial class ejer4
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
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(237, 158);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(104, 158);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.Location = new System.Drawing.Point(126, 103);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.Size = new System.Drawing.Size(100, 20);
            this.txtconfirmacion.TabIndex = 13;
            this.txtconfirmacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtconfirmacion_Validating);
            this.txtconfirmacion.Validated += new System.EventHandler(this.txtconfirmacion_Validated);
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(126, 58);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 12;
            this.txtcontra.Validating += new System.ComponentModel.CancelEventHandler(this.txtcontra_Validating);
            this.txtcontra.Validated += new System.EventHandler(this.txtcontra_Validated);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(126, 20);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(236, 20);
            this.txtcorreo.TabIndex = 11;
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            this.txtcorreo.Validated += new System.EventHandler(this.txtcorreo_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirmacion \r\nde Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // err2
            // 
            this.err2.ContainerControl = this;
            // 
            // err3
            // 
            this.err3.ContainerControl = this;
            // 
            // ejer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 199);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ejer4";
            this.Text = "ejer4";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.ErrorProvider err3;
    }
}