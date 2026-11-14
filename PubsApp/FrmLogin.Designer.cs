namespace PubsApp;

partial class FrmLogin
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
        lblUsuario = new Label();
        lblClave = new Label();
        txtUsuario = new TextBox();
        txtClave = new TextBox();
        btnIngresar = new Button();
        SuspendLayout();
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Location = new Point(30, 33);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(50, 15);
        lblUsuario.Text = "Usuario:";
        // 
        // lblClave
        // 
        lblClave.AutoSize = true;
        lblClave.Location = new Point(30, 73);
        lblClave.Name = "lblClave";
        lblClave.Size = new Size(37, 15);
        lblClave.Text = "Clave:";
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(110, 30);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(170, 23);
        txtUsuario.TabIndex = 0;
        // 
        // txtClave
        // 
        txtClave.Location = new Point(110, 70);
        txtClave.Name = "txtClave";
        txtClave.Size = new Size(170, 23);
        txtClave.TabIndex = 1;
        txtClave.UseSystemPasswordChar = true;
        // 
        // btnIngresar
        // 
        btnIngresar.Location = new Point(110, 110);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(170, 32);
        btnIngresar.TabIndex = 2;
        btnIngresar.Text = "Ingresar";
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // FrmLogin
        // 
        AcceptButton = btnIngresar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(320, 170);
        Controls.Add(lblUsuario);
        Controls.Add(lblClave);
        Controls.Add(txtUsuario);
        Controls.Add(txtClave);
        Controls.Add(btnIngresar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblUsuario;
    private Label lblClave;
    private TextBox txtUsuario;
    private TextBox txtClave;
    private Button btnIngresar;
}