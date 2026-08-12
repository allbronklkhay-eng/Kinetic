namespace IMPORTADORAPOO
{
    partial class VistaFactura
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
            this.paneEncabezado = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.btncerrar2 = new System.Windows.Forms.Button();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.paneEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneEncabezado
            // 
            this.paneEncabezado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneEncabezado.Controls.Add(this.lblNumero);
            this.paneEncabezado.Controls.Add(this.lblFecha);
            this.paneEncabezado.Controls.Add(this.lblCliente);
            this.paneEncabezado.Location = new System.Drawing.Point(2, 1);
            this.paneEncabezado.Name = "paneEncabezado";
            this.paneEncabezado.Size = new System.Drawing.Size(623, 100);
            this.paneEncabezado.TabIndex = 0;
            this.paneEncabezado.Paint += new System.Windows.Forms.PaintEventHandler(this.paneEncabezado_Paint);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(39, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(61, 18);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Suvtotal";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(39, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 18);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Suvtotal";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(419, 66);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Suvtotal";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.AllowUserToOrderColumns = true;
            this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(2, 106);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersVisible = false;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(623, 165);
            this.dgvDetalleFactura.TabIndex = 1;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTotal.Controls.Add(this.btncerrar2);
            this.panelTotal.Controls.Add(this.lblIva);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Controls.Add(this.lblSubtotal);
            this.panelTotal.Location = new System.Drawing.Point(2, 277);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(623, 114);
            this.panelTotal.TabIndex = 2;
            // 
            // btncerrar2
            // 
            this.btncerrar2.Location = new System.Drawing.Point(54, 60);
            this.btncerrar2.Name = "btncerrar2";
            this.btncerrar2.Size = new System.Drawing.Size(75, 23);
            this.btncerrar2.TabIndex = 3;
            this.btncerrar2.Text = "Cerrar";
            this.btncerrar2.UseVisualStyleBackColor = true;
            this.btncerrar2.Click += new System.EventHandler(this.btncerrar2_Click);
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(393, 51);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(29, 18);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(393, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(393, 30);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(61, 18);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Suvtotal";
            // 
            // VistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 395);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.paneEncabezado);
            this.Name = "VistaFactura";
            this.Text = "VistaFactura";
            this.Load += new System.EventHandler(this.VistaFactura_Load_1);
            this.paneEncabezado.ResumeLayout(false);
            this.paneEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneEncabezado;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Button btncerrar2;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
    }
}