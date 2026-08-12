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
    public partial class Sesion : Form
    {
        public static string UsuarioActual; // Propiedad para almacenar el usuario actual
        // CONSTRUCTOR: Carga y dibuja los controles del diseñador
        public Sesion()
        {
            InitializeComponent();
        }

        private void Sesion_Load(object sender, EventArgs e)
        {
            UsuarioActual = txtUsuario.Text; // Asigna el valor del TextBox a la propiedad estática
        }

        private void picSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "SELECT ID_Rol FROM Usuarios WHERE Username = @user AND Password_Hash = @pass AND Activo = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim()); // Consulta parametrizada (evita inyección SQL)

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int idRol = Convert.ToInt32(result);
                        MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir el formulario Principal / Dashboard
                        // Dashboard mainForm = new Dashboard();
                        // mainForm.Show();
                        // this.Hide();
                        /// Oculta la ventana de inicio de sesión actual
                        //this.Hide();

                        // Abre el menú principal
                        frmmenuinicio menuPrincipal = new frmmenuinicio(txtUsuario.Text);

                        // Si el usuario cierra el menú principal, se finaliza toda la aplicación
                        menuPrincipal.FormClosed += (s, args) => this.Close();

                        menuPrincipal.Show();// Validar que las cajas de texto no estén vacías
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOjito_Click(object sender, EventArgs e)
        {
            // Si actualmente está oculta con puntos
            if (txtContraseña.UseSystemPasswordChar)
            {
               
                txtContraseña.UseSystemPasswordChar = false; // Muestra el texto plano
                btnOjito.BackgroundImage = IMPORTADORAPOO.Properties.Resources.leer;
                btnOjito.BackgroundImageLayout = ImageLayout.Stretch;

                ; // O cambia la imagen del botón
            }
            else
            {
               
                txtContraseña.UseSystemPasswordChar = true;  // Vuelve a ocultar con puntos
                btnOjito.BackgroundImage= IMPORTADORAPOO.Properties.Resources.ojo;
                btnOjito.BackgroundImageLayout = ImageLayout.Stretch;
                // O cambia la imagen del botón
            }
        }

        private void picCandado_Click(object sender, EventArgs e)
        {

        }
    }
}                                                                                                                                                  