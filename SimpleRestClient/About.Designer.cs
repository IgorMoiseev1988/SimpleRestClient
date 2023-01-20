namespace SimpleRestClient
{
    partial class AboutForm
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
            this.NameAndVersionLabel = new System.Windows.Forms.Label();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameAndVersionLabel
            // 
            this.NameAndVersionLabel.AutoSize = true;
            this.NameAndVersionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameAndVersionLabel.Location = new System.Drawing.Point(72, 36);
            this.NameAndVersionLabel.Name = "NameAndVersionLabel";
            this.NameAndVersionLabel.Size = new System.Drawing.Size(175, 21);
            this.NameAndVersionLabel.TabIndex = 0;
            this.NameAndVersionLabel.Text = "SimpleRestClient v0.1";
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Location = new System.Drawing.Point(12, 288);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(116, 15);
            this.DeveloperLabel.TabIndex = 1;
            this.DeveloperLabel.Text = "Developer: I.Moiseev";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 303);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(191, 15);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email: i.moiseev.1988@iocorp.com";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(204, 338);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(115, 15);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "GNU v3.0  2023-2023";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Location = new System.Drawing.Point(12, 338);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(24, 15);
            this.GitLinkLabel.TabIndex = 5;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "GIT";
            this.GitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(59, 57);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(206, 15);
            this.WarningLabel.TabIndex = 6;
            this.WarningLabel.Text = "Use this application at your own risk";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 362);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.GitLinkLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.NameAndVersionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameAndVersionLabel;
        private Label DeveloperLabel;
        private Label EmailLabel;
        private Label YearLabel;
        private LinkLabel GitLinkLabel;
        private Label WarningLabel;
    }
}