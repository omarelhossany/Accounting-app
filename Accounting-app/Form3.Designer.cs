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
            label1 = new Label();
            treeView1 = new TreeView();
            add_account = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "تكوييد الحسابات العامة";
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeView1.Location = new Point(35, 57);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(734, 313);
            treeView1.TabIndex = 1;
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
            // button2
            // 
            button2.Location = new Point(556, 382);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 2;
            button2.Text = "تعديل حساب";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(439, 389);
            button3.Name = "button3";
            button3.Size = new Size(83, 37);
            button3.TabIndex = 2;
            button3.Text = "حذف حساب";
            button3.UseVisualStyleBackColor = true;
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
            button5.Location = new Point(213, 383);
            button5.Name = "button5";
            button5.Size = new Size(105, 43);
            button5.TabIndex = 4;
            button5.Text = "البحث عن حساب";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(add_account);
            Controls.Add(treeView1);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TreeView treeView1;
        private Button add_account;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}