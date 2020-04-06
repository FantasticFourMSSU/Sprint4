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
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1227, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 50);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPropertyStreetTextBox
            // 
            this.searchPropertyStreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetTextBox.Location = new System.Drawing.Point(747, 55);
            this.searchPropertyStreetTextBox.Name = "searchPropertyStreetTextBox";
            this.searchPropertyStreetTextBox.Size = new System.Drawing.Size(438, 44);
            this.searchPropertyStreetTextBox.TabIndex = 0;
            this.searchPropertyStreetTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_keyDown);
            // 
            // searchPropertyStreetLabel
            // 
            this.searchPropertyStreetLabel.AutoSize = true;
            this.searchPropertyStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetLabel.Location = new System.Drawing.Point(339, 55);
            this.searchPropertyStreetLabel.Name = "searchPropertyStreetLabel";
            this.searchPropertyStreetLabel.Size = new System.Drawing.Size(380, 37);
            this.searchPropertyStreetLabel.TabIndex = 4;
            this.searchPropertyStreetLabel.Text = "Search Name or Property";
            // 
            // searchPropertyLabel
            // 
            this.searchPropertyLabel.AutoSize = true;
            this.searchPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyLabel.Location = new System.Drawing.Point(380, 16);
            this.searchPropertyLabel.Name = "searchPropertyLabel";
            this.searchPropertyLabel.Size = new System.Drawing.Size(0, 37);
            this.searchPropertyLabel.TabIndex = 8;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(45, 121);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 82;
            this.resultsDataGridView.RowTemplate.Height = 33;
            this.resultsDataGridView.Size = new System.Drawing.Size(1756, 421);
            this.resultsDataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultsDataGridView);
            this.groupBox1.Controls.Add(this.searchPropertyLabel);
            this.groupBox1.Controls.Add(this.searchPropertyStreetTextBox);
            this.groupBox1.Controls.Add(this.searchPropertyStreetLabel);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1827, 615);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1870, 667);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

