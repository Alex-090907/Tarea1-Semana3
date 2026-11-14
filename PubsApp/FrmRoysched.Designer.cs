namespace PubsApp;

partial class FrmRoysched
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
        lblTitle = new Label();
        lblLo = new Label();
        lblHi = new Label();
        lblRoy = new Label();
        cboTitle = new ComboBox();
        txtLo = new TextBox();
        txtHi = new TextBox();
        txtRoy = new TextBox();
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
        grpDatos.Controls.Add(lblTitle);
        grpDatos.Controls.Add(lblLo);
        grpDatos.Controls.Add(lblHi);
        grpDatos.Controls.Add(lblRoy);
        grpDatos.Controls.Add(cboTitle);
        grpDatos.Controls.Add(txtLo);
        grpDatos.Controls.Add(txtHi);
        grpDatos.Controls.Add(txtRoy);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 100);
        grpDatos.TabStop = false;
        grpDatos.Text = "Escala de regalías";
        // labels
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(15, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "title_id (libro)";
        lblLo.AutoSize = true;
        lblLo.Location = new Point(330, 28);
        lblLo.Name = "lblLo";
        lblLo.Text = "lorange";
        lblHi.AutoSize = true;
        lblHi.Location = new Point(455, 28);
        lblHi.Name = "lblHi";
        lblHi.Text = "hirange";
        lblRoy.AutoSize = true;
        lblRoy.Location = new Point(580, 28);
        lblRoy.Name = "lblRoy";
        lblRoy.Text = "royalty";
        // controles
        cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTitle.Location = new Point(15, 48);
        cboTitle.Name = "cboTitle";
        cboTitle.Size = new Size(300, 23);
        cboTitle.TabIndex = 0;
        txtLo.Location = new Point(330, 48);
        txtLo.Name = "txtLo";
        txtLo.Size = new Size(110, 23);
        txtLo.TabIndex = 1;
        txtHi.Location = new Point(455, 48);
        txtHi.Name = "txtHi";
        txtHi.Size = new Size(110, 23);
        txtHi.TabIndex = 2;
        txtRoy.Location = new Point(580, 48);
        txtRoy.Name = "txtRoy";
        txtRoy.Size = new Size(110, 23);
        txtRoy.TabIndex = 3;
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
        // FrmRoysched
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(780, 450);
        Name = "FrmRoysched";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: roysched";
        Load += FrmRoysched_Load;
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
    private Label lblTitle;
    private Label lblLo;
    private Label lblHi;
    private Label lblRoy;
    private ComboBox cboTitle;
    private TextBox txtLo;
    private TextBox txtHi;
    private TextBox txtRoy;
    private DataGridView dgv;
}