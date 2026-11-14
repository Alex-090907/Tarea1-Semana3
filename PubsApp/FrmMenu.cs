namespace PubsApp;

public partial class FrmMenu : Form
{
    public FrmMenu()
    {
        InitializeComponent();
    }

    private void btnTabla_Click(object? sender, EventArgs e)
    {
        var btn = (Button)sender!;
        switch (btn.Text)
        {
            case "authors":
                new FrmAuthors().Show();
                break;
            case "publishers":
                new FrmPublishers().Show();
                break;
            case "titles":
                new FrmTitles().Show();
                break;
            case "titleauthor":
                new FrmTitleAuthor().Show();
                break;
            case "stores":
                new FrmStores().Show();
                break;
            case "sales":
                new FrmSales().Show();
                break;
            case "roysched":
                new FrmRoysched().Show();
                break;
            case "discounts":
                new FrmDiscounts().Show();
                break;
            case "jobs":
                new FrmJobs().Show();
                break;
            case "pub_info":
                new FrmPubInfo().Show();
                break;
            case "employee":
                new FrmEmployee().Show();
                break;
        }
    }
}