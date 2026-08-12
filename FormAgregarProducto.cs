using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IMPORTADORAPOO
{
    public class FormAgregarProducto : Form
    {
        // Controles del formulario
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStock;
        private ComboBox cmbCategoria;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCancelar;
        private int idProducto = 0;
        public FormAgregarProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public FormAgregarProducto(int idProductoAEditar)
        {
            InitializeComponent();
            this.idProducto = idProductoAEditar;
        }
    
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(45, 104);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(260, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(45, 157);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(45, 212);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 2;
            this.nudPrecio.ThousandsSeparator = true;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(185, 212);
            this.nudStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(120, 20);
            this.nudStock.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Location = new System.Drawing.Point(45, 266);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(260, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
            "En Stock",
            "Crítico",
            "Agotado"});
            this.cmbEstado.Location = new System.Drawing.Point(45, 320);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(260, 21);
            this.cmbEstado.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(45, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(185, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "Agregar Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(42, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio U";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(182, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(42, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(42, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado";
            // 
            // FormAgregarProducto
            // 
            this.BackgroundImage = global::IMPORTADORAPOO.Properties.Resources.WhatsApp_Image_2026_07_22_at_9_33_59_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 432);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Evento Load: carga las categorías activas desde la tabla Categorias
        /// </summary>
      

        /// <summary>
        /// Botón Cancelar: cierra el formulario sin guardar
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Botón Guardar: valida y realiza INSERT parametrizado en Productos
        /// </summary>

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT ID_Categoria, Nombre_Categoria FROM Categorias";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // ¡CLAVE!: Definir DisplayMember y ValueMember ANTES del DataSource
                            cmbCategoria.DisplayMember = "Nombre_Categoria"; // Texto que ve el usuario
                            cmbCategoria.ValueMember = "ID_Categoria";     // ID interno que se guarda
                            cmbCategoria.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron categorías registradas en la base de datos.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías desde la BD: " + ex.Message,
                                "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarDatosProducto()
        {
            try
                {
                    using (SqlConnection conn = Conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string sql = @"SELECT Codigo, Descripcion, Precio, Stock, ID_Categoria, Estado 
                           FROM Productos 
                           WHERE ID_Producto = @id";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", this.idProducto);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Cargar campos de texto y números
                                    txtCodigo.Text = reader["Codigo"].ToString();
                                    txtDescripcion.Text = reader["Descripcion"].ToString();
                                    nudPrecio.Value = Convert.ToDecimal(reader["Precio"]);
                                    nudStock.Value = Convert.ToDecimal(reader["Stock"]);

                                    // Seleccionar la Categoría guardada en la BD
                                    if (reader["ID_Categoria"] != DBNull.Value)
                                    {
                                        cmbCategoria.SelectedValue = Convert.ToInt32(reader["ID_Categoria"]);
                                    }

                                    // Seleccionar el Estado guardado
                                    if (reader["Estado"] != DBNull.Value)
                                    {
                                        cmbEstado.SelectedItem = reader["Estado"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos del producto: " + ex.Message,
                                    "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

    
       //  Constructor 2: MODO EDITAR(Recibe el ID del producto seleccionado)
      
      

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Validaciones
            string codigo = txtCodigo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            decimal precio = nudPrecio.Value;
            int stock = (int)nudStock.Value;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("El código y la descripción son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCat = Convert.ToInt32(cmbCategoria.SelectedValue);
            string estado = cmbEstado.SelectedItem?.ToString() ?? "En Stock";

            // Consulta dinámica: INSERT si idProducto es 0, UPDATE si idProducto > 0
            string sql = "";
            if (this.idProducto == 0)
            {
                sql = "INSERT INTO Productos (Codigo, Descripcion, Precio, Stock, ID_Categoria, Estado, Activo) " +
                      "VALUES (@codigo, @descripcion, @precio, @stock, @idCat, @estado, 1)";
            }
            else
            {
                sql = "UPDATE Productos SET Descripcion = @descripcion, Precio = @precio, " +
                      "ID_Categoria = @idCat, Estado = @estado WHERE ID_Producto = @id";
            }

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@idCat", idCat);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    if (this.idProducto == 0)
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@stock", stock);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id", this.idProducto);
                    }

                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        string mensaje = (this.idProducto == 0) ? "Producto registrado correctamente." : "Producto actualizado correctamente.";
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            // 1. Cargar el ComboBox de Categorías
            // Primero cargamos la lista de categorías en el ComboBox
            CargarCategorias();

            // Si idProducto es mayor a 0, significa que se abrió en MODO EDITAR
            if (this.idProducto > 0)
            {
                // Cambiar títulos de la ventana y de la barra superior azul
                this.Text = "Editar Producto";
                label2.Text = "Editar Producto";
                btnGuardar.Text = "Actualizar";

                // Bloquear los campos que no deben modificarse
                txtCodigo.Enabled = false;
                nudStock.Enabled = false;

                // Cargar los datos del producto seleccionado desde SQL Server
                CargarDatosProducto();
            }
            else
            {
                // MODO AGREGAR (por defecto)
                this.Text = "Agregar Producto";
                label2.Text = "Agregar Producto";
                btnGuardar.Text = "Guardar";

                txtCodigo.Enabled = true;
                nudStock.Enabled = true;
            }
        }
    }
}

