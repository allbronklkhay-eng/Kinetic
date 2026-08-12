using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMPORTADORAPOO
{
    public partial class frmFacturcion : Form
    {
        public frmFacturcion()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductosDesdeBD();
        }


        // Evento Load del Formulario


        // Método para llenar el ComboBox con los productos activos de SQL Server
        private void CargarProductosDesdeBD()
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    // Consulta para traer solo productos activos y con stock disponible
                    string query = @"SELECT ID_Producto, Codigo, Descripcion, Precio, Stock,
                                            CONCAT('[', Codigo, '] ', Descripcion, ' - $', Precio) AS NombreMostrar
                                     FROM Productos 
                                     WHERE Activo = 1 AND Stock > 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox1.DisplayMember = "NombreMostrar"; // Lo que ve el usuario
                    comboBox1.ValueMember = "ID_Producto";     // Clave primaria oculta
                    comboBox1.DataSource = dt;
                    comboBox1.SelectedIndex = -1;             // Iniciar sin selección
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos desde la base de datos: " + ex.Message,
                                "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón "Añadir a factura" (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, busca y selecciona un producto primero.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extraer la fila de datos de la opción seleccionada en el ComboBox
            DataRowView productoElegido = (DataRowView)comboBox1.SelectedItem;

            string codigo = productoElegido["Codigo"].ToString();
            string descripcion = productoElegido["Descripcion"].ToString();
            decimal precio = Convert.ToDecimal(productoElegido["Precio"]);
            int stockDisponible = Convert.ToInt32(productoElegido["Stock"]);
            int cantidadElegida = (int)numericUpDown1.Value;

            // Validación de cantidad válida
            if (cantidadElegida <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de Stock suficiente
            if (cantidadElegida > stockDisponible)
            {
                MessageBox.Show($"No hay suficiente stock. Disponible actualmente: {stockDisponible} unidades.",
                                "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular Subtotal de la línea
            decimal subtotalLinea = cantidadElegida * precio;

            // Agregar fila al DataGridView (Código, Descripción, Cantidad, Precio Unitario, Subtotal)
            dataGridView1.Rows.Add(
                codigo,
                descripcion,
                cantidadElegida,
                precio,
                subtotalLinea
            );

            // Reiniciar controles de selección
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 1;

            // Recalcular Subtotal, IVA y Total a Pagar
            CalcularTotales();
        }

        // Método para calcular la suma de la factura
        private void CalcularTotales()
        {
            decimal sumaSubtotal = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Columna 4 corresponde al Subtotal de cada línea
                if (fila.Cells[4].Value != null)
                {
                    sumaSubtotal += Convert.ToDecimal(fila.Cells[4].Value);
                }
            }

            decimal iva = sumaSubtotal * 0.15m; // IVA del 15%
            decimal totalAPagar = sumaSubtotal + iva;

            lblSubtotal.Text = sumaSubtotal.ToString("C2");
            lblIva.Text = iva.ToString("C2");
            lblTotal.Text = totalAPagar.ToString("C2");
        }

        private void btnMenuCalculo_Click(object sender, EventArgs e)
        {
            FormCalculoValores pantallaCalculo = new FormCalculoValores();


            pantallaCalculo.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {

            // Validar que las dos cajas de texto tengan información
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor ingrese  el Nombre del cliente.",
                                "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación visual sin tocar la base de datos
            MessageBox.Show($"Cliente asignado a la factura:\nNombre: {textBox1.Text.Trim()}",
                            "Cliente Asignado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya ingresado la Cédula y el Nombre del cliente
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor ingrese la Cédula y el Nombre del cliente antes de realizar la factura.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que la tabla de productos tenga al menos un ítem
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos agregados a la factura.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Crear la estructura en memoria de los productos agregados
            DataTable dtDetalle = new DataTable();
            dtDetalle.Columns.Add("Codigo", typeof(string));
            dtDetalle.Columns.Add("Descripcion", typeof(string));
            dtDetalle.Columns.Add("Cantidad", typeof(int));
            dtDetalle.Columns.Add("PrecioUnitario", typeof(decimal));
            dtDetalle.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    dtDetalle.Rows.Add(
                        fila.Cells[0].Value.ToString(),
                        fila.Cells[1].Value.ToString(),
                        Convert.ToInt32(fila.Cells[2].Value),
                        Convert.ToDecimal(fila.Cells[3].Value),
                        Convert.ToDecimal(fila.Cells[4].Value)
                    );
                }
            }
            // 4. DESCONTAR EL STOCK DIRECTAMENTE EN LA BASE DE DATOS SQL SERVER
            bool exitoDescuento = DescontarStockBD(dtDetalle);

            if (!exitoDescuento)
            {
                // Si ocurre un error de base de datos, interrumpe la emisión
                return;
            }

            // 4. Obtener los 2 datos del cliente

            string cliente = textBox1.Text.Trim();

            // Datos estáticos/calculados para la muestra
            string numFactura = "FAC-2026-0001";
            DateTime fecha = DateTime.Now;

            // Convertir los textos de los totales a valores numéricos limpiando símbolos de moneda
            decimal subtotal = 0, iva = 0, total = 0;
            decimal.TryParse(lblSubtotal.Text.Replace("$", "").Trim(), out subtotal);
            decimal.TryParse(lblIva.Text.Replace("$", "").Trim(), out iva);
            decimal.TryParse(lblTotal.Text.Replace("$", "").Trim(), out total);

            // 5. Abrir la factura visual para mostrar el nombre y cédula ingresados
            VistaFactura comprobante = new VistaFactura(

                cliente,
                numFactura,
                fecha,
                dtDetalle,
                subtotal,
                iva,
                total
            );

            comprobante.ShowDialog(); // Muestra la factura emergente
        }

        private void btnRealizarFactura_Click(object sender, EventArgs e)
        {



        }
        private bool DescontarStockBD(DataTable dtDetalle)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    // Uso de transacción para seguridad
                    using (SqlTransaction tx = con.BeginTransaction())
                    {
                        try
                        {
                            string query = @"UPDATE Productos 
                                             SET Stock = Stock - @cantidad,
                                                 Estado = CASE 
                                                             WHEN (Stock - @cantidad) <= 0 THEN 'Agotado'
                                                             WHEN (Stock - @cantidad) <= 5 THEN 'Crítico'
                                                             ELSE 'En Stock'
                                                          END
                                             WHERE Codigo = @codigo";

                            foreach (DataRow fila in dtDetalle.Rows)
                            {
                                string codigo = fila["Codigo"].ToString();
                                int cantidad = Convert.ToInt32(fila["Cantidad"]);

                                using (SqlCommand cmd = new SqlCommand(query, con, tx))
                                {
                                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmd.Parameters.AddWithValue("@codigo", codigo);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            tx.Commit(); // Confirmar los cambios en la base de datos
                            return true;
                        }
                        catch (Exception exTx)
                        {
                            tx.Rollback(); // Deshacer cambios en caso de fallo
                            MessageBox.Show("Error al actualizar el stock en la BD: " + exTx.Message,
                                            "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos: " + ex.Message,
                                "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

