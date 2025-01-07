namespace GUIDGenerator
{
    partial class GUIDGenerator
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button2 = new Button();
            label3 = new Label();
            checkBox6 = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 134);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 0;
            button1.Text = "Generate GUID(s)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 134);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 161);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(221, 15);
            label1.TabIndex = 2;
            label1.Text = "How many GUIDs do you want (1-1000): ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Format:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(64, 67);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Hyphen";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(138, 68);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "{} Braces  ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(221, 68);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(81, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Uppercase";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(308, 68);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "\" \" Quotes ";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(397, 68);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(80, 19);
            checkBox5.TabIndex = 9;
            checkBox5.Text = ", Commas";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(14, 176);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 10;
            button2.Text = "Copy to Clipboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Encoding:";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(78, 97);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(65, 19);
            checkBox6.TabIndex = 12;
            checkBox6.Text = "Base 64";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.Click += checkBox6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 309);
            label4.Name = "label4";
            label4.Size = new Size(538, 15);
            label4.TabIndex = 13;
            label4.Text = " Use these GUIDs at your own risk! No guarantee of their uniqueness or suitability is given or implied. ";
            // 
            // GUIDGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 387);
            Controls.Add(label4);
            Controls.Add(checkBox6);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "GUIDGenerator";
            Text = "GUID Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button2;
        private Label label3;
        private CheckBox checkBox6;
        private Label label4;
    }
}
