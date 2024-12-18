﻿namespace FolderWatchdog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            enabledToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            settingsGroupBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            enabledCheckBox = new CheckBox();
            watchSubdirectoriesCheckBox = new CheckBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            directoryLabel = new Label();
            directoryTextBox = new TextBox();
            browseButton = new Button();
            filtersGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            onChangedEventCheckBox = new CheckBox();
            onCreatedEventCheckBox = new CheckBox();
            onDeletedEventCheckBox = new CheckBox();
            onRenamedEventCheckBox = new CheckBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            filterLabel = new Label();
            filterTextBox = new TextBox();
            filterInfoLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            saveButton = new Button();
            cancelButton = new Button();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            settingsGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            filtersGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Folder Watchdog";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += IconMouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { enabledToolStripMenuItem, settingsToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowCheckMargin = true;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(117, 70);
            // 
            // enabledToolStripMenuItem
            // 
            enabledToolStripMenuItem.CheckOnClick = true;
            enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            enabledToolStripMenuItem.Size = new Size(116, 22);
            enabledToolStripMenuItem.Text = "Enabled";
            enabledToolStripMenuItem.CheckedChanged += ToggleEnabledAndSave;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += ShowMainWindow;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitApplication;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(settingsGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(filtersGroupBox, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.50495F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.49505F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(560, 337);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.Controls.Add(tableLayoutPanel3);
            settingsGroupBox.Location = new Point(3, 3);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Size = new Size(554, 144);
            settingsGroupBox.TabIndex = 0;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7822876F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.21771F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel5, 1, 0);
            tableLayoutPanel3.Location = new Point(6, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(542, 116);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(enabledCheckBox);
            flowLayoutPanel4.Controls.Add(watchSubdirectoriesCheckBox);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(150, 110);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // enabledCheckBox
            // 
            enabledCheckBox.AutoSize = true;
            enabledCheckBox.Location = new Point(3, 3);
            enabledCheckBox.Name = "enabledCheckBox";
            enabledCheckBox.Size = new Size(68, 19);
            enabledCheckBox.TabIndex = 0;
            enabledCheckBox.Text = "Enabled";
            enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // watchSubdirectoriesCheckBox
            // 
            watchSubdirectoriesCheckBox.AutoSize = true;
            watchSubdirectoriesCheckBox.Location = new Point(3, 28);
            watchSubdirectoriesCheckBox.Name = "watchSubdirectoriesCheckBox";
            watchSubdirectoriesCheckBox.Size = new Size(137, 19);
            watchSubdirectoriesCheckBox.TabIndex = 5;
            watchSubdirectoriesCheckBox.Text = "Watch subdirectories";
            watchSubdirectoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(directoryLabel);
            flowLayoutPanel5.Controls.Add(directoryTextBox);
            flowLayoutPanel5.Controls.Add(browseButton);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(159, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(380, 110);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // directoryLabel
            // 
            directoryLabel.AutoSize = true;
            directoryLabel.Location = new Point(3, 0);
            directoryLabel.Name = "directoryLabel";
            directoryLabel.Size = new Size(107, 15);
            directoryLabel.TabIndex = 1;
            directoryLabel.Text = "Directory to watch:";
            // 
            // directoryTextBox
            // 
            directoryTextBox.Location = new Point(3, 18);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(389, 23);
            directoryTextBox.TabIndex = 2;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(3, 47);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 3;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += BrowseDirectories;
            // 
            // filtersGroupBox
            // 
            filtersGroupBox.Controls.Add(tableLayoutPanel2);
            filtersGroupBox.Location = new Point(3, 153);
            filtersGroupBox.Name = "filtersGroupBox";
            filtersGroupBox.Size = new Size(554, 147);
            filtersGroupBox.TabIndex = 1;
            filtersGroupBox.TabStop = false;
            filtersGroupBox.Text = "Filters";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.15129F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.84871F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(542, 119);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(onChangedEventCheckBox);
            flowLayoutPanel2.Controls.Add(onCreatedEventCheckBox);
            flowLayoutPanel2.Controls.Add(onDeletedEventCheckBox);
            flowLayoutPanel2.Controls.Add(onRenamedEventCheckBox);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(152, 113);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // onChangedEventCheckBox
            // 
            onChangedEventCheckBox.AutoSize = true;
            onChangedEventCheckBox.Location = new Point(3, 3);
            onChangedEventCheckBox.Name = "onChangedEventCheckBox";
            onChangedEventCheckBox.Size = new Size(72, 19);
            onChangedEventCheckBox.TabIndex = 0;
            onChangedEventCheckBox.Tag = "OnChanged";
            onChangedEventCheckBox.Text = "Changes";
            onChangedEventCheckBox.UseVisualStyleBackColor = true;
            // 
            // onCreatedEventCheckBox
            // 
            onCreatedEventCheckBox.AutoSize = true;
            onCreatedEventCheckBox.Location = new Point(3, 28);
            onCreatedEventCheckBox.Name = "onCreatedEventCheckBox";
            onCreatedEventCheckBox.Size = new Size(76, 19);
            onCreatedEventCheckBox.TabIndex = 1;
            onCreatedEventCheckBox.Tag = "OnCreated";
            onCreatedEventCheckBox.Text = "Creations";
            onCreatedEventCheckBox.UseVisualStyleBackColor = true;
            // 
            // onDeletedEventCheckBox
            // 
            onDeletedEventCheckBox.AutoSize = true;
            onDeletedEventCheckBox.Location = new Point(3, 53);
            onDeletedEventCheckBox.Name = "onDeletedEventCheckBox";
            onDeletedEventCheckBox.Size = new Size(75, 19);
            onDeletedEventCheckBox.TabIndex = 2;
            onDeletedEventCheckBox.Tag = "OnDeleted";
            onDeletedEventCheckBox.Text = "Deletions";
            onDeletedEventCheckBox.UseVisualStyleBackColor = true;
            // 
            // onRenamedEventCheckBox
            // 
            onRenamedEventCheckBox.AutoSize = true;
            onRenamedEventCheckBox.Location = new Point(3, 78);
            onRenamedEventCheckBox.Name = "onRenamedEventCheckBox";
            onRenamedEventCheckBox.Size = new Size(74, 19);
            onRenamedEventCheckBox.TabIndex = 3;
            onRenamedEventCheckBox.Tag = "OnRenamed";
            onRenamedEventCheckBox.Text = "Renames";
            onRenamedEventCheckBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(filterLabel);
            flowLayoutPanel3.Controls.Add(filterTextBox);
            flowLayoutPanel3.Controls.Add(filterInfoLabel);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(161, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(378, 113);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Location = new Point(3, 0);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(165, 15);
            filterLabel.TabIndex = 0;
            filterLabel.Text = "File name and extension filter:";
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(3, 18);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(375, 23);
            filterTextBox.TabIndex = 1;
            // 
            // filterInfoLabel
            // 
            filterInfoLabel.AutoSize = true;
            filterInfoLabel.Location = new Point(3, 44);
            filterInfoLabel.Name = "filterInfoLabel";
            filterInfoLabel.Size = new Size(364, 45);
            filterInfoLabel.TabIndex = 2;
            filterInfoLabel.Text = "Filter files to watch using * (any characters) and ? (single character), e.g., *.txt for text files.\r\nLeave empty for all files.\r\n";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(saveButton);
            flowLayoutPanel1.Controls.Add(cancelButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 306);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(554, 27);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(476, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveSettings;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(395, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CloseSettings;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Settings";
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            settingsGroupBox.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            filtersGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem enabledToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox settingsGroupBox;
        private GroupBox filtersGroupBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button saveButton;
        private Button cancelButton;
        private FlowLayoutPanel flowLayoutPanel4;
        private CheckBox enabledCheckBox;
        private CheckBox watchSubdirectoriesCheckBox;
        private Label directoryLabel;
        private TextBox directoryTextBox;
        private Button browseButton;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox onChangedEventCheckBox;
        private CheckBox onCreatedEventCheckBox;
        private CheckBox onDeletedEventCheckBox;
        private CheckBox onRenamedEventCheckBox;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label filterLabel;
        private TextBox filterTextBox;
        private Label filterInfoLabel;
    }
}
