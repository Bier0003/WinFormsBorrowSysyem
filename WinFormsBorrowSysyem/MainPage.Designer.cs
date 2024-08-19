namespace WinFormsBorrowSysyem
{
    partial class MainPage
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
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(643, 79);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SearchBT;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(110, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(494, 224);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 31);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 12;
            label6.Text = "Hardware  Equipment";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 75);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 13;
            label1.Text = "Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 27);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 79);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 15;
            label2.Text = "search by:";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
    }
}