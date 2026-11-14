namespace Floricola.Vistas.EstadoCivil
{
    partial class FrmEditarEsatdoCivil
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
            label2 = new Label();
            txtEditar = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(235, 38);
            label2.TabIndex = 0;
            label2.Text = "Editar Estado Civil";
            // 
            // txtEditar
            // 
            txtEditar.Location = new Point(20, 80);
            txtEditar.Name = "txtEditar";
            txtEditar.Size = new Size(280, 31);
            txtEditar.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 135);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmEditarEsatdoCivil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 204);
            Controls.Add(btnGuardar);
            Controls.Add(txtEditar);
            Controls.Add(label2);
            Name = "FrmEditarEsatdoCivil";
            Text = "FrmEditarEsatdoCivil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtEditar;
        private Button btnGuardar;
    }
}