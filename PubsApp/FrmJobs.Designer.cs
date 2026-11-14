namespace PubsApp;

partial class FrmJobs
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
        lblDesc = new Label();
        lblMin = new Label();
        lblMax = new Label();
        txtId = new TextBox();
        txtDesc = new TextBox();
        txtMin = new TextBox();
        txtMax = new TextBox();
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
        grpDatos.Controls.Add(lblDesc);
        grpDatos.Controls.Add(lblMin);
        grpDatos.Controls.Add(lblMax);
        grpDatos.Controls.Add(txtId);
        grpDatos.Controls.Add(txtDesc);
        grpDatos.Controls.Add(txtMin);
        grpDatos.Controls.Add(txtMax);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 100);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del puesto";
        // labels
        lblId.AutoSize = true;
        lblId.Location = new Point(15, 28);
        lblId.Name = "lblId";
        lblId.Text = "job_id (automático)";
        lblDesc.AutoSize = true;
        lblDesc.Location = new Point(190, 28);
        lblDesc.Name = "lblDesc";
        lblDesc.Text = "job_desc";
        lblMin.AutoSize = true;
        lblMin.Location = new Point(440, 28);
        lblMin.Name = "lblMin";
        lblMin.Text = "min_lvl";
        lblMax.AutoSize = true;
        lblMax.Location = new Point(615, 28);
        lblMax.Name = "lblMax";
        lblMax.Text = "max_lvl";
        // textboxes
        txtId.Location = new Point(15, 48);
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Size = new Size(160, 23);
        txtId.TabStop = false;
        txtDesc.Location = new Point(190, 48);
        txtDesc.MaxLength = 50;
        txtDesc.Name = "txtDesc";
        txtDesc.Size = new Size(235, 23);
        txtDesc.TabIndex = 0;
        txtMin.Location = new Point(440, 48);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(160, 23);
        txtMin.TabIndex = 1;
        txtMax.Location = new Point(615, 48);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(160, 23);
        txtMax.TabIndex = 2;
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
        // FrmJobs
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(760, 450);
        Name = "FrmJobs";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: jobs";
        Load += FrmJobs_Load;
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
    private Label lblDesc;
    private Label lblMin;
    private Label lblMax;
    private TextBox txtId;
    private TextBox txtDesc;
    private TextBox txtMin;
    private TextBox txtMax;
    private DataGridView dgv;
}