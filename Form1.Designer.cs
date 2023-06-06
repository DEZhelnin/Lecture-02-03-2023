namespace _02._023._23_lect
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Параллельное";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 39);
            textBox2.TabIndex = 1;
            textBox2.Text = "Последовательное";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 50);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(70, 270);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(263, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 46);
            progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private ProgressBar progressBar1;
    }
}