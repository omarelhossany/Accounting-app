using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accounting_app
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void add_account_Click(object sender, EventArgs e)
        {
            using var form = new Form
            {
                Text = "add account",
                Size = new Size(600, 400),
                StartPosition = FormStartPosition.CenterScreen
            };

            form.ShowDialog();
        }
    }
}
