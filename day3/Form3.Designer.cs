namespace day3
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
            label2 = new Label();
            lab1 = new Label();
            lab2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            lab3 = new Label();
            lab4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "X轴";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 70);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "Y轴";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Location = new Point(113, 34);
            lab1.Name = "lab1";
            lab1.Size = new Size(53, 20);
            lab1.TabIndex = 0;
            lab1.Text = "label1";
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.Location = new Point(113, 70);
            lab2.Name = "lab2";
            lab2.Size = new Size(53, 20);
            lab2.TabIndex = 1;
            lab2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 35);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "手机号：";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(285, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(485, 93);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // lab3
            // 
            lab3.AutoSize = true;
            lab3.ForeColor = Color.Red;
            lab3.Location = new Point(546, 38);
            lab3.Name = "lab3";
            lab3.Size = new Size(50, 20);
            lab3.TabIndex = 5;
            lab3.Text = "错误×";
            lab3.Visible = false;
            // 
            // lab4
            // 
            lab4.AutoSize = true;
            lab4.ForeColor = Color.LightGreen;
            lab4.Location = new Point(550, 41);
            lab4.Name = "lab4";
            lab4.Size = new Size(60, 20);
            lab4.TabIndex = 6;
            lab4.Text = "正确✅️";
            lab4.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(308, 92);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "确认";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lab4);
            Controls.Add(lab3);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(lab2);
            Controls.Add(label2);
            Controls.Add(lab1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lab1;
        private Label lab2;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label lab3;
        private Label lab4;
        private Button button1;
    }
}