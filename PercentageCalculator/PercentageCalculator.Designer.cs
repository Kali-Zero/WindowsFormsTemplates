﻿namespace WindowsFormsTemplates
{
    partial class PercentageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = 
                new System.ComponentModel.ComponentResourceManager(typeof(PercentageCalculator));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(407, 29);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 0;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(407, 114);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 2;
            button2.Text = "CALCULATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(407, 206);
            button3.Name = "button3";
            button3.Size = new Size(87, 23);
            button3.TabIndex = 4;
            button3.Text = "CALCULATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(271, 272);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 23;
            button4.Text = "Clear All Entries";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(521, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(521, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(225, 31);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(30, 119);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(244, 119);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(82, 211);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 10;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(228, 211);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 118);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 12;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 209);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 13;
            label2.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 35);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 14;
            label3.Text = "What is";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 35);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 15;
            label4.Text = "% of";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 122);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 16;
            label5.Text = "is what percent of";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 34);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 17;
            label6.Text = "?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 123);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 18;
            label7.Text = "?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 214);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 19;
            label8.Text = "?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 193);
            label9.Name = "label9";
            label9.Size = new Size(225, 15);
            label9.TabIndex = 20;
            label9.Text = "What is the percentage increase/decrease";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 215);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 21;
            label10.Text = "from";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(188, 214);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 22;
            label11.Text = "to";
            // 
            // PercentageCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(658, 353);
            Controls.Add(button4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "PercentageCalculator";
            Text = "Percentage Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button4;
    }
}
