using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            TreeNode selected = treeView1.SelectedNode;
            if (account_name.Text != "" && selected != null)
            {
                int code = selected.Nodes.Count;
                if (!selected.Nodes.Cast<TreeNode>().Any(n => n.Text.Substring(2) == account_name.Text))
                {
                    DialogResult result = MessageBox.Show(
                         "هل تود تأكيد إضافة هذا الحساب إلى الشجرة؟\n" + account_name.Text,
                        "إضافة الحساب",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.None
                    );
                    if (result == DialogResult.Yes)
                    {
                        code = selected.Nodes.Count + 1;


                        selected.Nodes.Add(code.ToString() + " " + account_name.Text);
                        selected.Expand();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("هذا الحساب موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selected == null)
            {
                MessageBox.Show("الرجاء تحديد حساب رئيسي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("الرجاء إدخال اسم الحساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_account_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeView1.SelectedNode;
            if (selected != null && selected.Nodes.Count == 0 && selected != treeView1.Nodes[0])
            {
                DialogResult result = MessageBox.Show(
                    "هل تود حذف هذا الحساب؟\n" + selected.Text,
                    "حذف الحساب",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    selected.Remove();
                    return;
                }
            }
        }
        private void rename_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeView1.SelectedNode;
            string node_code = selected.Text.Substring(0, 2);

            if (account_name.Text != "" && selected != null)
            {
                if (!selected.Parent.Nodes.Cast<TreeNode>()
                    .Any(n => n != selected && n.Text.Substring(2) == account_name.Text))
                {
                    DialogResult result = MessageBox.Show(
                         "هل تود تعديل اسم هذا الحساب إلي\n" + account_name.Text,
                        "تعديل اسم الحساب",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.None
                    );
                    if (result == DialogResult.Yes)
                    {

                        selected.Text = node_code + account_name.Text;
                        selected.Expand();
                        return;
                    }
                }else
                {
                    MessageBox.Show("هذا الحساب موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label2.Text = e.Node.Text.Substring(2);
        }
    }
}
