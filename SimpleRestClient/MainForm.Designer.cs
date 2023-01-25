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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SimpleRequest");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Examples", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RequestTreeView = new System.Windows.Forms.TreeView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NewRequestFolderButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.NewRequestButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.saveRequestButton = new System.Windows.Forms.Button();
            this.sendRequestBbutton = new System.Windows.Forms.Button();
            this.URITextBox = new System.Windows.Forms.TextBox();
            this.RequestNameLabel = new System.Windows.Forms.Label();
            this.requestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestTypeComboBox
            // 
            this.requestTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.requestTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestTypeComboBox.FormattingEnabled = true;
            this.requestTypeComboBox.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.requestTypeComboBox.Location = new System.Drawing.Point(3, 33);
            this.requestTypeComboBox.Name = "requestTypeComboBox";
            this.requestTypeComboBox.Size = new System.Drawing.Size(84, 23);
            this.requestTypeComboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.preferenceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideSidebarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hideSidebarToolStripMenuItem
            // 
            this.hideSidebarToolStripMenuItem.Name = "hideSidebarToolStripMenuItem";
            this.hideSidebarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hideSidebarToolStripMenuItem.Text = "Hide sidebar";
            this.hideSidebarToolStripMenuItem.Click += new System.EventHandler(this.hideSidebarToolStripMenuItem_Click);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.preferenceToolStripMenuItem.Text = "Preference";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.mainToolStripMenuItem.Text = "Main";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RequestTreeView);
            this.splitContainer1.Panel1.Controls.Add(this.SearchButton);
            this.splitContainer1.Panel1.Controls.Add(this.NewRequestFolderButton);
            this.splitContainer1.Panel1.Controls.Add(this.searchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.NewRequestButton);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.saveRequestButton);
            this.splitContainer1.Panel2.Controls.Add(this.sendRequestBbutton);
            this.splitContainer1.Panel2.Controls.Add(this.URITextBox);
            this.splitContainer1.Panel2.Controls.Add(this.RequestNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.requestTypeComboBox);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(976, 538);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 1;
            // 
            // RequestTreeView
            // 
            this.RequestTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequestTreeView.Location = new System.Drawing.Point(3, 61);
            this.RequestTreeView.Name = "RequestTreeView";
            treeNode3.Name = "Node1";
            treeNode3.Text = "SimpleRequest";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Examples";
            this.RequestTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.RequestTreeView.Size = new System.Drawing.Size(172, 472);
            this.RequestTreeView.TabIndex = 1;
            this.RequestTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.RequestTreeView_NodeDoubleClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(120, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(55, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // NewRequestFolderButton
            // 
            this.NewRequestFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewRequestFolderButton.Location = new System.Drawing.Point(2, 32);
            this.NewRequestFolderButton.Name = "NewRequestFolderButton";
            this.NewRequestFolderButton.Size = new System.Drawing.Size(78, 23);
            this.NewRequestFolderButton.TabIndex = 5;
            this.NewRequestFolderButton.Text = "New folder";
            this.NewRequestFolderButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(111, 23);
            this.searchTextBox.TabIndex = 0;
            // 
            // NewRequestButton
            // 
            this.NewRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewRequestButton.Location = new System.Drawing.Point(88, 32);
            this.NewRequestButton.Name = "NewRequestButton";
            this.NewRequestButton.Size = new System.Drawing.Size(87, 23);
            this.NewRequestButton.TabIndex = 4;
            this.NewRequestButton.Text = "New Request";
            this.NewRequestButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(3, 61);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(784, 472);
            this.splitContainer2.SplitterDistance = 373;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer3.Size = new System.Drawing.Size(373, 472);
            this.splitContainer3.SplitterDistance = 88;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer4.Size = new System.Drawing.Size(407, 472);
            this.splitContainer4.SplitterDistance = 88;
            this.splitContainer4.TabIndex = 0;
            // 
            // saveRequestButton
            // 
            this.saveRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveRequestButton.Location = new System.Drawing.Point(712, 5);
            this.saveRequestButton.Name = "saveRequestButton";
            this.saveRequestButton.Size = new System.Drawing.Size(75, 23);
            this.saveRequestButton.TabIndex = 4;
            this.saveRequestButton.Text = "Save";
            this.saveRequestButton.UseVisualStyleBackColor = true;
            // 
            // sendRequestBbutton
            // 
            this.sendRequestBbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendRequestBbutton.Location = new System.Drawing.Point(712, 33);
            this.sendRequestBbutton.Name = "sendRequestBbutton";
            this.sendRequestBbutton.Size = new System.Drawing.Size(75, 23);
            this.sendRequestBbutton.TabIndex = 3;
            this.sendRequestBbutton.Text = "Send";
            this.sendRequestBbutton.UseVisualStyleBackColor = true;
            // 
            // URITextBox
            // 
            this.URITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URITextBox.Location = new System.Drawing.Point(93, 33);
            this.URITextBox.Name = "URITextBox";
            this.URITextBox.Size = new System.Drawing.Size(613, 23);
            this.URITextBox.TabIndex = 2;
            this.URITextBox.Text = "Enter URI: http://localhost:8080/RestApi";
            // 
            // RequestNameLabel
            // 
            this.RequestNameLabel.AutoSize = true;
            this.RequestNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RequestNameLabel.Location = new System.Drawing.Point(3, 5);
            this.RequestNameLabel.Name = "RequestNameLabel";
            this.RequestNameLabel.Size = new System.Drawing.Size(134, 21);
            this.RequestNameLabel.TabIndex = 1;
            this.RequestNameLabel.Text = "Untitled request";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "MainForm";
            this.Text = "Simple Rest Client v0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem preferenceToolStripMenuItem;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Button SearchButton;
        private TextBox searchTextBox;
        private TreeView RequestTreeView;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem hideSidebarToolStripMenuItem;
        private Button NewRequestFolderButton;
        private Button NewRequestButton;
        private ComboBox requestTypeComboBox;
        private Button sendRequestBbutton;
        private TextBox URITextBox;
        private Label RequestNameLabel;
        private Button saveRequestButton;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
    }
}