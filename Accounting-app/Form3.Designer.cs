namespace Accounting_app
{
    partial class Form3
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
            TreeNode treeNode1 = new TreeNode("1 أصول");
            TreeNode treeNode2 = new TreeNode("2 خصوم");
            TreeNode treeNode3 = new TreeNode("  شجرة الحسابات العامة", new TreeNode[] { treeNode1, treeNode2 });
            treeView1 = new TreeView();
            add_account = new Button();
            rename = new Button();
            delete_account = new Button();
            button4 = new Button();
            button5 = new Button();
            account_name = new TextBox();
            newAccount_name = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeView1.Location = new Point(12, 57);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "1 أصول";
            treeNode2.Name = "Node3";
            treeNode2.Text = "2 خصوم";
            treeNode3.Name = "Node2";
            treeNode3.Text = "  شجرة الحسابات العامة";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3 });
            treeView1.Size = new Size(759, 313);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // add_account
            // 
            add_account.Location = new Point(675, 382);
            add_account.Name = "add_account";
            add_account.Size = new Size(113, 44);
            add_account.TabIndex = 2;
            add_account.Text = "إضافة حساب جديد";
            add_account.UseVisualStyleBackColor = true;
            add_account.Click += add_account_Click;
            // 
            // rename
            // 
            rename.Location = new Point(556, 382);
            rename.Name = "rename";
            rename.Size = new Size(113, 44);
            rename.TabIndex = 2;
            rename.Text = "تعديل اسم حساب";
            rename.UseVisualStyleBackColor = true;
            rename.Click += rename_Click;
            // 
            // delete_account
            // 
            delete_account.Location = new Point(385, 389);
            delete_account.Name = "delete_account";
            delete_account.Size = new Size(83, 37);
            delete_account.TabIndex = 2;
            delete_account.Text = "حذف حساب";
            delete_account.UseVisualStyleBackColor = true;
            delete_account.Click += delete_account_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 376);
            button4.Name = "button4";
            button4.Size = new Size(104, 45);
            button4.TabIndex = 3;
            button4.Text = "حفظ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(578, 8);
            button5.Name = "button5";
            button5.Size = new Size(105, 43);
            button5.TabIndex = 4;
            button5.Text = "البحث عن حساب";
            button5.UseVisualStyleBackColor = true;
            // 
            // account_name
            // 
            account_name.Location = new Point(51, 28);
            account_name.Name = "account_name";
            account_name.Size = new Size(207, 23);
            account_name.TabIndex = 5;
            // 
            // newAccount_name
            // 
            newAccount_name.AutoSize = true;
            newAccount_name.Location = new Point(104, 10);
            newAccount_name.Name = "newAccount_name";
            newAccount_name.Size = new Size(101, 15);
            newAccount_name.TabIndex = 6;
            newAccount_name.Text = "اسم الحساب الجديد";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 8);
            label2.Name = "label2";
            label2.Size = new Size(308, 43);
            label2.TabIndex = 7;
            label2.Text = "Selected";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(712, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 32);
            button1.TabIndex = 8;
            button1.Text = "إحترافي";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(newAccount_name);
            Controls.Add(account_name);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(delete_account);
            Controls.Add(rename);
            Controls.Add(add_account);
            Controls.Add(treeView1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تكوييد الحسابات العامة";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TreeView treeView1;
        private Button add_account;
        private Button rename;
        private Button delete_account;
        private Button button4;
        private Button button5;
        private TextBox account_name;
        private Label newAccount_name;
        private Label label2;
        private Button button1;
    }
}