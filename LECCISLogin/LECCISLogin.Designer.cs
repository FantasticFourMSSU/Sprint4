namespace LECCISLogin
{
  partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.processorLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // processorLabel
            // 
            resources.ApplyResources(this.processorLabel, "processorLabel");
            this.processorLabel.Name = "processorLabel";
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.Name = "userNameLabel";
            // 
            // UsernameField
            // 
            resources.ApplyResources(this.UsernameField, "UsernameField");
            this.UsernameField.Name = "UsernameField";
            // 
            // PasswordField
            // 
            this.PasswordField.CausesValidation = false;
            resources.ApplyResources(this.PasswordField, "PasswordField");
            this.PasswordField.Name = "PasswordField";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.processorLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.PasswordField);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label processorLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.TextBox PasswordField;
    }
}

