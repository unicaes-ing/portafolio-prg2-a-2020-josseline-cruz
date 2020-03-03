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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtValorhora = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblimpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotalplanilla = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(133, 72);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 4;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            this.txtHoras.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoras_Validating);
            this.txtHoras.Validated += new System.EventHandler(this.txtHoras_Validated);
            // 
            // txtValorhora
            // 
            this.txtValorhora.Location = new System.Drawing.Point(133, 123);
            this.txtValorhora.Name = "txtValorhora";
            this.txtValorhora.Size = new System.Drawing.Size(100, 20);
            this.txtValorhora.TabIndex = 5;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.lblsubtotal,
            this.lblimpuesto,
            this.lbltotal});
            this.dataGridView1.Location = new System.Drawing.Point(52, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Horas Trabajadas";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor hora";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.HeaderText = "Subtotal";
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.ReadOnly = true;
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.HeaderText = "Impuesto";
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.ReadOnly = true;
            // 
            // lbltotal
            // 
            this.lbltotal.HeaderText = "Total";
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(55, 396);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lblTotalplanilla
            // 
            this.lblTotalplanilla.AutoSize = true;
            this.lblTotalplanilla.Location = new System.Drawing.Point(521, 406);
            this.lblTotalplanilla.Name = "lblTotalplanilla";
            this.lblTotalplanilla.Size = new System.Drawing.Size(69, 13);
            this.lblTotalplanilla.TabIndex = 9;
            this.lblTotalplanilla.Text = "Total planilla:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ejer5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 441);
            this.Controls.Add(this.lblTotalplanilla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtValorhora);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ejer5";
            this.Text = "ejer5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtValorhora;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotalplanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblsubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblimpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbltotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}