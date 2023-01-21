namespace SimpleRestClient
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGet = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxRequest = new System.Windows.Forms.GroupBox();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.groupBoxResponse = new System.Windows.Forms.GroupBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.panelCommand = new System.Windows.Forms.Panel();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.tabPagePost = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGet.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxRequest.SuspendLayout();
            this.groupBoxResponse.SuspendLayout();
            this.panelCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.загрузитьToolStripMenuItem.Text = "Load";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.сохранитьToolStripMenuItem.Text = "Save";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основноеToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.настройкиToolStripMenuItem.Text = "Preference";
            // 
            // основноеToolStripMenuItem
            // 
            this.основноеToolStripMenuItem.Name = "основноеToolStripMenuItem";
            this.основноеToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.основноеToolStripMenuItem.Text = "Main";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGet);
            this.tabControl.Controls.Add(this.tabPagePost);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(976, 538);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageGet
            // 
            this.tabPageGet.Controls.Add(this.panelMain);
            this.tabPageGet.Controls.Add(this.panelCommand);
            this.tabPageGet.Location = new System.Drawing.Point(4, 24);
            this.tabPageGet.Name = "tabPageGet";
            this.tabPageGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGet.Size = new System.Drawing.Size(968, 510);
            this.tabPageGet.TabIndex = 0;
            this.tabPageGet.Text = "GET";
            this.tabPageGet.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(962, 470);
            this.panelMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxRequest);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBoxResponse);
            this.splitContainer.Size = new System.Drawing.Size(962, 470);
            this.splitContainer.SplitterDistance = 235;
            this.splitContainer.TabIndex = 0;
            // 
            // groupBoxRequest
            // 
            this.groupBoxRequest.Controls.Add(this.textBoxRequest);
            this.groupBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRequest.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRequest.Name = "groupBoxRequest";
            this.groupBoxRequest.Size = new System.Drawing.Size(962, 235);
            this.groupBoxRequest.TabIndex = 0;
            this.groupBoxRequest.TabStop = false;
            this.groupBoxRequest.Text = "Request";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRequest.Location = new System.Drawing.Point(3, 19);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(956, 213);
            this.textBoxRequest.TabIndex = 0;
            // 
            // groupBoxResponse
            // 
            this.groupBoxResponse.Controls.Add(this.textBoxResponse);
            this.groupBoxResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResponse.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResponse.Name = "groupBoxResponse";
            this.groupBoxResponse.Size = new System.Drawing.Size(962, 231);
            this.groupBoxResponse.TabIndex = 1;
            this.groupBoxResponse.TabStop = false;
            this.groupBoxResponse.Text = "Response";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResponse.Location = new System.Drawing.Point(3, 19);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(956, 209);
            this.textBoxResponse.TabIndex = 0;
            // 
            // panelCommand
            // 
            this.panelCommand.Controls.Add(this.buttonExecute);
            this.panelCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommand.Location = new System.Drawing.Point(3, 473);
            this.panelCommand.Name = "panelCommand";
            this.panelCommand.Size = new System.Drawing.Size(962, 34);
            this.panelCommand.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecute.Location = new System.Drawing.Point(883, 5);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // tabPagePost
            // 
            this.tabPagePost.Location = new System.Drawing.Point(4, 24);
            this.tabPagePost.Name = "tabPagePost";
            this.tabPagePost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePost.Size = new System.Drawing.Size(968, 510);
            this.tabPagePost.TabIndex = 1;
            this.tabPagePost.Text = "POST";
            this.tabPagePost.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 562);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageGet.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxRequest.ResumeLayout(false);
            this.groupBoxRequest.PerformLayout();
            this.groupBoxResponse.ResumeLayout(false);
            this.groupBoxResponse.PerformLayout();
            this.panelCommand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem основноеToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl tabControl;
        private TabPage tabPageGet;
        private TabPage tabPagePost;
        private Panel panelMain;
        private Panel panelCommand;
        private SplitContainer splitContainer;
        private GroupBox groupBoxRequest;
        private Button buttonExecute;
        private TextBox textBoxRequest;
        private GroupBox groupBoxResponse;
        private TextBox textBoxResponse;
    }
}