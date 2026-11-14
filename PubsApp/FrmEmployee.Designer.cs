namespace PubsApp;

partial class FrmEmployee
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

    private void InitializeComponent()
    {
        pnlBotones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnEliminar = new Button();
        btnRecargar = new Button();
        grpDatos = new GroupBox();
        lblId = new Label();
        lblFname = new Label();
        lblMinit = new Label();
        lblLname = new Label();
        lblJob = new Label();
        lblLvl = new Label();
        lblPub = new Label();
        lblHire = new Label();
        txtId = new TextBox();
        txtFname = new TextBox();
        txtMinit = new TextBox();
        txtLname = new TextBox();
        txtJob = new TextBox();
        txtLvl = new TextBox();
        txtPub = new TextBox();
        dtpHire = new DateTimePicker();
        dgv = new DataGridView();
        pnlBotones.SuspendLayout();
        grpDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // pnlBotones
        pnlBotones.Controls.Add(btnNuevo);
        pnlBotones.Controls.Add(btnGuardar);
        pnlBotones.Controls.Add(btnEliminar);
        pnlBotones.Controls.Add(btnRecargar);
        pnlBotones.Dock = DockStyle.Top;
        pnlBotones.Name = "pnlBotones";
        pnlBotones.Size = new Size(940, 55);
        // btnNuevo
        btnNuevo.Location = new Point(15, 10);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(110, 36);
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = true;
        btnNuevo.Click += btnNuevo_Click;
        // btnGuardar
        btnGuardar.Location = new Point(135, 10);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(110, 36);
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // btnEliminar
        btnEliminar.Location = new Point(255, 10);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(110, 36);
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // btnRecargar
        btnRecargar.Location = new Point(375, 10);
        btnRecargar.Name = "btnRecargar";
        btnRecargar.Size = new Size(110, 36);
        btnRecargar.Text = "Recargar";
        btnRecargar.UseVisualStyleBackColor = true;
        btnRecargar.Click += btnRecargar_Click;
        // grpDatos
        grpDatos.Controls.Add(lblId);
        grpDatos.Controls.Add(lblFname);
        grpDatos.Controls.Add(lblMinit);
        grpDatos.Controls.Add(lblLname);
        grpDatos.Controls.Add(lblJob);
        grpDatos.Controls.Add(lblLvl);
        grpDatos.Controls.Add(lblPub);
        grpDatos.Controls.Add(lblHire);
        grpDatos.Controls.Add(txtId);
        grpDatos.Controls.Add(txtFname);
        grpDatos.Controls.Add(txtMinit);
        grpDatos.Controls.Add(txtLname);
        grpDatos.Controls.Add(txtJob);
        grpDatos.Controls.Add(txtLvl);
        grpDatos.Controls.Add(txtPub);
        grpDatos.Controls.Add(dtpHire);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 160);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del empleado";
        // labels fila 1
        lblId.AutoSize = true;
        lblId.Location = new Point(15, 28);
        lblId.Name = "lblId";
        lblId.Text = "emp_id";
        lblFname.AutoSize = true;
        lblFname.Location = new Point(150, 28);
        lblFname.Name = "lblFname";
        lblFname.Text = "fname";
        lblMinit.AutoSize = true;
        lblMinit.Location = new Point(315, 28);
        lblMinit.Name = "lblMinit";
        lblMinit.Text = "minit";
        lblLname.AutoSize = true;
        lblLname.Location = new Point(390, 28);
        lblLname.Name = "lblLname";
        lblLname.Text = "lname";
        // labels fila 2
        lblJob.AutoSize = true;
        lblJob.Location = new Point(15, 88);
        lblJob.Name = "lblJob";
        lblJob.Text = "job_id";
        lblLvl.AutoSize = true;
        lblLvl.Location = new Point(150, 88);
        lblLvl.Name = "lblLvl";
        lblLvl.Text = "job_lvl";
        lblPub.AutoSize = true;
        lblPub.Location = new Point(285, 88);
        lblPub.Name = "lblPub";
        lblPub.Text = "pub_id";
        lblHire.AutoSize = true;
        lblHire.Location = new Point(420, 88);
        lblHire.Name = "lblHire";
        lblHire.Text = "hire_date";
        // textboxes fila 1
        txtId.Location = new Point(15, 48);
        txtId.MaxLength = 9;
        txtId.Name = "txtId";
        txtId.Size = new Size(120, 23);
        txtId.TabIndex = 0;
        txtFname.Location = new Point(150, 48);
        txtFname.MaxLength = 20;
        txtFname.Name = "txtFname";
        txtFname.Size = new Size(150, 23);
        txtFname.TabIndex = 1;
        txtMinit.Location = new Point(315, 48);
        txtMinit.MaxLength = 1;
        txtMinit.Name = "txtMinit";
        txtMinit.Size = new Size(60, 23);
        txtMinit.TabIndex = 2;
        txtLname.Location = new Point(390, 48);
        txtLname.MaxLength = 30;
        txtLname.Name = "txtLname";
        txtLname.Size = new Size(170, 23);
        txtLname.TabIndex = 3;
        // fila 2
        txtJob.Location = new Point(15, 108);
        txtJob.Name = "txtJob";
        txtJob.Size = new Size(120, 23);
        txtJob.TabIndex = 4;
        txtLvl.Location = new Point(150, 108);
        txtLvl.Name = "txtLvl";
        txtLvl.Size = new Size(120, 23);
        txtLvl.TabIndex = 5;
        txtPub.Location = new Point(285, 108);
        txtPub.MaxLength = 4;
        txtPub.Name = "txtPub";
        txtPub.Size = new Size(120, 23);
        txtPub.TabIndex = 6;
        dtpHire.Format = DateTimePickerFormat.Short;
        dtpHire.Location = new Point(420, 108);
        dtpHire.Name = "dtpHire";
        dtpHire.Size = new Size(200, 23);
        dtpHire.TabIndex = 7;
        // dgv
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.Dock = DockStyle.Fill;
        dgv.Name = "dgv";
        dgv.ReadOnly = true;
        dgv.RowHeadersVisible = false;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.SelectionChanged += dgv_SelectionChanged;
        // FrmEmployee
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(760, 450);
        Name = "FrmEmployee";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: employee";
        Load += FrmEmployee_Load;
        pnlBotones.ResumeLayout(false);
        grpDatos.ResumeLayout(false);
        grpDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }

    private Panel pnlBotones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnRecargar;
    private GroupBox grpDatos;
    private Label lblId;
    private Label lblFname;
    private Label lblMinit;
    private Label lblLname;
    private Label lblJob;
    private Label lblLvl;
    private Label lblPub;
    private Label lblHire;
    private TextBox txtId;
    private TextBox txtFname;
    private TextBox txtMinit;
    private TextBox txtLname;
    private TextBox txtJob;
    private TextBox txtLvl;
    private TextBox txtPub;
    private DateTimePicker dtpHire;
    private DataGridView dgv;
}