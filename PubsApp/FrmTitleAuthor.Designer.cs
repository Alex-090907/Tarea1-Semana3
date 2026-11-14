namespace PubsApp;

partial class FrmTitleAuthor
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
        lblAu = new Label();
        lblTitle = new Label();
        lblOrd = new Label();
        lblRoy = new Label();
        cboAu = new ComboBox();
        cboTitle = new ComboBox();
        txtOrd = new TextBox();
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
        grpDatos.Controls.Add(lblAu);
        grpDatos.Controls.Add(lblTitle);
        grpDatos.Controls.Add(lblOrd);
        grpDatos.Controls.Add(lblRoy);
        grpDatos.Controls.Add(cboAu);
        grpDatos.Controls.Add(cboTitle);
        grpDatos.Controls.Add(txtOrd);
        grpDatos.Controls.Add(txtRoy);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 100);
        grpDatos.TabStop = false;
        grpDatos.Text = "Autor por libro";
        // labels
        lblAu.AutoSize = true;
        lblAu.Location = new Point(15, 28);
        lblAu.Name = "lblAu";
        lblAu.Text = "au_id (autor)";
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(260, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "title_id (libro)";
        lblOrd.AutoSize = true;
        lblOrd.Location = new Point(535, 28);
        lblOrd.Name = "lblOrd";
        lblOrd.Text = "au_ord";
        lblRoy.AutoSize = true;
        lblRoy.Location = new Point(640, 28);
        lblRoy.Name = "lblRoy";
        lblRoy.Text = "royaltyper";
        // controles
        cboAu.DropDownStyle = ComboBoxStyle.DropDownList;
        cboAu.Location = new Point(15, 48);
        cboAu.Name = "cboAu";
        cboAu.Size = new Size(230, 23);
        cboAu.TabIndex = 0;
        cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTitle.Location = new Point(260, 48);
        cboTitle.Name = "cboTitle";
        cboTitle.Size = new Size(260, 23);
        cboTitle.TabIndex = 1;
        txtOrd.Location = new Point(535, 48);
        txtOrd.Name = "txtOrd";
        txtOrd.Size = new Size(90, 23);
        txtOrd.TabIndex = 2;
        txtRoy.Location = new Point(640, 48);
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
        // FrmTitleAuthor
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(780, 450);
        Name = "FrmTitleAuthor";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: titleauthor";
        Load += FrmTitleAuthor_Load;
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
    private Label lblAu;
    private Label lblTitle;
    private Label lblOrd;
    private Label lblRoy;
    private ComboBox cboAu;
    private ComboBox cboTitle;
    private TextBox txtOrd;
    private TextBox txtRoy;
    private DataGridView dgv;
}