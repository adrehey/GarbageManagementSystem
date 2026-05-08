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
            txtLocation = new TextBox();
            txtDescription = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(218, 125);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 23);
            txtLocation.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(218, 176);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(231, 237);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "button1";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSubmit);
            Controls.Add(txtDescription);
            Controls.Add(txtLocation);
            Name = "ReportControl";
            Size = new Size(1129, 775);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocation;
        private TextBox txtDescription;
        private Button btnSubmit;
    }
}
