namespace LECCISLogin
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.addRecordPanel = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.addOwnerButton = new System.Windows.Forms.Button();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.editRecordButton = new System.Windows.Forms.Button();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.logoutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mainGroupBox.SuspendLayout();
            this.addRecordPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainGroupBox.Controls.Add(this.addRecordPanel);
            this.mainGroupBox.Controls.Add(this.mainTitleLabel);
            this.mainGroupBox.Controls.Add(this.searchButton);
            this.mainGroupBox.Controls.Add(this.editRecordButton);
            this.mainGroupBox.Controls.Add(this.addRecordButton);
            this.mainGroupBox.Location = new System.Drawing.Point(283, 41);
            this.mainGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainGroupBox.Size = new System.Drawing.Size(1261, 755);
            this.mainGroupBox.TabIndex = 4;
            this.mainGroupBox.TabStop = false;
            // 
            // addRecordPanel
            // 
            this.addRecordPanel.Controls.Add(this.returnButton);
            this.addRecordPanel.Controls.Add(this.addPropertyButton);
            this.addRecordPanel.Controls.Add(this.addOwnerButton);
            this.addRecordPanel.Location = new System.Drawing.Point(0, 104);
            this.addRecordPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecordPanel.Name = "addRecordPanel";
            this.addRecordPanel.Size = new System.Drawing.Size(1257, 648);
            this.addRecordPanel.TabIndex = 6;
            this.addRecordPanel.Visible = false;
            this.addRecordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addRecordPanel_Paint);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(531, 408);
            this.returnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(197, 47);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return to Dashboard";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPropertyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPropertyButton.Location = new System.Drawing.Point(679, 193);
            this.addPropertyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(286, 122);
            this.addPropertyButton.TabIndex = 3;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = false;
            this.addPropertyButton.Visible = false;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // addOwnerButton
            // 
            this.addOwnerButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addOwnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOwnerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOwnerButton.Location = new System.Drawing.Point(250, 193);
            this.addOwnerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addOwnerButton.Name = "addOwnerButton";
            this.addOwnerButton.Size = new System.Drawing.Size(286, 122);
            this.addOwnerButton.TabIndex = 4;
            this.addOwnerButton.Text = "Add Owner";
            this.addOwnerButton.UseVisualStyleBackColor = false;
            this.addOwnerButton.Visible = false;
            this.addOwnerButton.Click += new System.EventHandler(this.addOwnerButton_Click);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.Location = new System.Drawing.Point(470, 52);
            this.mainTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(309, 39);
            this.mainTitleLabel.TabIndex = 5;
            this.mainTitleLabel.Text = "Officer Dashboard";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(105, 215);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(286, 122);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search for Record";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // editRecordButton
            // 
            this.editRecordButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.editRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRecordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editRecordButton.Location = new System.Drawing.Point(871, 215);
            this.editRecordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editRecordButton.Name = "editRecordButton";
            this.editRecordButton.Size = new System.Drawing.Size(286, 122);
            this.editRecordButton.TabIndex = 5;
            this.editRecordButton.Text = "Modify a Record";
            this.editRecordButton.UseVisualStyleBackColor = false;
            // 
            // addRecordButton
            // 
            this.addRecordButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRecordButton.Location = new System.Drawing.Point(487, 215);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(286, 122);
            this.addRecordButton.TabIndex = 2;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = false;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1489, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // logoutToolStripLabel
            // 
            this.logoutToolStripLabel.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.logoutToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripLabel.Name = "logoutToolStripLabel";
            this.logoutToolStripLabel.Size = new System.Drawing.Size(84, 28);
            this.logoutToolStripLabel.Text = "Log out";
            this.logoutToolStripLabel.Click += new System.EventHandler(this.logoutToolStripLabel_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1489, 675);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1285, 675);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.addRecordPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel logoutToolStripLabel;
        private System.Windows.Forms.Panel addRecordPanel;
        private System.Windows.Forms.Button editRecordButton;
        private System.Windows.Forms.Button addOwnerButton;
        private System.Windows.Forms.Button returnButton;
    }
}