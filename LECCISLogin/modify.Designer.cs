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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deletedataGridView = new System.Windows.Forms.DataGridView();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchOwnerOrPropertyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).BeginInit();
            this.modifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(619, 452);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 36);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit ";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(791, 452);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 36);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deletedataGridView
            // 
            this.deletedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedataGridView.Location = new System.Drawing.Point(14, 88);
            this.deletedataGridView.Name = "deletedataGridView";
            this.deletedataGridView.RowHeadersWidth = 51;
            this.deletedataGridView.RowTemplate.Height = 24;
            this.deletedataGridView.Size = new System.Drawing.Size(997, 284);
            this.deletedataGridView.TabIndex = 2;
            this.deletedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.button1);
            this.modifyGroupBox.Controls.Add(this.label1);
            this.modifyGroupBox.Controls.Add(this.SearchOwnerOrPropertyTextbox);
            this.modifyGroupBox.Controls.Add(this.deletedataGridView);
            this.modifyGroupBox.Location = new System.Drawing.Point(11, 35);
            this.modifyGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyGroupBox.Size = new System.Drawing.Size(1025, 412);
            this.modifyGroupBox.TabIndex = 4;
            this.modifyGroupBox.TabStop = false;
            // 
            // SearchOwnerOrPropertyTextbox
            // 
            this.SearchOwnerOrPropertyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOwnerOrPropertyTextbox.Location = new System.Drawing.Point(421, 34);
            this.SearchOwnerOrPropertyTextbox.Name = "SearchOwnerOrPropertyTextbox";
            this.SearchOwnerOrPropertyTextbox.Size = new System.Drawing.Size(279, 30);
            this.SearchOwnerOrPropertyTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Owner or Property";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 541);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Name = "modify";
            this.Text = "delete";
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
    }
}