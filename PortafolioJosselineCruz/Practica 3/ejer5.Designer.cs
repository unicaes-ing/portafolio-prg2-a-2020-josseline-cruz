namespace Practica_3
{
    partial class ejer5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvplanilla = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblimpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de la hora ";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(133, 28);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(285, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(133, 72);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 20);
            this.txthoras.TabIndex = 4;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(133, 123);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 5;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(52, 172);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvplanilla
            // 
            this.dgvplanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.lblsubtotal,
            this.lblimpuesto,
            this.lbltotal});
            this.dgvplanilla.Location = new System.Drawing.Point(52, 213);
            this.dgvplanilla.Name = "dgvplanilla";
            this.dgvplanilla.Size = new System.Drawing.Size(648, 150);
            this.dgvplanilla.TabIndex = 7;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(55, 396);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total planilla:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Horas Trabajadas";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor hora";
            this.Column3.Name = "Column3";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.HeaderText = "Subtotal";
            this.lblsubtotal.Name = "lblsubtotal";
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.HeaderText = "Impuesto";
            this.lblimpuesto.Name = "lblimpuesto";
            // 
            // lbltotal
            // 
            this.lbltotal.HeaderText = "Total";
            this.lbltotal.Name = "lbltotal";
            // 
            // ejer5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dgvplanilla);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ejer5";
            this.Text = "ejer5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvplanilla;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblsubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblimpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbltotal;
    }
}