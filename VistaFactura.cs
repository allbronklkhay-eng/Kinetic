using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMPORTADORAPOO
{
    public partial class VistaFactura : Form
    {


        // Constructor con parámetros

        // Datos recibidos en el constructor
        private readonly string nombreCliente;
        private readonly string numeroFactura;
        private readonly DateTime fecha;
        private readonly DataTable detalleProductos;
        private readonly decimal subtotal;
        private readonly decimal iva;
        private readonly decimal total;

        // Constructor con parámetros
        public VistaFactura(
            string nombreCliente,
            string numeroFactura,
            DateTime fecha,
            DataTable detalleProductos,
            decimal subtotal,
            decimal iva,
            decimal total)
        {
            InitializeComponent(); // Carga los controles diseñados manualmente

            this.nombreCliente = nombreCliente;
            this.numeroFactura = numeroFactura;
            this.fecha = fecha;
            this.detalleProductos = detalleProductos;
            this.subtotal = subtotal;
            this.iva = iva;
            this.total = total;
        }
        private void VistaFactura_Load_1(object sender, EventArgs e)
        {
            lblNumero.Text = $"Factura: {numeroFactura}";
            lblFecha.Text = $"Fecha: {fecha:dd/MM/yyyy HH:mm}";
            lblCliente.Text = $"Cliente: {nombreCliente}";

            // Asignar los productos a la grilla
            if (detalleProductos != null)
            {
                dgvDetalleFactura.DataSource = detalleProductos;

                // Formatear columnas numéricas si existen
                if (dgvDetalleFactura.Columns.Contains("PrecioUnitario"))
                    dgvDetalleFactura.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
                if (dgvDetalleFactura.Columns.Contains("Subtotal"))
                    dgvDetalleFactura.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                if (dgvDetalleFactura.Columns.Contains("Cantidad"))
                    dgvDetalleFactura.Columns["Cantidad"].DefaultCellStyle.Format = "N0";
            }

            // Asignar totales
            lblSubtotal.Text = $"Subtotal: ${subtotal:N2}";
            lblIva.Text = $"IVA (15%): ${iva:N2}";
            lblTotal.Text = $"TOTAL A PAGAR: ${total:N2}";
        }

        


        private void paneEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
