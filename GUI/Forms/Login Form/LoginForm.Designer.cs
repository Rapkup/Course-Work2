namespace ArpachTax
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            LoginField = new TextBox();
            label3 = new Label();
            label2 = new Label();
            PasswordField = new TextBox();
            LoginButton = new Button();
            RegButton = new Button();
            label4 = new Label();
            GuestLoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(211, 214, 209);
            label1.Name = "label1";
            // 
            // LoginField
            // 
            LoginField.BackColor = Color.FromArgb(35, 37, 30);
            LoginField.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(LoginField, "LoginField");
            LoginField.ForeColor = Color.FromArgb(201, 248, 13);
            LoginField.Name = "LoginField";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(211, 214, 209);
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(211, 214, 209);
            label2.Name = "label2";
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.FromArgb(35, 37, 30);
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(PasswordField, "PasswordField");
            PasswordField.ForeColor = Color.FromArgb(201, 248, 13);
            PasswordField.Name = "PasswordField";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(201, 248, 13);
            LoginButton.CausesValidation = false;
            LoginButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(LoginButton, "LoginButton");
            LoginButton.Name = "LoginButton";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegButton
            // 
            RegButton.BackColor = Color.FromArgb(49, 51, 45);
            RegButton.CausesValidation = false;
            RegButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(RegButton, "RegButton");
            RegButton.ForeColor = Color.FromArgb(201, 248, 13);
            RegButton.Name = "RegButton";
            RegButton.UseVisualStyleBackColor = false;
            RegButton.Click += RegButton_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(211, 214, 209);
            label4.Name = "label4";
            // 
            // GuestLoginButton
            // 
            GuestLoginButton.BackColor = Color.FromArgb(49, 51, 45);
            GuestLoginButton.CausesValidation = false;
            GuestLoginButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(GuestLoginButton, "GuestLoginButton");
            GuestLoginButton.ForeColor = Color.FromArgb(201, 248, 13);
            GuestLoginButton.Name = "GuestLoginButton";
            GuestLoginButton.UseVisualStyleBackColor = false;
            GuestLoginButton.Click += GuestLoginButton_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 30);
            Controls.Add(GuestLoginButton);
            Controls.Add(label4);
            Controls.Add(RegButton);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(PasswordField);
            Controls.Add(label3);
            Controls.Add(LoginField);
            Controls.Add(label1);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginField;
        private Label label3;
        private Label label2;
        private TextBox PasswordField;
        private Button LoginButton;
        private Button RegButton;
        private Label label4;
        private Button GuestLoginButton;
    }
}