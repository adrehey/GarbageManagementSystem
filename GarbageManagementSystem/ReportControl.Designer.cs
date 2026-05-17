namespace GarbageManagementSystem
{
    partial class ReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnback = new Button();
            btnITCenter = new Button();
            btnLibrary = new Button();
            btnGym = new Button();
            btnCafeteria = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Info;
            btnback.Location = new Point(56, 530);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 23);
            btnback.TabIndex = 2;
            btnback.Text = "Back ";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click_1;
            // 
            // btnITCenter
            // 
            btnITCenter.BackColor = SystemColors.Info;
            btnITCenter.Location = new Point(84, 129);
            btnITCenter.Name = "btnITCenter";
            btnITCenter.Size = new Size(75, 23);
            btnITCenter.TabIndex = 3;
            btnITCenter.Text = "IT Center";
            btnITCenter.UseVisualStyleBackColor = false;
            btnITCenter.Click += btnITCenter_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.BackColor = SystemColors.Info;
            btnLibrary.Location = new Point(106, 271);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(75, 23);
            btnLibrary.TabIndex = 4;
            btnLibrary.Text = "Library";
            btnLibrary.UseVisualStyleBackColor = false;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // btnGym
            // 
            btnGym.BackColor = SystemColors.Info;
            btnGym.Location = new Point(318, 129);
            btnGym.Name = "btnGym";
            btnGym.Size = new Size(75, 23);
            btnGym.TabIndex = 5;
            btnGym.Text = "Gym";
            btnGym.UseVisualStyleBackColor = false;
            btnGym.Click += btnGym_Click;
            // 
            // btnCafeteria
            // 
            btnCafeteria.BackColor = SystemColors.Info;
            btnCafeteria.Location = new Point(341, 271);
            btnCafeteria.Name = "btnCafeteria";
            btnCafeteria.Size = new Size(75, 23);
            btnCafeteria.TabIndex = 6;
            btnCafeteria.Text = "Cafeteria";
            btnCafeteria.UseVisualStyleBackColor = false;
            btnCafeteria.Click += btnCafeteria_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(538, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 458);
            panel1.TabIndex = 7;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(panel1);
            Controls.Add(btnCafeteria);
            Controls.Add(btnGym);
            Controls.Add(btnLibrary);
            Controls.Add(btnITCenter);
            Controls.Add(btnback);
            Name = "ReportControl";
            Size = new Size(1129, 775);
            ResumeLayout(false);
        }

        #endregion
        private Button btnback;
        private Button btnITCenter;
        private Button btnLibrary;
        private Button btnGym;
        private Button btnCafeteria;
        private Panel panel1;
    }
}
