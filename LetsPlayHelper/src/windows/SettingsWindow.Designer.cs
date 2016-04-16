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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playTimeBox = new System.Windows.Forms.NumericUpDown();
            this.playSoundcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skypeCheckBox = new System.Windows.Forms.CheckBox();
            this.TScheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changelogBrowser = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.availVersionLabel = new System.Windows.Forms.Label();
            this.availVersionDescLabel = new System.Windows.Forms.Label();
            this.currentVersionDescLabel = new System.Windows.Forms.Label();
            this.checkForButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playTimeBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.updateTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTabPage);
            this.tabControl1.Controls.Add(this.updateTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.groupBox3);
            this.mainTabPage.Controls.Add(this.groupBox1);
            this.mainTabPage.Controls.Add(this.searchButton);
            this.mainTabPage.Controls.Add(this.pathTextBox);
            this.mainTabPage.Controls.Add(this.label1);
            this.mainTabPage.Controls.Add(this.saveButton);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(468, 384);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.playTimeBox);
            this.groupBox3.Controls.Add(this.playSoundcheckBox);
            this.groupBox3.Location = new System.Drawing.Point(240, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 69);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "minute(s).";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Play sound after";
            // 
            // playTimeBox
            // 
            this.playTimeBox.Location = new System.Drawing.Point(95, 44);
            this.playTimeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playTimeBox.Name = "playTimeBox";
            this.playTimeBox.Size = new System.Drawing.Size(45, 20);
            this.playTimeBox.TabIndex = 10;
            this.playTimeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // playSoundcheckBox
            // 
            this.playSoundcheckBox.AutoSize = true;
            this.playSoundcheckBox.Location = new System.Drawing.Point(9, 19);
            this.playSoundcheckBox.Name = "playSoundcheckBox";
            this.playSoundcheckBox.Size = new System.Drawing.Size(139, 17);
            this.playSoundcheckBox.TabIndex = 6;
            this.playSoundcheckBox.Text = "Enable Skype auto AFK";
            this.playSoundcheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.skypeCheckBox);
            this.groupBox1.Controls.Add(this.TScheckBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional features";
            // 
            // skypeCheckBox
            // 
            this.skypeCheckBox.AutoSize = true;
            this.skypeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.skypeCheckBox.Name = "skypeCheckBox";
            this.skypeCheckBox.Size = new System.Drawing.Size(139, 17);
            this.skypeCheckBox.TabIndex = 6;
            this.skypeCheckBox.Text = "Enable Skype auto AFK";
            this.skypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TScheckBox
            // 
            this.TScheckBox.AutoSize = true;
            this.TScheckBox.Enabled = false;
            this.TScheckBox.Location = new System.Drawing.Point(6, 42);
            this.TScheckBox.Name = "TScheckBox";
            this.TScheckBox.Size = new System.Drawing.Size(181, 17);
            this.TScheckBox.TabIndex = 7;
            this.TScheckBox.Text = "Enable TeamSpeak 3 Auto Mute";
            this.toolTip1.SetToolTip(this.TScheckBox, "Feature will be implemented later");
            this.TScheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(401, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(101, 9);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(291, 20);
            this.pathTextBox.TabIndex = 4;
            this.pathTextBox.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
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
            // updateTabPage
            // 
            this.updateTabPage.Controls.Add(this.groupBox2);
            this.updateTabPage.Controls.Add(this.label2);
            this.updateTabPage.Controls.Add(this.pictureBox1);
            this.updateTabPage.Controls.Add(this.currentVersionLabel);
            this.updateTabPage.Controls.Add(this.availVersionLabel);
            this.updateTabPage.Controls.Add(this.availVersionDescLabel);
            this.updateTabPage.Controls.Add(this.currentVersionDescLabel);
            this.updateTabPage.Controls.Add(this.checkForButton);
            this.updateTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Size = new System.Drawing.Size(468, 384);
            this.updateTabPage.TabIndex = 1;
            this.updateTabPage.Text = "Update";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changelogBrowser);
            this.groupBox2.Location = new System.Drawing.Point(8, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 275);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latest changelog:";
            // 
            // changelogBrowser
            // 
            this.changelogBrowser.Location = new System.Drawing.Point(8, 15);
            this.changelogBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.changelogBrowser.Name = "changelogBrowser";
            this.changelogBrowser.Size = new System.Drawing.Size(439, 254);
            this.changelogBrowser.TabIndex = 1;
            this.changelogBrowser.Url = new System.Uri("http://31.214.243.215/LPH/changelog.txt", System.UriKind.Absolute);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "LPH - Let\'s Play Helper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LetsPlayHelper.Properties.Resources.logoICO;
            this.pictureBox1.Location = new System.Drawing.Point(418, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPH - Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playTimeBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.updateTabPage.ResumeLayout(false);
            this.updateTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox playSoundcheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown playTimeBox;
    }
}