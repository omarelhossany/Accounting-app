namespace Accounting_app
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void journalEntry_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.FormClosed += (_, _) => this.Close();

            this.Hide();
            form2.Show();
        }
    }
}
