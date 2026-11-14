namespace PubsApp;

partial class FrmDiscounts
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
        lblType = new Label();
        lblStor = new Label();
        lblLow = new Label();
        lblHigh = new Label();
        lblDisc = new Label();
        txtType = new TextBox();
        cboStor = new ComboBox();
        txtLow = new TextBox();
        txtHigh = new TextBox();
        txtDisc = new TextBox();
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
        grpDatos.Controls.Add(lblType);
        grpDatos.Controls.Add(lblStor);
        grpDatos.Controls.Add(lblLow);
        grpDatos.Controls.Add(lblHigh);
        grpDatos.Controls.Add(lblDisc);
        grpDatos.Controls.Add(txtType);
        grpDatos.Controls.Add(cboStor);
        grpDatos.Controls.Add(txtLow);
        grpDatos.Controls.Add(txtHigh);
        grpDatos.Controls.Add(txtDisc);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 160);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del descuento";
        // labels
        lblType.AutoSize = true;
        lblType.Location = new Point(15, 28);
        lblType.Name = "lblType";
        lblType.Text = "discounttype";
        lblStor.AutoSize = true;
        lblStor.Location = new Point(260, 28);
        lblStor.Name = "lblStor";
        lblStor.Text = "stor_id (tienda, opcional)";
        lblLow.AutoSize = true;
        lblLow.Location = new Point(515, 28);
        lblLow.Name = "lblLow";
        lblLow.Text = "lowqty";
        lblHigh.AutoSize = true;
        lblHigh.Location = new Point(630, 28);
        lblHigh.Name = "lblHigh";
        lblHigh.Text = "highqty";
        lblDisc.AutoSize = true;
        lblDisc.Location = new Point(15, 88);
        lblDisc.Name = "lblDisc";
        lblDisc.Text = "discount (ej. 5.50)";
        // controles
        txtType.Location = new Point(15, 48);
        txtType.MaxLength = 40;
        txtType.Name = "txtType";
        txtType.Size = new Size(230, 23);
        txtType.TabIndex = 0;
        cboStor.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStor.Location = new Point(260, 48);
        cboStor.Name = "cboStor";
        cboStor.Size = new Size(240, 23);
        cboStor.TabIndex = 1;
        txtLow.Location = new Point(515, 48);
        txtLow.Name = "txtLow";
        txtLow.Size = new Size(100, 23);
        txtLow.TabIndex = 2;
        txtHigh.Location = new Point(630, 48);
        txtHigh.Name = "txtHigh";
        txtHigh.Size = new Size(100, 23);
        txtHigh.TabIndex = 3;
        txtDisc.Location = new Point(15, 108);
        txtDisc.Name = "txtDisc";
        txtDisc.Size = new Size(120, 23);
        txtDisc.TabIndex = 4;
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
        // FrmDiscounts
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(780, 450);
        Name = "FrmDiscounts";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: discounts";
        Load += FrmDiscounts_Load;
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
    private Label lblType;
    private Label lblStor;
    private Label lblLow;
    private Label lblHigh;
    private Label lblDisc;
    private TextBox txtType;
    private ComboBox cboStor;
    private TextBox txtLow;
    private TextBox txtHigh;
    private TextBox txtDisc;
    private DataGridView dgv;
}