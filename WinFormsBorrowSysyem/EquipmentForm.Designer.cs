namespace WinFormsBorrowSysyem
{
    partial class EquipmentForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Search = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 10;
            label3.Text = "type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 9;
            label2.Text = "Model : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 8;
            label1.Text = "Equipments";
            // 
            // Search
            // 
            Search.Location = new Point(638, 112);
            Search.Name = "Search";
            Search.Size = new Size(112, 34);
            Search.TabIndex = 13;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(66, 165);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(562, 229);
            listBox1.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(122, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(405, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 16;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(Search);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EquipmentForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EquipmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Search;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}