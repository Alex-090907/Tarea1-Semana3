namespace PubsApp;

partial class FrmMenu
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
        lblTitulo = new Label();
        tlpMenu = new TableLayoutPanel();
        btnAuthors = new Button();
        btnPublishers = new Button();
        btnTitles = new Button();
        btnTitleauthor = new Button();
        btnStores = new Button();
        btnSales = new Button();
        btnRoysched = new Button();
        btnDiscounts = new Button();
        btnJobs = new Button();
        btnPubInfo = new Button();
        btnEmployee = new Button();
        tlpMenu.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Top;
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(684, 50);
        lblTitulo.Text = "Base de datos Pubs";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tlpMenu
        // 
        tlpMenu.ColumnCount = 3;
        tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        tlpMenu.Controls.Add(btnAuthors, 0, 0);
        tlpMenu.Controls.Add(btnPublishers, 1, 0);
        tlpMenu.Controls.Add(btnTitles, 2, 0);
        tlpMenu.Controls.Add(btnTitleauthor, 0, 1);
        tlpMenu.Controls.Add(btnStores, 1, 1);
        tlpMenu.Controls.Add(btnSales, 2, 1);
        tlpMenu.Controls.Add(btnRoysched, 0, 2);
        tlpMenu.Controls.Add(btnDiscounts, 1, 2);
        tlpMenu.Controls.Add(btnJobs, 2, 2);
        tlpMenu.Controls.Add(btnPubInfo, 0, 3);
        tlpMenu.Controls.Add(btnEmployee, 1, 3);
        tlpMenu.Dock = DockStyle.Fill;
        tlpMenu.Name = "tlpMenu";
        tlpMenu.Padding = new Padding(15);
        tlpMenu.RowCount = 4;
        tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpMenu.Size = new Size(684, 411);
        // 
        // btnAuthors
        // 
        btnAuthors.Dock = DockStyle.Fill;
        btnAuthors.Margin = new Padding(8);
        btnAuthors.Name = "btnAuthors";
        btnAuthors.Text = "authors";
        btnAuthors.UseVisualStyleBackColor = true;
        btnAuthors.Click += btnTabla_Click;
        // 
        // btnPublishers
        // 
        btnPublishers.Dock = DockStyle.Fill;
        btnPublishers.Margin = new Padding(8);
        btnPublishers.Name = "btnPublishers";
        btnPublishers.Text = "publishers";
        btnPublishers.UseVisualStyleBackColor = true;
        btnPublishers.Click += btnTabla_Click;
        // 
        // btnTitles
        // 
        btnTitles.Dock = DockStyle.Fill;
        btnTitles.Margin = new Padding(8);
        btnTitles.Name = "btnTitles";
        btnTitles.Text = "titles";
        btnTitles.UseVisualStyleBackColor = true;
        btnTitles.Click += btnTabla_Click;
        // 
        // btnTitleauthor
        // 
        btnTitleauthor.Dock = DockStyle.Fill;
        btnTitleauthor.Margin = new Padding(8);
        btnTitleauthor.Name = "btnTitleauthor";
        btnTitleauthor.Text = "titleauthor";
        btnTitleauthor.UseVisualStyleBackColor = true;
        btnTitleauthor.Click += btnTabla_Click;
        // 
        // btnStores
        // 
        btnStores.Dock = DockStyle.Fill;
        btnStores.Margin = new Padding(8);
        btnStores.Name = "btnStores";
        btnStores.Text = "stores";
        btnStores.UseVisualStyleBackColor = true;
        btnStores.Click += btnTabla_Click;
        // 
        // btnSales
        // 
        btnSales.Dock = DockStyle.Fill;
        btnSales.Margin = new Padding(8);
        btnSales.Name = "btnSales";
        btnSales.Text = "sales";
        btnSales.UseVisualStyleBackColor = true;
        btnSales.Click += btnTabla_Click;
        // 
        // btnRoysched
        // 
        btnRoysched.Dock = DockStyle.Fill;
        btnRoysched.Margin = new Padding(8);
        btnRoysched.Name = "btnRoysched";
        btnRoysched.Text = "roysched";
        btnRoysched.UseVisualStyleBackColor = true;
        btnRoysched.Click += btnTabla_Click;
        // 
        // btnDiscounts
        // 
        btnDiscounts.Dock = DockStyle.Fill;
        btnDiscounts.Margin = new Padding(8);
        btnDiscounts.Name = "btnDiscounts";
        btnDiscounts.Text = "discounts";
        btnDiscounts.UseVisualStyleBackColor = true;
        btnDiscounts.Click += btnTabla_Click;
        // 
        // btnJobs
        // 
        btnJobs.Dock = DockStyle.Fill;
        btnJobs.Margin = new Padding(8);
        btnJobs.Name = "btnJobs";
        btnJobs.Text = "jobs";
        btnJobs.UseVisualStyleBackColor = true;
        btnJobs.Click += btnTabla_Click;
        // 
        // btnPubInfo
        // 
        btnPubInfo.Dock = DockStyle.Fill;
        btnPubInfo.Margin = new Padding(8);
        btnPubInfo.Name = "btnPubInfo";
        btnPubInfo.Text = "pub_info";
        btnPubInfo.UseVisualStyleBackColor = true;
        btnPubInfo.Click += btnTabla_Click;
        // 
        // btnEmployee
        // 
        btnEmployee.Dock = DockStyle.Fill;
        btnEmployee.Margin = new Padding(8);
        btnEmployee.Name = "btnEmployee";
        btnEmployee.Text = "employee";
        btnEmployee.UseVisualStyleBackColor = true;
        btnEmployee.Click += btnTabla_Click;
        // 
        // FrmMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(684, 461);
        Controls.Add(tlpMenu);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(500, 400);
        Name = "FrmMenu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pubs - Menú principal";
        tlpMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Label lblTitulo;
    private TableLayoutPanel tlpMenu;
    private Button btnAuthors;
    private Button btnPublishers;
    private Button btnTitles;
    private Button btnTitleauthor;
    private Button btnStores;
    private Button btnSales;
    private Button btnRoysched;
    private Button btnDiscounts;
    private Button btnJobs;
    private Button btnPubInfo;
    private Button btnEmployee;
}