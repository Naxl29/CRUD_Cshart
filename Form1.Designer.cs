namespace CRUD_Cshart
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            lblPrimerNombre = new Label();
            lblSegundoNombre = new Label();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            fontDialog1 = new FontDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtPrimerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            lblfecha = new Label();
            label = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNumeroDocumento = new TextBox();
            txtPrograma = new TextBox();
            toolTip1 = new ToolTip(components);
            cmbTipoDocumento = new ComboBox();
            cmbGrupoSanguineo = new ComboBox();
            cmbFactorSanguineo = new ComboBox();
            cmbGenero = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
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
            lblPrimerNombre.Click += label1_Click;
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
            lblPrimerApellido.Click += label3_Click;
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
            lblfecha.Click += label1_Click_1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(49, 202);
            label.Name = "label";
            label.Size = new Size(112, 15);
            label.TabIndex = 11;
            label.Text = "Tipo de Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 237);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 12;
            label3.Text = "Número de Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 271);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 13;
            label4.Text = "Grupo Sanguíneo";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 303);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 14;
            label5.Text = "Factor Sanguíneo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 334);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 15;
            label6.Text = "Género";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 365);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 16;
            label7.Text = "Programa";
            label7.Click += label7_Click;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(186, 234);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(114, 23);
            txtNumeroDocumento.TabIndex = 19;
            // 
            // txtPrograma
            // 
            txtPrograma.Location = new Point(186, 365);
            txtPrograma.Name = "txtPrograma";
            txtPrograma.Size = new Size(114, 23);
            txtPrograma.TabIndex = 23;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "Cédula de Ciudadanía", "Tarjeta de Identidad", "Cédula de Extranjería", "Pasaporte", "Otro" });
            cmbTipoDocumento.Location = new Point(186, 202);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(114, 23);
            cmbTipoDocumento.TabIndex = 24;
            // 
            // cmbGrupoSanguineo
            // 
            cmbGrupoSanguineo.FormattingEnabled = true;
            cmbGrupoSanguineo.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbGrupoSanguineo.Location = new Point(186, 271);
            cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            cmbGrupoSanguineo.Size = new Size(114, 23);
            cmbGrupoSanguineo.TabIndex = 25;
            // 
            // cmbFactorSanguineo
            // 
            cmbFactorSanguineo.FormattingEnabled = true;
            cmbFactorSanguineo.Items.AddRange(new object[] { "+", "-" });
            cmbFactorSanguineo.Location = new Point(186, 300);
            cmbFactorSanguineo.Name = "cmbFactorSanguineo";
            cmbFactorSanguineo.Size = new Size(114, 23);
            cmbFactorSanguineo.TabIndex = 26;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
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
            dtpFechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cmbGenero);
            Controls.Add(cmbFactorSanguineo);
            Controls.Add(cmbGrupoSanguineo);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(txtPrograma);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label);
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
            Text = "Formulario Aprendices";
            Load += Form1_Load;
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
        private FontDialog fontDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtPrimerNombre;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label lblfecha;
        private Label label;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNumeroDocumento;
        private TextBox txtPrograma;
        private ToolTip toolTip1;
        private ComboBox cmbTipoDocumento;
        private ComboBox cmbGrupoSanguineo;
        private ComboBox cmbFactorSanguineo;
        private ComboBox cmbGenero;
        private DateTimePicker dtpFechaNacimiento;
    }
}