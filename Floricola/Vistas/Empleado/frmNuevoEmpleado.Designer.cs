namespace Floricola.Vistas.Empleado
{
    partial class frmNuevoEmpleado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCedula = new TextBox();
            label4 = new Label();
            txtNombres = new TextBox();
            label5 = new Label();
            txtApellidos = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtCorreo = new TextBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            label9 = new Label();
            txtCelular = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cmbEstadoCivil = new ComboBox();
            lstEmpleados = new ListBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            chbEstado = new CheckBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            this.btnEditar = new Button();
            this.btnEliminar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(238, 26);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(258, 260);
            label2.Name = "label2";
            label2.Size = new Size(137, 26);
            label2.TabIndex = 1;
            label2.Text = "Estado Civil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 58);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(22, 82);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(215, 35);
            txtCedula.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 125);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 4;
            label4.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(22, 149);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(215, 35);
            txtNombres.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(22, 193);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 6;
            label5.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(22, 217);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(215, 35);
            txtApellidos.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 260);
            label6.Name = "label6";
            label6.Size = new Size(112, 26);
            label6.TabIndex = 8;
            label6.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 284);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(215, 35);
            txtDireccion.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(258, 193);
            label7.Name = "label7";
            label7.Size = new Size(86, 26);
            label7.TabIndex = 10;
            label7.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(258, 217);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(215, 35);
            txtCorreo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(258, 58);
            label8.Name = "label8";
            label8.Size = new Size(98, 26);
            label8.TabIndex = 12;
            label8.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(258, 82);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 35);
            txtTelefono.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(258, 125);
            label9.Name = "label9";
            label9.Size = new Size(90, 26);
            label9.TabIndex = 14;
            label9.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(258, 149);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(215, 35);
            txtCelular.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(22, 371);
            label10.Name = "label10";
            label10.Size = new Size(212, 26);
            label10.TabIndex = 16;
            label10.Text = "Nombre de Usuario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(22, 337);
            label11.Name = "label11";
            label11.Size = new Size(216, 26);
            label11.TabIndex = 17;
            label11.Text = "Gestion de Usuarios";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.Location = new Point(258, 371);
            label12.Name = "label12";
            label12.Size = new Size(130, 26);
            label12.TabIndex = 18;
            label12.Text = "Contraseña";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(258, 289);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(200, 34);
            cmbEstadoCivil.TabIndex = 19;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Items.AddRange(new object[] { "Luis Llerena", "Alexis Vera" });
            lstEmpleados.Location = new Point(490, 81);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(215, 238);
            lstEmpleados.TabIndex = 20;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(20, 410);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 35);
            txtUsuario.TabIndex = 21;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(258, 410);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(200, 35);
            txtContraseña.TabIndex = 22;
            // 
            // chbEstado
            // 
            chbEstado.AutoSize = true;
            chbEstado.Location = new Point(480, 410);
            chbEstado.Name = "chbEstado";
            chbEstado.Size = new Size(225, 30);
            chbEstado.TabIndex = 23;
            chbEstado.Text = "Estado de Usuario";
            chbEstado.UseVisualStyleBackColor = true;
            chbEstado.CheckedChanged += chbEstado_CheckedChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(22, 475);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 50);
            btnNuevo.TabIndex = 24;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(168, 475);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 50);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new Point(309, 475);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(124, 50);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += this.btnEditar_Click;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new Point(449, 475);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(124, 50);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += this.btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(599, 475);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 50);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 565);
            Controls.Add(btnSalir);
            Controls.Add(this.btnEliminar);
            Controls.Add(this.btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(chbEstado);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lstEmpleados);
            Controls.Add(cmbEstadoCivil);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtCelular);
            Controls.Add(label9);
            Controls.Add(txtTelefono);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(txtApellidos);
            Controls.Add(label5);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNuevoEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNuevoEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCedula;
        private Label label4;
        private TextBox txtNombres;
        private Label label5;
        private TextBox txtApellidos;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtCorreo;
        private Label label8;
        private TextBox txtTelefono;
        private Label label9;
        private TextBox txtCelular;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cmbEstadoCivil;
        private ListBox lstEmpleados;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private CheckBox chbEstado;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}