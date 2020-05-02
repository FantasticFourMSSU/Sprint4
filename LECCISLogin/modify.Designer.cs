namespace LECCISLogin
{
    partial class modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modify));
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deletedataGridView = new System.Windows.Forms.DataGridView();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.editOwnerButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchOwnerOrPropertyTextbox = new System.Windows.Forms.TextBox();
            this.deleteOwnerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).BeginInit();
            this.modifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(699, 612);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(209, 56);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit Property";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(1188, 612);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(269, 56);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Property";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deletedataGridView
            // 
            this.deletedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedataGridView.Location = new System.Drawing.Point(21, 138);
            this.deletedataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletedataGridView.Name = "deletedataGridView";
            this.deletedataGridView.RowHeadersWidth = 51;
            this.deletedataGridView.RowTemplate.Height = 24;
            this.deletedataGridView.Size = new System.Drawing.Size(1716, 444);
            this.deletedataGridView.TabIndex = 2;
            this.deletedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletedataGridView_CellClick);
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.label2);
            this.modifyGroupBox.Controls.Add(this.deleteOwnerButton);
            this.modifyGroupBox.Controls.Add(this.editOwnerButton);
            this.modifyGroupBox.Controls.Add(this.deleteButton);
            this.modifyGroupBox.Controls.Add(this.showAllButton);
            this.modifyGroupBox.Controls.Add(this.button1);
            this.modifyGroupBox.Controls.Add(this.label1);
            this.modifyGroupBox.Controls.Add(this.editButton);
            this.modifyGroupBox.Controls.Add(this.SearchOwnerOrPropertyTextbox);
            this.modifyGroupBox.Controls.Add(this.deletedataGridView);
            this.modifyGroupBox.Location = new System.Drawing.Point(12, 61);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Size = new System.Drawing.Size(1769, 689);
            this.modifyGroupBox.TabIndex = 4;
            this.modifyGroupBox.TabStop = false;
            // 
            // editOwnerButton
            // 
            this.editOwnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOwnerButton.Location = new System.Drawing.Point(927, 612);
            this.editOwnerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editOwnerButton.Name = "editOwnerButton";
            this.editOwnerButton.Size = new System.Drawing.Size(190, 56);
            this.editOwnerButton.TabIndex = 13;
            this.editOwnerButton.Text = "Edit Owner";
            this.editOwnerButton.UseVisualStyleBackColor = true;
            this.editOwnerButton.Click += new System.EventHandler(this.editOwnerButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.Location = new System.Drawing.Point(1224, 66);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(244, 44);
            this.showAllButton.TabIndex = 8;
            this.showAllButton.Text = "Refresh";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(910, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Record";
            // 
            // SearchOwnerOrPropertyTextbox
            // 
            this.SearchOwnerOrPropertyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOwnerOrPropertyTextbox.Location = new System.Drawing.Point(473, 66);
            this.SearchOwnerOrPropertyTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchOwnerOrPropertyTextbox.Name = "SearchOwnerOrPropertyTextbox";
            this.SearchOwnerOrPropertyTextbox.Size = new System.Drawing.Size(416, 44);
            this.SearchOwnerOrPropertyTextbox.TabIndex = 5;
            // 
            // deleteOwnerButton
            // 
            this.deleteOwnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOwnerButton.Location = new System.Drawing.Point(1474, 612);
            this.deleteOwnerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteOwnerButton.Name = "deleteOwnerButton";
            this.deleteOwnerButton.Size = new System.Drawing.Size(263, 56);
            this.deleteOwnerButton.TabIndex = 14;
            this.deleteOwnerButton.Text = "Delete Owner";
            this.deleteOwnerButton.UseVisualStyleBackColor = true;
            this.deleteOwnerButton.Click += new System.EventHandler(this.deleteOwnerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1137, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 67);
            this.label2.TabIndex = 15;
            this.label2.Text = "|";
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1876, 810);
            this.Controls.Add(this.modifyGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).EndInit();
            this.modifyGroupBox.ResumeLayout(false);
            this.modifyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView deletedataGridView;
        private System.Windows.Forms.GroupBox modifyGroupBox;
        private System.Windows.Forms.TextBox SearchOwnerOrPropertyTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button editOwnerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteOwnerButton;
    }
}