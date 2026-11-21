namespace Accounting_app
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            new_entry = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "يومية مبيعات نقدية", "يومية مشترات نقدية" });
            comboBox1.Location = new Point(168, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "يومية مبيعات نقدية";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "قيد اليومية";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 24);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "رقم القيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 60);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "بيان القيد";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(585, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(585, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 89);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "ملاحظات";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column4, Column3, Column2, Column1 });
            dataGridView1.Location = new Point(120, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 295);
            dataGridView1.TabIndex = 8;
            // 
            // Column4
            // 
            Column4.HeaderText = "ملاحظات";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.HeaderText = "دائن";
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "مدين";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "اسم البيان";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(33, 120);
            button1.Name = "button1";
            button1.Size = new Size(43, 37);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(33, 173);
            button2.Name = "button2";
            button2.Size = new Size(43, 37);
            button2.TabIndex = 10;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // new_entry
            // 
            new_entry.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            new_entry.Location = new Point(696, 376);
            new_entry.Name = "new_entry";
            new_entry.Size = new Size(92, 50);
            new_entry.TabIndex = 11;
            new_entry.Text = "إضافة قيد";
            new_entry.UseVisualStyleBackColor = true;
            new_entry.Click += new_entry_Click;
            // 
            // button4
            // 
            button4.Location = new Point(186, 392);
            button4.Name = "button4";
            button4.Size = new Size(66, 34);
            button4.TabIndex = 12;
            button4.Text = "طبع";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(598, 376);
            button5.Name = "button5";
            button5.Size = new Size(92, 50);
            button5.TabIndex = 11;
            button5.Text = "حذف قيد";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(29, 385);
            button6.Name = "button6";
            button6.Size = new Size(70, 32);
            button6.TabIndex = 11;
            button6.Text = "حفظ";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.Location = new Point(444, 376);
            button7.Name = "button7";
            button7.Size = new Size(92, 50);
            button7.TabIndex = 13;
            button7.Text = "استطلاع";
            button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(690, 24);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 14;
            label5.Text = "1502";
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(33, 13);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 17;
            label7.Text = "الخميس";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Location = new Point(12, 32);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 16;
            label8.Text = "10 -11 - 2026";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(new_entry);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button new_entry;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label5;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
    }
}