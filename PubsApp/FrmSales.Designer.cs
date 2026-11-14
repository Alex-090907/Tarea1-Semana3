namespace PubsApp;

partial class FrmSales
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
        lblStor = new Label();
        lblOrd = new Label();
        lblTitle = new Label();
        lblDate = new Label();
        lblQty = new Label();
        lblPay = new Label();
        cboStor = new ComboBox();
        txtOrd = new TextBox();
        cboTitle = new ComboBox();
        dtpDate = new DateTimePicker();
        txtQty = new TextBox();
        txtPay = new TextBox();
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
        grpDatos.Controls.Add(lblStor);
        grpDatos.Controls.Add(lblOrd);
        grpDatos.Controls.Add(lblTitle);
        grpDatos.Controls.Add(lblDate);
        grpDatos.Controls.Add(lblQty);
        grpDatos.Controls.Add(lblPay);
        grpDatos.Controls.Add(cboStor);
        grpDatos.Controls.Add(txtOrd);
        grpDatos.Controls.Add(cboTitle);
        grpDatos.Controls.Add(dtpDate);
        grpDatos.Controls.Add(txtQty);
        grpDatos.Controls.Add(txtPay);
        grpDatos.Dock = DockStyle.Bottom;
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(940, 160);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos de la venta";
        // labels
        lblStor.AutoSize = true;
        lblStor.Location = new Point(15, 28);
        lblStor.Name = "lblStor";
        lblStor.Text = "stor_id (tienda)";
        lblOrd.AutoSize = true;
        lblOrd.Location = new Point(260, 28);
        lblOrd.Name = "lblOrd";
        lblOrd.Text = "ord_num";
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(425, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "title_id (libro)";
        lblDate.AutoSize = true;
        lblDate.Location = new Point(15, 88);
        lblDate.Name = "lblDate";
        lblDate.Text = "ord_date";
        lblQty.AutoSize = true;
        lblQty.Location = new Point(230, 88);
        lblQty.Name = "lblQty";
        lblQty.Text = "qty";
        lblPay.AutoSize = true;
        lblPay.Location = new Point(345, 88);
        lblPay.Name = "lblPay";
        lblPay.Text = "payterms";
        // controles fila 1
        cboStor.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStor.Location = new Point(15, 48);
        cboStor.Name = "cboStor";
        cboStor.Size = new Size(230, 23);
        cboStor.TabIndex = 0;
        txtOrd.Location = new Point(260, 48);
        txtOrd.MaxLength = 20;
        txtOrd.Name = "txtOrd";
        txtOrd.Size = new Size(150, 23);
        txtOrd.TabIndex = 1;
        cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTitle.Location = new Point(425, 48);
        cboTitle.Name = "cboTitle";
        cboTitle.Size = new Size(300, 23);
        cboTitle.TabIndex = 2;
        // controles fila 2
        dtpDate.Format = DateTimePickerFormat.Short;
        dtpDate.Location = new Point(15, 108);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(200, 23);
        dtpDate.TabIndex = 3;
        txtQty.Location = new Point(230, 108);
        txtQty.Name = "txtQty";
        txtQty.Size = new Size(100, 23);
        txtQty.TabIndex = 4;
        txtPay.Location = new Point(345, 108);
        txtPay.MaxLength = 12;
        txtPay.Name = "txtPay";
        txtPay.Size = new Size(150, 23);
        txtPay.TabIndex = 5;
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
        // FrmSales
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 600);
        Controls.Add(dgv);
        Controls.Add(grpDatos);
        Controls.Add(pnlBotones);
        MinimumSize = new Size(780, 450);
        Name = "FrmSales";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tabla: sales";
        Load += FrmSales_Load;
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
    private Label lblStor;
    private Label lblOrd;
    private Label lblTitle;
    private Label lblDate;
    private Label lblQty;
    private Label lblPay;
    private ComboBox cboStor;
    private TextBox txtOrd;
    private ComboBox cboTitle;
    private DateTimePicker dtpDate;
    private TextBox txtQty;
    private TextBox txtPay;
    private DataGridView dgv;
}