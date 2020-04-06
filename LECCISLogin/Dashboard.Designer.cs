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
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addOwnerButton = new System.Windows.Forms.Button();
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainGroupBox.Controls.Add(this.mainTitleLabel);
            this.mainGroupBox.Controls.Add(this.addPropertyButton);
            this.mainGroupBox.Controls.Add(this.searchButton);
            this.mainGroupBox.Controls.Add(this.addOwnerButton);
            this.mainGroupBox.Location = new System.Drawing.Point(424, 64);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(1892, 1180);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.Location = new System.Drawing.Point(705, 82);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(482, 63);
            this.mainTitleLabel.TabIndex = 3;
            this.mainTitleLabel.Text = "Officer Dashboard";
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPropertyButton.Location = new System.Drawing.Point(1303, 336);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(429, 191);
            this.addPropertyButton.TabIndex = 2;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(160, 336);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(429, 191);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search for Record";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.UseWaitCursor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addOwnerButton
            // 
            this.addOwnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOwnerButton.Location = new System.Drawing.Point(733, 336);
            this.addOwnerButton.Name = "addOwnerButton";
            this.addOwnerButton.Size = new System.Drawing.Size(429, 191);
            this.addOwnerButton.TabIndex = 1;
            this.addOwnerButton.Text = "Add Owner";
            this.addOwnerButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2740, 1781);
            this.Controls.Add(this.mainGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1974, 1341);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addOwnerButton;
    }
}