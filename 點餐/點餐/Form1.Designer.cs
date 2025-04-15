namespace 點餐
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 19);
            label1.Name = "label1";
            label1.Size = new Size(295, 30);
            label1.TabIndex = 0;
            label1.Text = "點選內用或外帶 , 進行點餐";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 301);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.fast_food;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(470, 29);
            button1.Name = "button1";
            button1.Size = new Size(276, 183);
            button1.TabIndex = 2;
            button1.Text = "內用";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.burger;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(470, 230);
            button2.Name = "button2";
            button2.Size = new Size(276, 183);
            button2.TabIndex = 3;
            button2.Text = "外帶";
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(160, 392);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 4;
            button3.Text = "清除";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(332, 392);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 5;
            button4.Text = "結束";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}