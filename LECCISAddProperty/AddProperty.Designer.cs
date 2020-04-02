namespace LECCISAddProperty
{
  partial class addProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProperty));
            this.Property = new System.Windows.Forms.Label();
            this.streetNumber = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.Sqft = new System.Windows.Forms.TextBox();
            this.Acres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Property
            // 
            resources.ApplyResources(this.Property, "Property");
            this.Property.Name = "Property";
            // 
            // streetNumber
            // 
            resources.ApplyResources(this.streetNumber, "streetNumber");
            this.streetNumber.ForeColor = System.Drawing.Color.Gray;
            this.streetNumber.Name = "streetNumber";
            this.streetNumber.TextChanged += new System.EventHandler(this.StreetNumber_TextChanged);
            // 
            // city
            // 
            resources.ApplyResources(this.city, "city");
            this.city.ForeColor = System.Drawing.Color.Gray;
            this.city.Name = "city";
            // 
            // state
            // 
            resources.ApplyResources(this.state, "state");
            this.state.ForeColor = System.Drawing.Color.Gray;
            this.state.Name = "state";
            // 
            // zip
            // 
            resources.ApplyResources(this.zip, "zip");
            this.zip.ForeColor = System.Drawing.Color.Gray;
            this.zip.Name = "zip";
            // 
            // Sqft
            // 
            resources.ApplyResources(this.Sqft, "Sqft");
            this.Sqft.ForeColor = System.Drawing.Color.Gray;
            this.Sqft.Name = "Sqft";
            // 
            // Acres
            // 
            resources.ApplyResources(this.Acres, "Acres");
            this.Acres.ForeColor = System.Drawing.Color.Gray;
            this.Acres.Name = "Acres";
            this.Acres.TextChanged += new System.EventHandler(this.Acres_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addProperty
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Acres);
            this.Controls.Add(this.Sqft);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.streetNumber);
            this.Controls.Add(this.Property);
            this.Name = "addProperty";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label Property;
        private System.Windows.Forms.TextBox streetNumber;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox Sqft;
        private System.Windows.Forms.TextBox Acres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}

