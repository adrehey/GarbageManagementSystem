namespace GarbageManagementSystem
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            label1 = new Label();
            panel1 = new Panel();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(320, 240);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(478, 600);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Ivory;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(76, 252);
            richTextBox2.Margin = new Padding(5);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(326, 26);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Ivory;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(76, 178);
            richTextBox1.Margin = new Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(326, 26);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(130, 43);
            label3.Name = "label3";
            label3.Size = new Size(218, 77);
            label3.TabIndex = 0;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Ivory;
            panel2.Location = new Point(320, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 130);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(76, 148);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 6;
            label4.Text = "Sign In:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(76, 224);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1118, 961);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoTrack";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label4;
        private Label label5;
    }
}
