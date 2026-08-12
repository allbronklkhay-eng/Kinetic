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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarTablaProductos();
        }
        public void CargarTablaProductos()
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open(); // Abre el canal de comunicación

                    // Consulta con INNER JOIN para traer el nombre de la categoría en lugar del ID
                    // Tu consulta SQL debe incluir ID_Producto al inicio
                    string query = "SELECT ID_Producto, Codigo, Descripcion, Precio, Stock, Estado FROM Productos WHERE Activo = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Llena la tabla temporal con los datos de SQL

                    // Asigna los datos a tu DataGridView (asegúrate de que se llame dgvInventario o cámbialo por el tuyo)
                    dgvInventario.DataSource = dt;
                

                    // Ocultar la columna del ID para que el usuario no la vea en pantalla
                    if (dgvInventario.Columns.Contains("ID_Producto"))
                    {
                        dgvInventario.Columns["ID_Producto"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarProducto AgregarProducto = new FormAgregarProducto();
            AgregarProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.Index >= 0)
            {
                // 2. Obtener el ID_Producto directamente del valor de la celda en la fila actual
                // (Asegúrate de que la columna se llame "ID_Producto" o usa el número de columna, ej. Cells[0])
                int idProducto = Convert.ToInt32(dgvInventario.CurrentRow.Cells["ID_Producto"].Value);

                // 3. Abrir el formulario en modo edición pasando el ID
                FormAgregarProducto frm = new FormAgregarProducto(idProducto);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarTablaProductos(); // Recarga la grilla
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
