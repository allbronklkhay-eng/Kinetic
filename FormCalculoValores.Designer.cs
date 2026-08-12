namespace IMPORTADORAPOO
{
    partial class FormCalculoValores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAduana = new System.Windows.Forms.NumericUpDown();
            this.nudSeguro = new System.Windows.Forms.NumericUpDown();
            this.nudFlete = new System.Windows.Forms.NumericUpDown();
            this.nudFOB = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFacturacionImportdora = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarImportacion = new System.Windows.Forms.Button();
            this.btnCalcularCostos = new System.Windows.Forms.Button();
            this.dgvProrrateo = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCostoReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioSugerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAduana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFOB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProrrateo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculo de valores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAduana);
            this.groupBox1.Controls.Add(this.nudSeguro);
            this.groupBox1.Controls.Add(this.nudFlete);
            this.groupBox1.Controls.Add(this.nudFOB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFacturacionImportdora);
            this.groupBox1.Location = new System.Drawing.Point(2, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(892, 157);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // nudAduana
            // 
            this.nudAduana.DecimalPlaces = 2;
            this.nudAduana.Location = new System.Drawing.Point(568, 124);
            this.nudAduana.Margin = new System.Windows.Forms.Padding(2);
            this.nudAduana.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAduana.Name = "nudAduana";
            this.nudAduana.Size = new System.Drawing.Size(102, 20);
            this.nudAduana.TabIndex = 19;
            this.nudAduana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAduana.ThousandsSeparator = true;
            // 
            // nudSeguro
            // 
            this.nudSeguro.DecimalPlaces = 2;
            this.nudSeguro.Location = new System.Drawing.Point(410, 124);
            this.nudSeguro.Margin = new System.Windows.Forms.Padding(2);
            this.nudSeguro.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSeguro.Name = "nudSeguro";
            this.nudSeguro.Size = new System.Drawing.Size(102, 20);
            this.nudSeguro.TabIndex = 18;
            this.nudSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSeguro.ThousandsSeparator = true;
            // 
            // nudFlete
            // 
            this.nudFlete.DecimalPlaces = 2;
            this.nudFlete.Location = new System.Drawing.Point(216, 124);
            this.nudFlete.Margin = new System.Windows.Forms.Padding(2);
            this.nudFlete.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudFlete.Name = "nudFlete";
            this.nudFlete.Size = new System.Drawing.Size(102, 20);
            this.nudFlete.TabIndex = 17;
            this.nudFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFlete.ThousandsSeparator = true;
            // 
            // nudFOB
            // 
            this.nudFOB.DecimalPlaces = 2;
            this.nudFOB.Location = new System.Drawing.Point(10, 124);
            this.nudFOB.Margin = new System.Windows.Forms.Padding(2);
            this.nudFOB.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudFOB.Name = "nudFOB";
            this.nudFOB.Size = new System.Drawing.Size(102, 20);
            this.nudFOB.TabIndex = 16;
            this.nudFOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFOB.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "nudAduana(Impuesto):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seguro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Flete Internacional:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "nudFOB(Mercadería):";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Factura N°:";
            // 
            // txtFacturacionImportdora
            // 
            this.txtFacturacionImportdora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacturacionImportdora.Location = new System.Drawing.Point(92, 20);
            this.txtFacturacionImportdora.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacturacionImportdora.Name = "txtFacturacionImportdora";
            this.txtFacturacionImportdora.ReadOnly = true;
            this.txtFacturacionImportdora.Size = new System.Drawing.Size(157, 20);
            this.txtFacturacionImportdora.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarImportacion);
            this.groupBox2.Controls.Add(this.btnCalcularCostos);
            this.groupBox2.Controls.Add(this.dgvProrrateo);
            this.groupBox2.Location = new System.Drawing.Point(2, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(892, 324);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnGuardarImportacion
            // 
            this.btnGuardarImportacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnGuardarImportacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarImportacion.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarImportacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarImportacion.Location = new System.Drawing.Point(525, 262);
            this.btnGuardarImportacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarImportacion.Name = "btnGuardarImportacion";
            this.btnGuardarImportacion.Size = new System.Drawing.Size(196, 58);
            this.btnGuardarImportacion.TabIndex = 2;
            this.btnGuardarImportacion.Text = "ACTUALIZAR INVENTARIO Y PRECIOS";
            this.btnGuardarImportacion.UseVisualStyleBackColor = false;
            this.btnGuardarImportacion.Click += new System.EventHandler(this.btnGuardarImportacion_Click);
            // 
            // btnCalcularCostos
            // 
            this.btnCalcularCostos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcularCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularCostos.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCostos.ForeColor = System.Drawing.Color.White;
            this.btnCalcularCostos.Location = new System.Drawing.Point(122, 262);
            this.btnCalcularCostos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcularCostos.Name = "btnCalcularCostos";
            this.btnCalcularCostos.Size = new System.Drawing.Size(196, 58);
            this.btnCalcularCostos.TabIndex = 1;
            this.btnCalcularCostos.Text = "CALCULAR COSTOS REALES";
            this.btnCalcularCostos.UseVisualStyleBackColor = false;
            this.btnCalcularCostos.Click += new System.EventHandler(this.btnCalcularCostos_Click);
            // 
            // dgvProrrateo
            // 
            this.dgvProrrateo.AllowUserToAddRows = false;
            this.dgvProrrateo.AllowUserToDeleteRows = false;
            this.dgvProrrateo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProrrateo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProrrateo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecioOrigen,
            this.ColCostoReal,
            this.ColPrecioSugerido});
            this.dgvProrrateo.Location = new System.Drawing.Point(4, 17);
            this.dgvProrrateo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProrrateo.Name = "dgvProrrateo";
            this.dgvProrrateo.RowHeadersVisible = false;
            this.dgvProrrateo.RowHeadersWidth = 51;
            this.dgvProrrateo.RowTemplate.Height = 24;
            this.dgvProrrateo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProrrateo.Size = new System.Drawing.Size(827, 239);
            this.dgvProrrateo.TabIndex = 0;
            // 
            // ColCodigo
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColCodigo.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColPrecioOrigen
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.ColPrecioOrigen.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColPrecioOrigen.HeaderText = "P.  Origen ($)";
            this.ColPrecioOrigen.MinimumWidth = 6;
            this.ColPrecioOrigen.Name = "ColPrecioOrigen";
            this.ColPrecioOrigen.ReadOnly = true;
            // 
            // ColCostoReal
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.ColCostoReal.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColCostoReal.HeaderText = "Costo Real Calculado";
            this.ColCostoReal.MinimumWidth = 6;
            this.ColCostoReal.Name = "ColCostoReal";
            this.ColCostoReal.ReadOnly = true;
            // 
            // ColPrecioSugerido
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.ColPrecioSugerido.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColPrecioSugerido.HeaderText = "P. Venta Sugerido";
            this.ColPrecioSugerido.MinimumWidth = 6;
            this.ColPrecioSugerido.Name = "ColPrecioSugerido";
            this.ColPrecioSugerido.ReadOnly = true;
            // 
            // FormCalculoValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(905, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCalculoValores";
            this.Text = "FormCalculoValores";
            this.Load += new System.EventHandler(this.FormCalculoValores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAduana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFOB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProrrateo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFacturacionImportdora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSeguro;
        private System.Windows.Forms.NumericUpDown nudFlete;
        private System.Windows.Forms.NumericUpDown nudFOB;
        private System.Windows.Forms.NumericUpDown nudAduana;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProrrateo;
        private System.Windows.Forms.Button btnGuardarImportacion;
        private System.Windows.Forms.Button btnCalcularCostos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCostoReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioSugerido;
    }
}