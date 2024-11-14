namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 1;
            label2.Text = "Employee ID*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 3;
            label3.Text = "First name*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 5;
            label4.Text = "Last name*";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 7;
            label5.Text = "Position*";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 239);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(286, 12);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 10;
            label6.Text = "Employee List:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(511, 228);
            dataGridView1.TabIndex = 11;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmployeeDatabase";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
        private DataGridView dataGridView1;
    }
}
