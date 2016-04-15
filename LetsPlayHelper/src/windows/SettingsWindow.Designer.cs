namespace LetsPlayHelper.src.windows
{
    partial class SettingsWindow
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.TScheckBox = new System.Windows.Forms.CheckBox();
            this.skypeCheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.recDiskLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.availVersionLabel = new System.Windows.Forms.Label();
            this.changeLogLabel = new System.Windows.Forms.Label();
            this.availVersionDescLabel = new System.Windows.Forms.Label();
            this.currentVersionDescLabel = new System.Windows.Forms.Label();
            this.changelogBrowser = new System.Windows.Forms.WebBrowser();
            this.checkForButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.updateTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTabPage);
            this.tabControl1.Controls.Add(this.updateTabPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.TScheckBox);
            this.mainTabPage.Controls.Add(this.skypeCheckBox);
            this.mainTabPage.Controls.Add(this.searchButton);
            this.mainTabPage.Controls.Add(this.pathTextBox);
            this.mainTabPage.Controls.Add(this.label1);
            this.mainTabPage.Controls.Add(this.saveButton);
            this.mainTabPage.Controls.Add(this.recDiskLabel);
            this.mainTabPage.Controls.Add(this.comboBox1);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(467, 387);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // TScheckBox
            // 
            this.TScheckBox.AutoSize = true;
            this.TScheckBox.Enabled = false;
            this.TScheckBox.Location = new System.Drawing.Point(10, 118);
            this.TScheckBox.Name = "TScheckBox";
            this.TScheckBox.Size = new System.Drawing.Size(181, 17);
            this.TScheckBox.TabIndex = 7;
            this.TScheckBox.Text = "Enable TeamSpeak 3 Auto Mute";
            this.toolTip1.SetToolTip(this.TScheckBox, "Feature will be implemented later");
            this.TScheckBox.UseVisualStyleBackColor = true;
            // 
            // skypeCheckBox
            // 
            this.skypeCheckBox.AutoSize = true;
            this.skypeCheckBox.Location = new System.Drawing.Point(10, 95);
            this.skypeCheckBox.Name = "skypeCheckBox";
            this.skypeCheckBox.Size = new System.Drawing.Size(139, 17);
            this.skypeCheckBox.TabIndex = 6;
            this.skypeCheckBox.Text = "Enable Skype auto AFK";
            this.skypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(401, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(101, 48);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(291, 20);
            this.pathTextBox.TabIndex = 4;
            this.pathTextBox.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recording folder:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save and close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // recDiskLabel
            // 
            this.recDiskLabel.AutoSize = true;
            this.recDiskLabel.Location = new System.Drawing.Point(7, 19);
            this.recDiskLabel.Name = "recDiskLabel";
            this.recDiskLabel.Size = new System.Drawing.Size(81, 13);
            this.recDiskLabel.TabIndex = 1;
            this.recDiskLabel.Text = "Recording disk:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A:",
            "B:",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:",
            "K:",
            "L:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "X:",
            "Y:",
            "Z:"});
            this.comboBox1.Location = new System.Drawing.Point(101, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Controls.Add(this.currentVersionLabel);
            this.updateTabPage.Controls.Add(this.availVersionLabel);
            this.updateTabPage.Controls.Add(this.changeLogLabel);
            this.updateTabPage.Controls.Add(this.availVersionDescLabel);
            this.updateTabPage.Controls.Add(this.currentVersionDescLabel);
            this.updateTabPage.Controls.Add(this.changelogBrowser);
            this.updateTabPage.Controls.Add(this.checkForButton);
            this.updateTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Size = new System.Drawing.Size(467, 387);
            this.updateTabPage.TabIndex = 1;
            this.updateTabPage.Text = "Update";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVersionLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.currentVersionLabel.Location = new System.Drawing.Point(127, 50);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(31, 16);
            this.currentVersionLabel.TabIndex = 6;
            this.currentVersionLabel.Text = "v1.0";
            // 
            // availVersionLabel
            // 
            this.availVersionLabel.AutoSize = true;
            this.availVersionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availVersionLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.availVersionLabel.Location = new System.Drawing.Point(127, 82);
            this.availVersionLabel.Name = "availVersionLabel";
            this.availVersionLabel.Size = new System.Drawing.Size(180, 16);
            this.availVersionLabel.TabIndex = 5;
            this.availVersionLabel.Text = "Please check for updates first";
            // 
            // changeLogLabel
            // 
            this.changeLogLabel.AutoSize = true;
            this.changeLogLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.changeLogLabel.Location = new System.Drawing.Point(23, 115);
            this.changeLogLabel.Name = "changeLogLabel";
            this.changeLogLabel.Size = new System.Drawing.Size(111, 16);
            this.changeLogLabel.TabIndex = 4;
            this.changeLogLabel.Text = "Latest changelog:";
            // 
            // availVersionDescLabel
            // 
            this.availVersionDescLabel.AutoSize = true;
            this.availVersionDescLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.availVersionDescLabel.Location = new System.Drawing.Point(22, 82);
            this.availVersionDescLabel.Name = "availVersionDescLabel";
            this.availVersionDescLabel.Size = new System.Drawing.Size(107, 16);
            this.availVersionDescLabel.TabIndex = 3;
            this.availVersionDescLabel.Text = "Available version:";
            // 
            // currentVersionDescLabel
            // 
            this.currentVersionDescLabel.AutoSize = true;
            this.currentVersionDescLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVersionDescLabel.Location = new System.Drawing.Point(23, 50);
            this.currentVersionDescLabel.Name = "currentVersionDescLabel";
            this.currentVersionDescLabel.Size = new System.Drawing.Size(98, 16);
            this.currentVersionDescLabel.TabIndex = 2;
            this.currentVersionDescLabel.Text = "Current version:";
            // 
            // changelogBrowser
            // 
            this.changelogBrowser.Location = new System.Drawing.Point(16, 134);
            this.changelogBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.changelogBrowser.Name = "changelogBrowser";
            this.changelogBrowser.Size = new System.Drawing.Size(434, 250);
            this.changelogBrowser.TabIndex = 1;
            this.changelogBrowser.Url = new System.Uri("http://31.214.243.215/LPH/changelog.txt", System.UriKind.Absolute);
            // 
            // checkForButton
            // 
            this.checkForButton.Location = new System.Drawing.Point(16, 14);
            this.checkForButton.Name = "checkForButton";
            this.checkForButton.Size = new System.Drawing.Size(113, 23);
            this.checkForButton.TabIndex = 0;
            this.checkForButton.Text = "Check for updates";
            this.checkForButton.UseVisualStyleBackColor = true;
            this.checkForButton.Click += new System.EventHandler(this.checkForButton_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 410);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsWindow";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            this.updateTabPage.ResumeLayout(false);
            this.updateTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage updateTabPage;
        private System.Windows.Forms.Label availVersionDescLabel;
        private System.Windows.Forms.Label currentVersionDescLabel;
        private System.Windows.Forms.WebBrowser changelogBrowser;
        private System.Windows.Forms.Button checkForButton;
        private System.Windows.Forms.Label changeLogLabel;
        private System.Windows.Forms.Label recDiskLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label availVersionLabel;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox TScheckBox;
        private System.Windows.Forms.CheckBox skypeCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}