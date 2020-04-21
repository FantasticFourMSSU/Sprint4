namespace LECCISSearch
{
  partial class searchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchPropertyStreetTextBox = new System.Windows.Forms.TextBox();
            this.searchPropertyStreetLabel = new System.Windows.Forms.Label();
            this.searchPropertyLabel = new System.Windows.Forms.Label();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchOwner = new System.Windows.Forms.TextBox();
            this.searchButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(409, 23);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(64, 24);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPropertyStreetTextBox
            // 
            this.searchPropertyStreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetTextBox.Location = new System.Drawing.Point(218, 23);
            this.searchPropertyStreetTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchPropertyStreetTextBox.Name = "searchPropertyStreetTextBox";
            this.searchPropertyStreetTextBox.Size = new System.Drawing.Size(172, 26);
            this.searchPropertyStreetTextBox.TabIndex = 0;
            this.searchPropertyStreetTextBox.TextChanged += new System.EventHandler(this.searchPropertyStreetTextBox_TextChanged);
            this.searchPropertyStreetTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_keyDown);
            // 
            // searchPropertyStreetLabel
            // 
            this.searchPropertyStreetLabel.AutoSize = true;
            this.searchPropertyStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetLabel.Location = new System.Drawing.Point(18, 25);
            this.searchPropertyStreetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchPropertyStreetLabel.Name = "searchPropertyStreetLabel";
            this.searchPropertyStreetLabel.Size = new System.Drawing.Size(187, 20);
            this.searchPropertyStreetLabel.TabIndex = 4;
            this.searchPropertyStreetLabel.Text = "Search Name or Property";
            // 
            // searchPropertyLabel
            // 
            this.searchPropertyLabel.AutoSize = true;
            this.searchPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyLabel.Location = new System.Drawing.Point(190, 8);
            this.searchPropertyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchPropertyLabel.Name = "searchPropertyLabel";
            this.searchPropertyLabel.Size = new System.Drawing.Size(0, 20);
            this.searchPropertyLabel.TabIndex = 8;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(22, 58);
            this.resultsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 82;
            this.resultsDataGridView.RowTemplate.Height = 33;
            this.resultsDataGridView.Size = new System.Drawing.Size(878, 202);
            this.resultsDataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton2);
            this.groupBox1.Controls.Add(this.searchOwner);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resultsDataGridView);
            this.groupBox1.Controls.Add(this.searchPropertyLabel);
            this.groupBox1.Controls.Add(this.searchPropertyStreetTextBox);
            this.groupBox1.Controls.Add(this.searchPropertyStreetLabel);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(914, 296);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Owner Only ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchOwner
            // 
            this.searchOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwner.Location = new System.Drawing.Point(675, 25);
            this.searchOwner.Margin = new System.Windows.Forms.Padding(2);
            this.searchOwner.Name = "searchOwner";
            this.searchOwner.Size = new System.Drawing.Size(137, 26);
            this.searchOwner.TabIndex = 10;
            // 
            // searchButton2
            // 
            this.searchButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton2.Location = new System.Drawing.Point(836, 25);
            this.searchButton2.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(64, 24);
            this.searchButton2.TabIndex = 11;
            this.searchButton2.Text = "Search";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(935, 320);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.TextBox searchPropertyStreetTextBox;
    private System.Windows.Forms.Label searchPropertyStreetLabel;
    private System.Windows.Forms.Label searchPropertyLabel;
    private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchOwner;
        private System.Windows.Forms.Button searchButton2;
    }
}

