namespace Floricola.Vistas
{
    partial class Dashboard
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
            splitContainer1 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            item_Usuarios = new ToolStripMenuItem();
            ItemEstadoCivil = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(230, 223, 203);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(230, 223, 203);
            splitContainer1.Size = new Size(1146, 718);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(20, 50, 41);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, item_Usuarios, ItemEstadoCivil });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(179, 718);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(176, 29);
            toolStripMenuItem1.Text = "Dashboard";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.AutoSize = false;
            toolStripMenuItem2.ForeColor = Color.White;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(176, 29);
            toolStripMenuItem2.Text = "Cultivos y bloques";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.AutoSize = false;
            toolStripMenuItem3.ForeColor = Color.White;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(176, 29);
            toolStripMenuItem3.Text = "Producción";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.AutoSize = false;
            toolStripMenuItem4.ForeColor = Color.White;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(176, 29);
            toolStripMenuItem4.Text = "Cosecha y calidad";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.AutoSize = false;
            toolStripMenuItem5.ForeColor = Color.White;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(176, 29);
            toolStripMenuItem5.Text = "Inventarios";
            // 
            // item_Usuarios
            // 
            item_Usuarios.AutoSize = false;
            item_Usuarios.ForeColor = Color.White;
            item_Usuarios.Name = "item_Usuarios";
            item_Usuarios.Size = new Size(176, 29);
            item_Usuarios.Text = "Usuarios";
            item_Usuarios.Click += item_Usuarios_Click;
            // 
            // ItemEstadoCivil
            // 
            ItemEstadoCivil.AutoSize = false;
            ItemEstadoCivil.ForeColor = Color.White;
            ItemEstadoCivil.Name = "ItemEstadoCivil";
            ItemEstadoCivil.Size = new Size(176, 29);
            ItemEstadoCivil.Text = "Estado Civil";
            ItemEstadoCivil.Click += itemEstadoCivil_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 718);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FloriSoft";
            WindowState = FormWindowState.Maximized;
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem item_Usuarios;
        private ToolStripMenuItem ItemEstadoCivil;
    }
}