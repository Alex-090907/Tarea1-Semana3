namespace Floricola
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(3, 22, 52);
            label1.Location = new Point(100, 27);
            label1.Name = "label1";
            label1.Size = new Size(321, 48);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(3, 22, 52);
            label2.Location = new Point(31, 103);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su Usuario";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(3, 22, 52);
            textBox1.Location = new Point(31, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 39);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(3, 22, 52);
            label3.Location = new Point(31, 215);
            label3.Name = "label3";
            label3.Size = new Size(268, 32);
            label3.TabIndex = 3;
            label3.Text = "Ingrese su Contraseña";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(3, 22, 52);
            textBox2.Location = new Point(31, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 39);
            textBox2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(3, 22, 52);
            button3.Location = new Point(166, 356);
            button3.Name = "button3";
            button3.Size = new Size(152, 54);
            button3.TabIndex = 5;
            button3.Text = "Ingresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(3, 22, 52);
            button2.Location = new Point(189, 416);
            button2.Name = "button2";
            button2.Size = new Size(112, 46);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.FromArgb(3, 22, 52);
            lblMensaje.Location = new Point(31, 528);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(109, 32);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = "Mensaje";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 223, 203);
            ClientSize = new Size(508, 624);
            Controls.Add(lblMensaje);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FloriSoft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
        private Button button2;
        private Label lblMensaje;
    }
}