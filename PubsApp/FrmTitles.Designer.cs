namespace PubsApp;

partial class FrmTitles
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
        lblTitle = new Label();
        lblType = new Label();
        lblPub = new Label();
        lblPrice = new Label();
        lblAdvance = new Label();
        lblRoyalty = new Label();
        lblYtd = new Label();
        lblPubdate = new Label();
        lblNotes = new Label();
        txtId = new TextBox();
        txtTitle = new TextBox();
        txtType = new TextBox();
        txtPub = new TextBox();
        txtPrice = new TextBox();
        txtAdvance = new TextBox();
        txtRoyalty = new TextBox();
        txtYtd = new TextBox();
        dtpPubdate = new DateTimePicker();
        txtNotes = new TextBox();
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
        grpDatos.Controls.Add(lblTitle);
        grpDatos.Controls.Add(lblType);
        grpDatos.Controls.Add(lblPub);
        grpDatos.Controls.Add(lblPrice);
        grpDatos.Controls.Add(lblAdvance);
        grpDatos.Controls.Add(lblRoyalty);
        grpDatos.Controls.Add(lblYtd);
        grpDatos.Controls.Add(lblPubdate);
        grpDatos.Controls.Add(lblNotes);
        grpDatos.Controls.Add(txtId);
        grpDatos.Controls.Add(txtTitle);
        grpDatos.Controls.Add(txtType);
        grpDatos.Controls.Add(txtPub);
        grpDatos.Controls.Add(txtPrice);
        grpDatos.Controls.Add(txtAdvance);
        grpDatos.Controls.Add(txtRoyalty);
        grpDatos.Controls.Add(txtYtd);
        grpDatos.Controls.Add(dtpPubdate);
        grpDatos.Controls.Add(txtNotes);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 215);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del libro";
        // labels fila 1
        lblId.AutoSize = true;
        lblId.Location = new Point(15, 28);
        lblId.Name = "lblId";
        lblId.Text = "title_id";
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(130, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "title";
        lblType.AutoSize = true;
        lblType.Location = new Point(445, 28);
        lblType.Name = "lblType";
        lblType.Text = "type";
        lblPub.AutoSize = true;
        lblPub.Location = new Point(590, 28);
        lblPub.Name = "lblPub";
        lblPub.Text = "pub_id";
        // labels fila 2
        lblPrice.AutoSize = true;
        lblPrice.Location = new Point(15, 88);
        lblPrice.Name = "lblPrice";
        lblPrice.Text = "price";
        lblAdvance.AutoSize = true;
        lblAdvance.Location = new Point(130, 88);
        lblAdvance.Name = "lblAdvance";
        lblAdvance.Text = "advance";
        lblRoyalty.AutoSize = true;
        lblRoyalty.Location = new Point(265, 88);
        lblRoyalty.Name = "lblRoyalty";
        lblRoyalty.Text = "royalty";
        lblYtd.AutoSize = true;
        lblYtd.Location = new Point(380, 88);
        lblYtd.Name = "lblYtd";
        lblYtd.Text = "ytd_sales";
        // labels fila 3
        lblPubdate.AutoSize = true;
        lblPubdate.Location = new Point(15, 148);
        lblPubdate.Name = "lblPubdate";
        lblPubdate.Text = "pubdate";
        lblNotes.AutoSize = true;
        lblNotes.Location = new Point(230, 148);
        lblNotes.Name = "lblNotes";
        lblNotes.Text = "notes";
        // textboxes fila 1
        txtId.Location = new Point(15, 48);
        txtId.MaxLength = 6;
        txtId.Name = "txtId";
        txtId.Size = new Size(100, 23);
        txtId.TabIndex = 0;
        txtTitle.Location = new Point(130, 48);
        txtTitle.MaxLength = 80;
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(300, 23);
        txtTitle.TabIndex = 1;
        txtType.Location = new Point(445, 48);
        txtType.MaxLength = 12;
        txtType.Name = "txtType";
        txtType.Size = new Size(130, 23);
        txtType.TabIndex = 2;
        txtPub.Location = new Point(590, 48);
        txtPub.MaxLength = 4;
        txtPub.Name = "txtPub";
        txtPub.Size = new Size(100, 23);
        txtPub.TabIndex = 3;
        // textboxes fila 2
        txtPrice.Location = new Point(15, 108);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(100, 23);
        txtPrice.TabIndex = 4;
        txtAdvance.Location = new Point(130, 108);
        txtAdvance.Name = "txtAdvance";
        txtAdvance.Size = new Size(120, 23);
        txtAdvance.TabIndex = 5;
        txtRoyalty.Location = new Point(265, 108);
        txtRoyalty.Name = "txtRoyalty";
        txtRoyalty.Size = new Size(100, 23);
        txtRoyalty.TabIndex = 6;
        txtYtd.Location = new Point(380, 108);
        txtYtd.Name = "txtYtd";
        txtYtd.Size = new Size(120, 23);
        txtYtd.TabIndex = 7;
        // fila 3
        dtpPubdate.Format = DateTimePickerFormat.Short;
        dtpPubdate.Location = new Point(15, 168);
        dtpPubdate.Name = "dtpPubdate";
        dtpPubdate.Size = new Size(200, 23);
        dtpPubdate.TabIndex = 8;
        txtNotes.Location = new Point(230, 168);
        txtNotes.MaxLength = 200;
        txtNotes.Name = "txtNotes";
        txtNotes.Size = new Size(460, 23);
        txtNotes.TabIndex = 9;
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
        // FrmTitles
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 620);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(760, 500);
        Name = "FrmTitles";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: titles";
        Load += FrmTitles_Load;
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
    private Label lblTitle;
    private Label lblType;
    private Label lblPub;
    private Label lblPrice;
    private Label lblAdvance;
    private Label lblRoyalty;
    private Label lblYtd;
    private Label lblPubdate;
    private Label lblNotes;
    private TextBox txtId;
    private TextBox txtTitle;
    private TextBox txtType;
    private TextBox txtPub;
    private TextBox txtPrice;
    private TextBox txtAdvance;
    private TextBox txtRoyalty;
    private TextBox txtYtd;
    private DateTimePicker dtpPubdate;
    private TextBox txtNotes;
    private DataGridView dgv;
}