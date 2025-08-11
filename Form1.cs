using System;
using System.Windows.Forms;
using CRUD_Cshart.Controllers;
using CRUD_Cshart.Models;
using System.Linq;

namespace CRUD_Cshart
{
    public partial class Formulario : Form
    {
        private AprendizController aprendizController = new AprendizController();

        public Formulario()
        {
            InitializeComponent();
            CargarComboBoxes();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
        }

        private void CargarComboBoxes()
        {
            try
            {
                // Se cargan los tipos de documento
                var tiposDocumento = aprendizController.ObtenerTiposDeDocumento()
                    .Select(x => new { Value = x.id, Text = x.nombre }).ToList();
                cmbTipoDocumento.DisplayMember = "Text";
                cmbTipoDocumento.ValueMember = "Value";
                cmbTipoDocumento.DataSource = tiposDocumento;
                cmbTipoDocumento.SelectedIndex = -1;

                // Se cargan los géneros
                var generos = aprendizController.ObtenerGeneros()
                    .Select(x => new { Value = x.id, Text = x.nombre }).ToList();
                cmbGenero.DisplayMember = "Text";
                cmbGenero.ValueMember = "Value";
                cmbGenero.DataSource = generos;
                cmbGenero.SelectedIndex = -1; 

                // Se cargan los grupos sanguíneos
                var gruposSanguineos = aprendizController.ObtenerGruposSanguineos()
                    .Select(x => new { Value = x.id, Text = x.nombre }).ToList();
                cmbGrupoSanguineo.DisplayMember = "Text";
                cmbGrupoSanguineo.ValueMember = "Value";
                cmbGrupoSanguineo.DataSource = gruposSanguineos;
                cmbGrupoSanguineo.SelectedIndex = -1; 

                // Se cargan los factores sanguíneos
                var factoresSanguineos = aprendizController.ObtenerFactoresSanguineos()
                    .Select(x => new { Value = x.id, Text = x.nombre }).ToList();
                cmbFactorSanguineo.DisplayMember = "Text";
                cmbFactorSanguineo.ValueMember = "Value";
                cmbFactorSanguineo.DataSource = factoresSanguineos;
                cmbFactorSanguineo.SelectedIndex = -1; 

                // Se cargan los programas
                var programas = aprendizController.ObtenerProgramas()
                    .Select(x => new { Value = x.id, Text = x.nombre }).ToList();
                cmbPrograma.DisplayMember = "Text";
                cmbPrograma.ValueMember = "Value";
                cmbPrograma.DataSource = programas;
                cmbPrograma.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   // Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                    cmbTipoDocumento.SelectedValue == null ||
                    cmbGenero.SelectedValue == null ||
                    cmbGrupoSanguineo.SelectedValue == null ||
                    cmbFactorSanguineo.SelectedValue == null ||
                    cmbPrograma.SelectedValue == null)
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor complete toda la información.",
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevoAprendiz = new Aprendiz
                {
                    PrimerNombre = txtPrimerNombre.Text.Trim(),
                    SegundoNombre = txtSegundoNombre.Text.Trim(),
                    PrimerApellido = txtPrimerApellido.Text.Trim(),
                    SegundoApellido = txtSegundoApellido.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    TipoDocumentoId = (int)cmbTipoDocumento.SelectedValue,
                    NumeroDocumento = txtNumeroDocumento.Text.Trim(),
                    GrupoSanguineoId = (int)cmbGrupoSanguineo.SelectedValue,
                    FactorSanguineoId = (int)cmbFactorSanguineo.SelectedValue,
                    GeneroId = (int)cmbGenero.SelectedValue,
                    ProgramaId = (int)cmbPrograma.SelectedValue
                };

                bool exito = aprendizController.CrearAprendiz(nuevoAprendiz);

                if (exito)
                {
                    MessageBox.Show("El registro se ha agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            // Se limpian los campos de texto
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtNumeroDocumento.Clear();

            // Se limpian los ComboBoxes
            cmbTipoDocumento.SelectedIndex = -1;
            cmbGrupoSanguineo.SelectedIndex = -1;
            cmbFactorSanguineo.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbPrograma.SelectedIndex = -1;

            dtpFechaNacimiento.Value = DateTime.Now;

            txtPrimerNombre.Focus();
        }
    }
}