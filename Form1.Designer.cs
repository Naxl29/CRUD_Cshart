namespace CRUD_Cshart
{
    partial class Formulario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            lblPrimerNombre = new Label();
            lblSegundoNombre = new Label();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            txtPrimerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            lblfecha = new Label();
            lblTipoDocumento = new Label();
            lblNumeroDocumento = new Label();
            lblGrupoSanguineo = new Label();
            lblFactorSanguineo = new Label();
            lblGenero = new Label();
            lblPrograma = new Label();
            txtNumeroDocumento = new TextBox();
            cmbTipoDocumento = new ComboBox();
            cmbGrupoSanguineo = new ComboBox();
            cmbFactorSanguineo = new ComboBox();
            cmbGenero = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbPrograma = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(49, 22);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(89, 15);
            lblPrimerNombre.TabIndex = 2;
            lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(49, 62);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(101, 15);
            lblSegundoNombre.TabIndex = 3;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(49, 103);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(89, 15);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(49, 140);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 5;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(186, 19);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(114, 23);
            txtPrimerNombre.TabIndex = 6;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(186, 59);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(114, 23);
            txtSegundoNombre.TabIndex = 7;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(186, 95);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(114, 23);
            txtPrimerApellido.TabIndex = 8;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(186, 132);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(114, 23);
            txtSegundoApellido.TabIndex = 9;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Location = new Point(49, 171);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(119, 15);
            lblfecha.TabIndex = 10;
            lblfecha.Text = "Fecha de Nacimiento";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(49, 202);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(112, 15);
            lblTipoDocumento.TabIndex = 11;
            lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(47, 237);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(133, 15);
            lblNumeroDocumento.TabIndex = 12;
            lblNumeroDocumento.Text = "Número de Documento";
            // 
            // lblGrupoSanguineo
            // 
            lblGrupoSanguineo.AutoSize = true;
            lblGrupoSanguineo.Location = new Point(49, 271);
            lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            lblGrupoSanguineo.Size = new Size(99, 15);
            lblGrupoSanguineo.TabIndex = 13;
            lblGrupoSanguineo.Text = "Grupo Sanguíneo";
            // 
            // lblFactorSanguineo
            // 
            lblFactorSanguineo.AutoSize = true;
            lblFactorSanguineo.Location = new Point(49, 303);
            lblFactorSanguineo.Name = "lblFactorSanguineo";
            lblFactorSanguineo.Size = new Size(99, 15);
            lblFactorSanguineo.TabIndex = 14;
            lblFactorSanguineo.Text = "Factor Sanguíneo";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(49, 334);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 15;
            lblGenero.Text = "Género";
            // 
            // lblPrograma
            // 
            lblPrograma.AutoSize = true;
            lblPrograma.Location = new Point(49, 365);
            lblPrograma.Name = "lblPrograma";
            lblPrograma.Size = new Size(59, 15);
            lblPrograma.TabIndex = 16;
            lblPrograma.Text = "Programa";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(186, 234);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(114, 23);
            txtNumeroDocumento.TabIndex = 19;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(186, 202);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(114, 23);
            cmbTipoDocumento.TabIndex = 24;
            // 
            // cmbGrupoSanguineo
            // 
            cmbGrupoSanguineo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupoSanguineo.FormattingEnabled = true;
            cmbGrupoSanguineo.Location = new Point(186, 271);
            cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            cmbGrupoSanguineo.Size = new Size(114, 23);
            cmbGrupoSanguineo.TabIndex = 25;
            // 
            // cmbFactorSanguineo
            // 
            cmbFactorSanguineo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFactorSanguineo.FormattingEnabled = true;
            cmbFactorSanguineo.Location = new Point(186, 300);
            cmbFactorSanguineo.Name = "cmbFactorSanguineo";
            cmbFactorSanguineo.Size = new Size(114, 23);
            cmbFactorSanguineo.TabIndex = 26;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(186, 331);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(114, 23);
            cmbGenero.TabIndex = 27;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(186, 171);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(114, 23);
            dtpFechaNacimiento.TabIndex = 28;
            // 
            // cmbPrograma
            // 
            cmbPrograma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrograma.FormattingEnabled = true;
            cmbPrograma.Location = new Point(186, 362);
            cmbPrograma.Name = "cmbPrograma";
            cmbPrograma.Size = new Size(114, 23);
            cmbPrograma.TabIndex = 29;

            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPrograma);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cmbGenero);
            Controls.Add(cmbFactorSanguineo);
            Controls.Add(cmbGrupoSanguineo);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblPrograma);
            Controls.Add(lblGenero);
            Controls.Add(lblFactorSanguineo);
            Controls.Add(lblGrupoSanguineo);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(lblfecha);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtSegundoNombre);
            Controls.Add(txtPrimerNombre);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblSegundoNombre);
            Controls.Add(lblPrimerNombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Formulario";
            Text = "Formulario";
            Load += Formulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label lblPrimerNombre;
        private Label lblSegundoNombre;
        private Label lblPrimerApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerNombre;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label lblfecha;
        private Label lblTipoDocumento;
        private Label lblNumeroDocumento;
        private Label lblGrupoSanguineo;
        private Label lblFactorSanguineo;
        private Label lblGenero;
        private Label lblPrograma;
        private TextBox txtNumeroDocumento;
        private ComboBox cmbTipoDocumento;
        private ComboBox cmbGrupoSanguineo;
        private ComboBox cmbFactorSanguineo;
        private ComboBox cmbGenero;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbPrograma;
    }
}