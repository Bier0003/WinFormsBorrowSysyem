﻿using System.Windows.Forms.Design;

namespace WinFormsBorrowSystem
{
    partial class RegisterForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 123);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Student :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 172);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 224);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 277);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "User :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 325);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += idstudentBox;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += lname;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += fname;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(242, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(375, 27);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += userBT;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(242, 322);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(375, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += pwBT;
            // 
            // button1
            // 
            button1.Location = new Point(593, 375);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RegBT;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 43);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 11;
            label6.Text = "Personal Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 456);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += picture;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}