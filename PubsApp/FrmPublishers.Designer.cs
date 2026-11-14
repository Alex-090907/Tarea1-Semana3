namespace PubsApp;

partial class FrmPublishers
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
        lblPubId = new Label();
        lblName = new Label();
        lblCity = new Label();
        lblState = new Label();
        lblCountry = new Label();
        txtPubId = new TextBox();
        txtName = new TextBox();
        txtCity = new TextBox();
        txtState = new TextBox();
        txtCountry = new TextBox();
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
        grpDatos.Controls.Add(lblPubId);
        grpDatos.Controls.Add(lblName);
        grpDatos.Controls.Add(lblCity);
        grpDatos.Controls.Add(lblState);
        grpDatos.Controls.Add(lblCountry);
        grpDatos.Controls.Add(txtPubId);
        grpDatos.Controls.Add(txtName);
        grpDatos.Controls.Add(txtCity);
        grpDatos.Controls.Add(txtState);
        grpDatos.Controls.Add(txtCountry);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 160);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos de la editorial";
        // labels
        lblPubId.AutoSize = true;
        lblPubId.Location = new Point(15, 28);
        lblPubId.Name = "lblPubId";
        lblPubId.Text = "pub_id";
        lblName.AutoSize = true;
        lblName.Location = new Point(190, 28);
        lblName.Name = "lblName";
        lblName.Text = "pub_name";
        lblCity.AutoSize = true;
        lblCity.Location = new Point(365, 28);
        lblCity.Name = "lblCity";
        lblCity.Text = "city";
        lblState.AutoSize = true;
        lblState.Location = new Point(15, 88);
        lblState.Name = "lblState";
        lblState.Text = "state";
        lblCountry.AutoSize = true;
        lblCountry.Location = new Point(190, 88);
        lblCountry.Name = "lblCountry";
        lblCountry.Text = "country";
        // textboxes
        txtPubId.Location = new Point(15, 48);
        txtPubId.MaxLength = 4;
        txtPubId.Name = "txtPubId";
        txtPubId.Size = new Size(160, 23);
        txtPubId.TabIndex = 0;
        txtName.Location = new Point(190, 48);
        txtName.MaxLength = 40;
        txtName.Name = "txtName";
        txtName.Size = new Size(160, 23);
        txtName.TabIndex = 1;
        txtCity.Location = new Point(365, 48);
        txtCity.MaxLength = 20;
        txtCity.Name = "txtCity";
        txtCity.Size = new Size(160, 23);
        txtCity.TabIndex = 2;
        txtState.Location = new Point(15, 108);
        txtState.MaxLength = 2;
        txtState.Name = "txtState";
        txtState.Size = new Size(160, 23);
        txtState.TabIndex = 3;
        txtCountry.Location = new Point(190, 108);
        txtCountry.MaxLength = 30;
        txtCountry.Name = "txtCountry";
        txtCountry.Size = new Size(160, 23);
        txtCountry.TabIndex = 4;
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
        // FrmPublishers
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(760, 450);
        Name = "FrmPublishers";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: publishers";
        Load += FrmPublishers_Load;
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
    private Label lblPubId;
    private Label lblName;
    private Label lblCity;
    private Label lblState;
    private Label lblCountry;
    private TextBox txtPubId;
    private TextBox txtName;
    private TextBox txtCity;
    private TextBox txtState;
    private TextBox txtCountry;
    private DataGridView dgv;
}