namespace PubsApp;

partial class FrmPubInfo
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
        lblPub = new Label();
        lblLogo = new Label();
        lblInfo = new Label();
        cboPub = new ComboBox();
        btnCargarLogo = new Button();
        btnQuitarLogo = new Button();
        picLogo = new PictureBox();
        txtInfo = new TextBox();
        dgv = new DataGridView();
        pnlBotones.SuspendLayout();
        grpDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
        grpDatos.Controls.Add(lblPub);
        grpDatos.Controls.Add(lblLogo);
        grpDatos.Controls.Add(lblInfo);
        grpDatos.Controls.Add(cboPub);
        grpDatos.Controls.Add(btnCargarLogo);
        grpDatos.Controls.Add(btnQuitarLogo);
        grpDatos.Controls.Add(picLogo);
        grpDatos.Controls.Add(txtInfo);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 220);
        grpDatos.TabStop = false;
        grpDatos.Text = "Información de la editorial";
        // labels
        lblPub.AutoSize = true;
        lblPub.Location = new Point(15, 28);
        lblPub.Name = "lblPub";
        lblPub.Text = "pub_id (editorial)";
        lblLogo.AutoSize = true;
        lblLogo.Location = new Point(15, 88);
        lblLogo.Name = "lblLogo";
        lblLogo.Text = "logo";
        lblInfo.AutoSize = true;
        lblInfo.Location = new Point(570, 28);
        lblInfo.Name = "lblInfo";
        lblInfo.Text = "pr_info";
        // controles
        cboPub.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPub.Location = new Point(15, 48);
        cboPub.Name = "cboPub";
        cboPub.Size = new Size(250, 23);
        cboPub.TabIndex = 0;
        btnCargarLogo.Location = new Point(15, 110);
        btnCargarLogo.Name = "btnCargarLogo";
        btnCargarLogo.Size = new Size(120, 32);
        btnCargarLogo.TabIndex = 1;
        btnCargarLogo.Text = "Cargar logo";
        btnCargarLogo.UseVisualStyleBackColor = true;
        btnCargarLogo.Click += btnCargarLogo_Click;
        btnQuitarLogo.Location = new Point(145, 110);
        btnQuitarLogo.Name = "btnQuitarLogo";
        btnQuitarLogo.Size = new Size(120, 32);
        btnQuitarLogo.TabIndex = 2;
        btnQuitarLogo.Text = "Quitar logo";
        btnQuitarLogo.UseVisualStyleBackColor = true;
        btnQuitarLogo.Click += btnQuitarLogo_Click;
        picLogo.BorderStyle = BorderStyle.FixedSingle;
        picLogo.Location = new Point(290, 28);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(260, 170);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabStop = false;
        txtInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtInfo.Location = new Point(570, 48);
        txtInfo.MaxLength = 1000000;
        txtInfo.Multiline = true;
        txtInfo.Name = "txtInfo";
        txtInfo.ScrollBars = ScrollBars.Vertical;
        txtInfo.Size = new Size(350, 150);
        txtInfo.TabIndex = 3;
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
        // FrmPubInfo
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 620);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(780, 500);
        Name = "FrmPubInfo";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: pub_info";
        Load += FrmPubInfo_Load;
        pnlBotones.ResumeLayout(false);
        grpDatos.ResumeLayout(false);
        grpDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }

    private Panel pnlBotones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnRecargar;
    private GroupBox grpDatos;
    private Label lblPub;
    private Label lblLogo;
    private Label lblInfo;
    private ComboBox cboPub;
    private Button btnCargarLogo;
    private Button btnQuitarLogo;
    private PictureBox picLogo;
    private TextBox txtInfo;
    private DataGridView dgv;
}