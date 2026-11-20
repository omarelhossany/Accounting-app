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
            Hide();

            using var form2 = new Form2();
            form2.ShowDialog();

            Show();
        }

        private void journalEntry_MouseEnter(object sender, EventArgs e)
        {
            journalEntry.BackColor = SystemColors.ControlDarkDark;
        }

        private void journalEntry_MouseLeave(object sender, EventArgs e)
        {
            journalEntry.BackColor = SystemColors.AppWorkspace;
        }

        private void encoding_Click(object sender, EventArgs e)
        {
            using var form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void encoding_MouseEnter(object sender, EventArgs e)
        {
            encoding.BackColor = SystemColors.ControlDarkDark;
        }

        private void encoding_MouseLeave(object sender, EventArgs e)
        {
            encoding.BackColor = SystemColors.AppWorkspace;
        }
    }
}
