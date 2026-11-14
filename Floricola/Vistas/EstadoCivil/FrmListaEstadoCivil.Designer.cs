namespace Floricola.Vistas.EstadoCivil
{
    partial class FrmListaEstadoCivil
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
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            lstLista = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(337, 38);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Estados Civiles";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(20, 70);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 50);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Estado Civil";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(20, 135);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar Estado Civil";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(20, 200);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 50);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Estado Civil";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(190, 70);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(240, 179);
            lstLista.TabIndex = 4;
            // 
            // FrmListaEstadoCivil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 324);
            Controls.Add(lstLista);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Name = "FrmListaEstadoCivil";
            Text = "FrmListaEstadoCivil";
            Load += FrmListaEstadoCivil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private ListBox lstLista;
    }
}