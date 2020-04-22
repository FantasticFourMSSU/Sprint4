﻿namespace LECCISSearch
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
            this.searchPropertyNameOrOwnerTextBox = new System.Windows.Forms.TextBox();
            this.searchPropertyLabel = new System.Windows.Forms.Label();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchNameOrPropertyCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchOwnerOnlyCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(584, 23);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(64, 24);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPropertyNameOrOwnerTextBox
            // 
            this.searchPropertyNameOrOwnerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyNameOrOwnerTextBox.Location = new System.Drawing.Point(374, 18);
            this.searchPropertyNameOrOwnerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPropertyNameOrOwnerTextBox.Name = "searchPropertyNameOrOwnerTextBox";
            this.searchPropertyNameOrOwnerTextBox.Size = new System.Drawing.Size(172, 26);
            this.searchPropertyNameOrOwnerTextBox.TabIndex = 0;
            this.searchPropertyNameOrOwnerTextBox.TextChanged += new System.EventHandler(this.searchPropertyStreetTextBox_TextChanged);
            this.searchPropertyNameOrOwnerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_keyDown);
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
            this.resultsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 82;
            this.resultsDataGridView.RowTemplate.Height = 33;
            this.resultsDataGridView.Size = new System.Drawing.Size(878, 202);
            this.resultsDataGridView.TabIndex = 2;
            this.resultsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchOwnerOnlyCheckbox);
            this.groupBox1.Controls.Add(this.SearchNameOrPropertyCheckbox);
            this.groupBox1.Controls.Add(this.resultsDataGridView);
            this.groupBox1.Controls.Add(this.searchPropertyLabel);
            this.groupBox1.Controls.Add(this.searchPropertyNameOrOwnerTextBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(914, 296);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // SearchNameOrPropertyCheckbox
            // 
            this.SearchNameOrPropertyCheckbox.AutoSize = true;
            this.SearchNameOrPropertyCheckbox.Location = new System.Drawing.Point(177, 8);
            this.SearchNameOrPropertyCheckbox.Name = "SearchNameOrPropertyCheckbox";
            this.SearchNameOrPropertyCheckbox.Size = new System.Drawing.Size(162, 16);
            this.SearchNameOrPropertyCheckbox.TabIndex = 9;
            this.SearchNameOrPropertyCheckbox.Text = "Search Name Or Property";
            this.SearchNameOrPropertyCheckbox.UseVisualStyleBackColor = true;
            // 
            // SearchOwnerOnlyCheckbox
            // 
            this.SearchOwnerOnlyCheckbox.AutoSize = true;
            this.SearchOwnerOnlyCheckbox.Location = new System.Drawing.Point(177, 31);
            this.SearchOwnerOnlyCheckbox.Name = "SearchOwnerOnlyCheckbox";
            this.SearchOwnerOnlyCheckbox.Size = new System.Drawing.Size(126, 16);
            this.SearchOwnerOnlyCheckbox.TabIndex = 10;
            this.SearchOwnerOnlyCheckbox.Text = "Search Owner Only";
            this.SearchOwnerOnlyCheckbox.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    private System.Windows.Forms.TextBox searchPropertyNameOrOwnerTextBox;
    private System.Windows.Forms.Label searchPropertyLabel;
    private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SearchOwnerOnlyCheckbox;
        private System.Windows.Forms.CheckBox SearchNameOrPropertyCheckbox;
    }
}

