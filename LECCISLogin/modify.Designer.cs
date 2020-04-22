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
            this.button3 = new System.Windows.Forms.Button();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).BeginInit();
            this.modifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(1037, 16);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(176, 56);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit ";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(1284, 16);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(152, 56);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
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
            this.deletedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(438, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "SHOW ALL DATA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.button3);
            this.modifyGroupBox.Controls.Add(this.deletedataGridView);
            this.modifyGroupBox.Controls.Add(this.deleteButton);
            this.modifyGroupBox.Controls.Add(this.editButton);
            this.modifyGroupBox.Location = new System.Drawing.Point(17, 54);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Size = new System.Drawing.Size(1538, 644);
            this.modifyGroupBox.TabIndex = 4;
            this.modifyGroupBox.TabStop = false;
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 845);
            this.Controls.Add(this.modifyGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "modify";
            this.Text = "delete";
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView)).EndInit();
            this.modifyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView deletedataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox modifyGroupBox;
    }
}