using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMPORTADORAPOO
{
    public partial class FormCalculoValores : Form
    {
        
        private List<ProductoImportado> listaImportacion;
        private GestorImportacion gestor = new GestorImportacion();

        public FormCalculoValores()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        
        private void FormCalculoValores_Load(object sender, EventArgs e)
        {
            listaImportacion = gestor.ObtenerFacturaProveedor();
            ActualizarTabla();
        }

        
        private void ActualizarTabla()
        {
            dgvProrrateo.DataSource = null;
            dgvProrrateo.DataSource = listaImportacion;
        }

       
        private void btnCalcularCostos_Click(object sender, EventArgs e)
        {
            decimal totalFob = nudFOB.Value;

            // Validación
            if (totalFob <= 0)
            {
                MessageBox.Show("El Valor FOB de la mercadería no puede ser cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            decimal totalGastos = nudFlete.Value + nudSeguro.Value + nudAduana.Value;
            gestor.EjecutarProrrateo(listaImportacion, totalFob, totalGastos);

            ActualizarTabla();
            MessageBox.Show("Cálculos realizados correctamente. Revisa la columna de Costo Real.", "Prorrateo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnGuardarImportacion_Click(object sender, EventArgs e)
        {
          
            if (listaImportacion == null || listaImportacion.Count == 0 || listaImportacion[0].CostoReal == 0)
            {
                MessageBox.Show("Por favor, primero calcule los costos (Botón Azul) antes de actualizar el inventario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            gestor.SimularGuardadoEnBaseDeDatos(listaImportacion);

            MessageBox.Show("¡Inventario y Precios actualizados con éxito en el sistema!", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            nudFOB.Value = 0;
            nudFlete.Value = 0;
            nudSeguro.Value = 0;
            nudAduana.Value = 0;

            
            listaImportacion = gestor.ObtenerFacturaProveedor();
            ActualizarTabla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}