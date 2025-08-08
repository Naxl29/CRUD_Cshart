using System;
using System.Windows.Forms;
using CRUD_Cshart.Controllers;
using CRUD_Cshart.Models;

namespace CRUD_Cshart
{
    // El nombre de la clase ahora es Formulario
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica de carga inicial aquí.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    MessageBox.Show("El primer nombre, primer apellido y número de documento son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Mapear los valores de los ComboBox a los IDs numéricos
                int tipoDocumentoId = ObtenerIdTipoDocumento(cmbTipoDocumento.SelectedItem?.ToString());
                int grupoSanguineoId = ObtenerIdGrupoSanguineo(cmbGrupoSanguineo.SelectedItem?.ToString());
                int factorSanguineoId = ObtenerIdFactorSanguineo(cmbFactorSanguineo.SelectedItem?.ToString());
                int generoId = ObtenerIdGenero(cmbGenero.SelectedItem?.ToString());
                int programaId = ObtenerIdPrograma(txtPrograma.Text);

                // 3. Crear una instancia del objeto Aprendiz
                var nuevoAprendiz = new Aprendiz
                {
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    TipoDocumentoId = tipoDocumentoId,
                    NumeroDocumento = txtNumeroDocumento.Text,
                    GrupoSanguineoId = grupoSanguineoId,
                    FactorSanguineoId = factorSanguineoId,
                    GeneroId = generoId,
                    ProgramaId = programaId
                };

                // 4. Invocar el controlador para guardar el nuevo aprendiz
                var aprendizController = new AprendizController();
                bool exito = aprendizController.CrearAprendiz(nuevoAprendiz);

                // 5. Notificar al usuario y limpiar los campos
                if (exito)
                {
                    MessageBox.Show("El registro se ha agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el registro. Revisa el error en la consola.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtNumeroDocumento.Clear();
            txtPrograma.Clear();

            cmbTipoDocumento.SelectedIndex = -1;
            cmbGrupoSanguineo.SelectedIndex = -1;
            cmbFactorSanguineo.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;

            dtpFechaNacimiento.Value = DateTime.Now;
        }

        // --- Métodos auxiliares para mapear los valores a IDs ---
        // Estos métodos asumen que ya tienes una tabla para cada ComboBox
        // y que los valores de los ComboBox corresponden a IDs.
        private int ObtenerIdTipoDocumento(string tipo)
        {
            switch (tipo)
            {
                case "Cédula de Ciudadanía": return 1;
                case "Tarjeta de Identidad": return 2;
                case "Cédula de Extranjería": return 3;
                case "Pasaporte": return 4;
                default: return 0;
            }
        }

        private int ObtenerIdGrupoSanguineo(string grupo)
        {
            switch (grupo)
            {
                case "A": return 1;
                case "B": return 2;
                case "AB": return 3;
                case "O": return 4;
                default: return 0;
            }
        }

        private int ObtenerIdFactorSanguineo(string factor)
        {
            switch (factor)
            {
                case "+": return 1;
                case "-": return 2;
                default: return 0;
            }
        }

        private int ObtenerIdGenero(string genero)
        {
            switch (genero)
            {
                case "Masculino": return 1;
                case "Femenino": return 2;
                case "Otro": return 3;
                default: return 0;
            }
        }

        // Este método necesita una lógica para obtener el ID del programa
        // Podrías tener una tabla de programas en la BD y obtener el ID a partir del nombre.
        private int ObtenerIdPrograma(string nombrePrograma)
        {
            // Implementa la lógica aquí. Por ahora, un valor fijo
            return 1;
        }

        // Métodos de evento vacíos eliminados para mayor claridad.
    }
}