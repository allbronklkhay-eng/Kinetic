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
    public partial class frmmenuinicio : Form
    {
        // Variable para controlar el formulario que está abierto actualmente en el panel
        private Form formularioActivo = null;

        public frmmenuinicio()
        {
            InitializeComponent();
        }
        public frmmenuinicio(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario; // Asigna el nombre del usuario al TextBox
        }
        // Método encargado de cargar cualquier formulario dentro de pnlContenedor
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Si ya hay un formulario abierto, lo cerramos para liberar memoria
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;

            // Ajustes para que se adapte al panel sin bordes ni barra superior propia
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Limpiamos e insertamos el nuevo formulario
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;

            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            menuNotificaciones.Show(btnNotificacion, new Point(0, btnNotificacion.Height));
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            menuConfiguracion.Show(btnConfig, new Point(0, btnConfig.Height));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Abre el formulario menu dentro del panel
            AbrirFormularioEnPanel(new menu());
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Facturación dentro del panel
            AbrirFormularioEnPanel(new frmFacturcion());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Inventario dentro del panel
            AbrirFormularioEnPanel(new Inventario());
        }

        private void frmmenuinicio_Load(object sender, EventArgs e)
        {
            // Al abrir la aplicación, carga automáticamente el formulario menu dentro del panel
            AbrirFormularioEnPanel(new menu());
           ; // Muestra el nombre del usuario actual
        }

    
    }
}