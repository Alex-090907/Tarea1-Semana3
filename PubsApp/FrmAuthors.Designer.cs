namespace PubsApp;

partial class FrmAuthors
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
        lblAuId = new Label();
        lblLname = new Label();
        lblFname = new Label();
        lblPhone = new Label();
        lblAddress = new Label();
        lblCity = new Label();
        lblState = new Label();
        lblZip = new Label();
        txtAuId = new TextBox();
        txtLname = new TextBox();
        txtFname = new TextBox();
        txtPhone = new TextBox();
        txtAddress = new TextBox();
        txtCity = new TextBox();
        txtState = new TextBox();
        txtZip = new TextBox();
        chkContract = new CheckBox();
        dgv = new DataGridView();
        pnlBotones.SuspendLayout();
        grpDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // pnlBotones
        // 
        pnlBotones.Controls.Add(btnNuevo);
        pnlBotones.Controls.Add(btnGuardar);
        pnlBotones.Controls.Add(btnEliminar);
        pnlBotones.Controls.Add(btnRecargar);
        pnlBotones.Dock = DockStyle.Top;
        pnlBotones.Name = "pnlBotones";
        pnlBotones.Size = new Size(940, 55);
        // 
        // btnNuevo
        // 
        btnNuevo.Location = new Point(15, 10);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(110, 36);
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = true;
        btnNuevo.Click += btnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(135, 10);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(110, 36);
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new Point(255, 10);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(110, 36);
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnRecargar
        // 
        btnRecargar.Location = new Point(375, 10);
        btnRecargar.Name = "btnRecargar";
        btnRecargar.Size = new Size(110, 36);
        btnRecargar.Text = "Recargar";
        btnRecargar.UseVisualStyleBackColor = true;
        btnRecargar.Click += btnRecargar_Click;
        // 
        // grpDatos
        // 
        grpDatos.Controls.Add(lblAuId);
        grpDatos.Controls.Add(lblLname);
        grpDatos.Controls.Add(lblFname);
        grpDatos.Controls.Add(lblPhone);
        grpDatos.Controls.Add(lblAddress);
        grpDatos.Controls.Add(lblCity);
        grpDatos.Controls.Add(lblState);
        grpDatos.Controls.Add(lblZip);
        grpDatos.Controls.Add(txtAuId);
        grpDatos.Controls.Add(txtLname);
        grpDatos.Controls.Add(txtFname);
        grpDatos.Controls.Add(txtPhone);
        grpDatos.Controls.Add(txtAddress);
        grpDatos.Controls.Add(txtCity);
        grpDatos.Controls.Add(txtState);
        grpDatos.Controls.Add(txtZip);
        grpDatos.Controls.Add(chkContract);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 160);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del autor";
        // 
        // Labels fila 1
        // 
        lblAuId.AutoSize = true;
        lblAuId.Location = new Point(15, 28);
        lblAuId.Name = "lblAuId";
        lblAuId.Text = "au_id";
        lblLname.AutoSize = true;
        lblLname.Location = new Point(190, 28);
        lblLname.Name = "lblLname";
        lblLname.Text = "au_lname";
        lblFname.AutoSize = true;
        lblFname.Location = new Point(365, 28);
        lblFname.Name = "lblFname";
        lblFname.Text = "au_fname";
        lblPhone.AutoSize = true;
        lblPhone.Location = new Point(540, 28);
        lblPhone.Name = "lblPhone";
        lblPhone.Text = "phone";
        // 
        // Labels fila 2
        // 
        lblAddress.AutoSize = true;
        lblAddress.Location = new Point(15, 88);
        lblAddress.Name = "lblAddress";
        lblAddress.Text = "address";
        lblCity.AutoSize = true;
        lblCity.Location = new Point(190, 88);
        lblCity.Name = "lblCity";
        lblCity.Text = "city";
        lblState.AutoSize = true;
        lblState.Location = new Point(365, 88);
        lblState.Name = "lblState";
        lblState.Text = "state";
        lblZip.AutoSize = true;
        lblZip.Location = new Point(540, 88);
        lblZip.Name = "lblZip";
        lblZip.Text = "zip";
        // 
        // TextBox fila 1
        // 
        txtAuId.Location = new Point(15, 48);
        txtAuId.MaxLength = 11;
        txtAuId.Name = "txtAuId";
        txtAuId.Size = new Size(160, 23);
        txtAuId.TabIndex = 0;
        txtLname.Location = new Point(190, 48);
        txtLname.MaxLength = 40;
        txtLname.Name = "txtLname";
        txtLname.Size = new Size(160, 23);
        txtLname.TabIndex = 1;
        txtFname.Location = new Point(365, 48);
        txtFname.MaxLength = 20;
        txtFname.Name = "txtFname";
        txtFname.Size = new Size(160, 23);
        txtFname.TabIndex = 2;
        txtPhone.Location = new Point(540, 48);
        txtPhone.MaxLength = 12;
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(160, 23);
        txtPhone.TabIndex = 3;
        // 
        // TextBox fila 2
        // 
        txtAddress.Location = new Point(15, 108);
        txtAddress.MaxLength = 40;
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(160, 23);
        txtAddress.TabIndex = 4;
        txtCity.Location = new Point(190, 108);
        txtCity.MaxLength = 20;
        txtCity.Name = "txtCity";
        txtCity.Size = new Size(160, 23);
        txtCity.TabIndex = 5;
        txtState.Location = new Point(365, 108);
        txtState.MaxLength = 2;
        txtState.Name = "txtState";
        txtState.Size = new Size(160, 23);
        txtState.TabIndex = 6;
        txtZip.Location = new Point(540, 108);
        txtZip.MaxLength = 5;
        txtZip.Name = "txtZip";
        txtZip.Size = new Size(160, 23);
        txtZip.TabIndex = 7;
        // 
        // chkContract
        // 
        chkContract.AutoSize = true;
        chkContract.Location = new Point(720, 110);
        chkContract.Name = "chkContract";
        chkContract.TabIndex = 8;
        chkContract.Text = "contract";
        chkContract.UseVisualStyleBackColor = true;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.Dock = DockStyle.Fill;
        dgv.Name = "dgv";
        dgv.ReadOnly = true;
        dgv.RowHeadersVisible = false;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.SelectionChanged += dgv_SelectionChanged;
        // 
        // FrmAuthors
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(760, 450);
        Name = "FrmAuthors";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: authors";
        Load += FrmAuthors_Load;
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
    private Label lblAuId;
    private Label lblLname;
    private Label lblFname;
    private Label lblPhone;
    private Label lblAddress;
    private Label lblCity;
    private Label lblState;
    private Label lblZip;
    private TextBox txtAuId;
    private TextBox txtLname;
    private TextBox txtFname;
    private TextBox txtPhone;
    private TextBox txtAddress;
    private TextBox txtCity;
    private TextBox txtState;
    private TextBox txtZip;
    private CheckBox chkContract;
    private DataGridView dgv;
}