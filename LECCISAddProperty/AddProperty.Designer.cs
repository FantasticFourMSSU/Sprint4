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
            this.zip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.ComboBox();
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
            this.streetNumber.TextChanged += new System.EventHandler(this.streetNumber_TextChanged);
            // 
            // city
            // 
            resources.ApplyResources(this.city, "city");
            this.city.ForeColor = System.Drawing.Color.Gray;
            this.city.Name = "city";
            // 
            // zip
            // 
            resources.ApplyResources(this.zip, "zip");
            this.zip.ForeColor = System.Drawing.Color.Gray;
            this.zip.Name = "zip";
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
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            resources.GetString("state.Items"),
            resources.GetString("state.Items1"),
            resources.GetString("state.Items2"),
            resources.GetString("state.Items3"),
            resources.GetString("state.Items4"),
            resources.GetString("state.Items5"),
            resources.GetString("state.Items6"),
            resources.GetString("state.Items7"),
            resources.GetString("state.Items8"),
            resources.GetString("state.Items9"),
            resources.GetString("state.Items10"),
            resources.GetString("state.Items11"),
            resources.GetString("state.Items12"),
            resources.GetString("state.Items13"),
            resources.GetString("state.Items14"),
            resources.GetString("state.Items15"),
            resources.GetString("state.Items16"),
            resources.GetString("state.Items17"),
            resources.GetString("state.Items18"),
            resources.GetString("state.Items19"),
            resources.GetString("state.Items20"),
            resources.GetString("state.Items21"),
            resources.GetString("state.Items22"),
            resources.GetString("state.Items23"),
            resources.GetString("state.Items24"),
            resources.GetString("state.Items25"),
            resources.GetString("state.Items26"),
            resources.GetString("state.Items27"),
            resources.GetString("state.Items28"),
            resources.GetString("state.Items29"),
            resources.GetString("state.Items30"),
            resources.GetString("state.Items31"),
            resources.GetString("state.Items32"),
            resources.GetString("state.Items33"),
            resources.GetString("state.Items34"),
            resources.GetString("state.Items35"),
            resources.GetString("state.Items36"),
            resources.GetString("state.Items37"),
            resources.GetString("state.Items38"),
            resources.GetString("state.Items39"),
            resources.GetString("state.Items40"),
            resources.GetString("state.Items41"),
            resources.GetString("state.Items42"),
            resources.GetString("state.Items43"),
            resources.GetString("state.Items44"),
            resources.GetString("state.Items45"),
            resources.GetString("state.Items46"),
            resources.GetString("state.Items47"),
            resources.GetString("state.Items48"),
            resources.GetString("state.Items49"),
            resources.GetString("state.Items50")});
            resources.ApplyResources(this.state, "state");
            this.state.Name = "state";
            // 
            // addProperty
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.state);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zip);
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
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox state;
  
  }
}

