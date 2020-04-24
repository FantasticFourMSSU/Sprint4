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
            this.showAllButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchOwnerOrPropertyTextbox = new System.Windows.Forms.TextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.textBoxCY = new System.Windows.Forms.TextBox();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxZP = new System.Windows.Forms.TextBox();
            this.textBoxST = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).BeginInit();
            this.modifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(845, 707);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(190, 56);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit Property";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(1295, 707);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(152, 56);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
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
            this.deletedataGridView.Size = new System.Drawing.Size(1496, 444);
            this.deletedataGridView.TabIndex = 2;
            this.deletedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletedataGridView_CellClick);
            this.deletedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.showAllButton);
            this.modifyGroupBox.Controls.Add(this.button1);
            this.modifyGroupBox.Controls.Add(this.label1);
            this.modifyGroupBox.Controls.Add(this.SearchOwnerOrPropertyTextbox);
            this.modifyGroupBox.Controls.Add(this.deletedataGridView);
            this.modifyGroupBox.Location = new System.Drawing.Point(16, 55);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Size = new System.Drawing.Size(1538, 644);
            this.modifyGroupBox.TabIndex = 4;
            this.modifyGroupBox.TabStop = false;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(1132, 67);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(244, 44);
            this.showAllButton.TabIndex = 8;
            this.showAllButton.Text = "Show All Records";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 65);
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
            this.label1.Location = new System.Drawing.Point(163, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Record";
            // 
            // SearchOwnerOrPropertyTextbox
            // 
            this.SearchOwnerOrPropertyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOwnerOrPropertyTextbox.Location = new System.Drawing.Point(381, 65);
            this.SearchOwnerOrPropertyTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchOwnerOrPropertyTextbox.Name = "SearchOwnerOrPropertyTextbox";
            this.SearchOwnerOrPropertyTextbox.Size = new System.Drawing.Size(416, 44);
            this.SearchOwnerOrPropertyTextbox.TabIndex = 5;
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(71, 701);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(336, 31);
            this.textBoxFN.TabIndex = 5;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(71, 755);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(336, 31);
            this.textBoxLN.TabIndex = 6;
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(71, 813);
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(336, 31);
            this.textBoxPN.TabIndex = 7;
            // 
            // textBoxCY
            // 
            this.textBoxCY.Location = new System.Drawing.Point(71, 985);
            this.textBoxCY.Name = "textBoxCY";
            this.textBoxCY.Size = new System.Drawing.Size(336, 31);
            this.textBoxCY.TabIndex = 10;
            // 
            // textBoxSN
            // 
            this.textBoxSN.Location = new System.Drawing.Point(71, 927);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(336, 31);
            this.textBoxSN.TabIndex = 9;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(71, 873);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(336, 31);
            this.textBoxE.TabIndex = 8;
            // 
            // textBoxZP
            // 
            this.textBoxZP.Location = new System.Drawing.Point(71, 1095);
            this.textBoxZP.Name = "textBoxZP";
            this.textBoxZP.Size = new System.Drawing.Size(336, 31);
            this.textBoxZP.TabIndex = 12;
            // 
            // textBoxST
            // 
            this.textBoxST.Location = new System.Drawing.Point(71, 1041);
            this.textBoxST.Name = "textBoxST";
            this.textBoxST.Size = new System.Drawing.Size(336, 31);
            this.textBoxST.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1043, 707);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 56);
            this.button2.TabIndex = 13;
            this.button2.Text = "Edit Owner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 1212);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxZP);
            this.Controls.Add(this.textBoxST);
            this.Controls.Add(this.textBoxCY);
            this.Controls.Add(this.textBoxSN);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "modify";
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).EndInit();
            this.modifyGroupBox.ResumeLayout(false);
            this.modifyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.TextBox textBoxPN;
        private System.Windows.Forms.TextBox textBoxCY;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxZP;
        private System.Windows.Forms.TextBox textBoxST;
        private System.Windows.Forms.Button button2;
    }
}