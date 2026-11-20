namespace Accounting_app
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            label1 = new Label();
            label2 = new Label();
            navigator = new Panel();
            encoding = new Button();
            journalEntry = new Button();
            navTitle = new Label();
            navigator.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 1;
            label1.Text = "10 -11 - 2026";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 2;
            label2.Text = "الخميس";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // navigator
            // 
            navigator.BackColor = Color.FromArgb(224, 224, 224);
            navigator.Controls.Add(encoding);
            navigator.Controls.Add(journalEntry);
            navigator.Controls.Add(navTitle);
            navigator.Location = new Point(336, 12);
            navigator.Name = "navigator";
            navigator.Size = new Size(452, 426);
            navigator.TabIndex = 3;
            // 
            // encoding
            // 
            encoding.BackColor = SystemColors.AppWorkspace;
            encoding.FlatAppearance.BorderSize = 0;
            encoding.FlatStyle = FlatStyle.Flat;
            encoding.Location = new Point(340, 136);
            encoding.Name = "encoding";
            encoding.Size = new Size(96, 38);
            encoding.TabIndex = 3;
            encoding.Text = "تكوييد الحسابات العامة";
            encoding.UseVisualStyleBackColor = false;
            encoding.Click += encoding_Click;
            encoding.MouseEnter += encoding_MouseEnter;
            encoding.MouseLeave += encoding_MouseLeave;
            // 
            // journalEntry
            // 
            journalEntry.BackColor = SystemColors.AppWorkspace;
            journalEntry.FlatAppearance.BorderSize = 0;
            journalEntry.FlatStyle = FlatStyle.Flat;
            journalEntry.Location = new Point(340, 76);
            journalEntry.Name = "journalEntry";
            journalEntry.Size = new Size(96, 38);
            journalEntry.TabIndex = 2;
            journalEntry.Text = "قيد اليومية";
            journalEntry.UseVisualStyleBackColor = false;
            journalEntry.Click += journalEntry_Click;
            journalEntry.MouseEnter += journalEntry_MouseEnter;
            journalEntry.MouseLeave += journalEntry_MouseLeave;
            // 
            // navTitle
            // 
            navTitle.BackColor = SystemColors.ActiveBorder;
            navTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 177);
            navTitle.Location = new Point(156, 14);
            navTitle.Name = "navTitle";
            navTitle.Size = new Size(147, 34);
            navTitle.TabIndex = 0;
            navTitle.Text = "الشركة";
            navTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 438);
            Controls.Add(navigator);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "mainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            navigator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        public Label label2;
        public Panel navigator;
        public Label navTitle;
        public Button journalEntry;
        public Button encoding;
    }
}
