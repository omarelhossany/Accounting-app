using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accounting_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void new_entry_Click(object sender, EventArgs e)
        {
            using var form = new Form
            {
                Text = "add entry",
                Size = new Size(600, 400),
                StartPosition = FormStartPosition.CenterScreen
            };

            form.ShowDialog();
        }
    }
}
