namespace Floricola.Vistas.EstadoCivil
{
    partial class FrmNuevoEstadoCivil
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
            txtNuevo = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 75);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(246, 38);
            label2.TabIndex = 1;
            label2.Text = "Nuevo Estado Civil";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(20, 110);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(280, 31);
            txtNuevo.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 155);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmNuevoEstadoCivil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 204);
            Controls.Add(btnGuardar);
            Controls.Add(txtNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNuevoEstadoCivil";
            Text = "FrmNuevoEstadoCivil";
            Load += FrmNuevoEstadoCivil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNuevo;
        private Button btnGuardar;
    }
}