namespace ArpachTax
{
    partial class RegistrationForm
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
            passwordLabel = new Label();
            PasswordField = new TextBox();
            loginLabel = new Label();
            LoginField = new TextBox();
            regInfoLabel = new Label();
            surnameLabel = new Label();
            textBox1 = new TextBox();
            nameLabel = new Label();
            textBox2 = new TextBox();
            emailLabel = new Label();
            textBox3 = new TextBox();
            phoneLabel = new Label();
            textBox4 = new TextBox();
            RegButton = new Button();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(211, 214, 209);
            passwordLabel.ImeMode = ImeMode.NoControl;
            passwordLabel.Location = new Point(92, 249);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(131, 41);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Пароль :";
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.FromArgb(35, 37, 30);
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            PasswordField.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordField.ForeColor = Color.ForestGreen;
            PasswordField.Location = new Point(244, 249);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(228, 38);
            PasswordField.TabIndex = 9;
            PasswordField.TextAlign = HorizontalAlignment.Center;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(211, 214, 209);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(92, 132);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(112, 41);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "Логин :";
            // 
            // LoginField
            // 
            LoginField.BackColor = Color.FromArgb(35, 37, 30);
            LoginField.BorderStyle = BorderStyle.FixedSingle;
            LoginField.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginField.ForeColor = Color.ForestGreen;
            LoginField.Location = new Point(244, 138);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(228, 38);
            LoginField.TabIndex = 7;
            LoginField.TextAlign = HorizontalAlignment.Center;
            // 
            // regInfoLabel
            // 
            regInfoLabel.AutoSize = true;
            regInfoLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            regInfoLabel.ForeColor = Color.FromArgb(211, 214, 209);
            regInfoLabel.ImeMode = ImeMode.NoControl;
            regInfoLabel.Location = new Point(228, 40);
            regInfoLabel.Name = "regInfoLabel";
            regInfoLabel.Size = new Size(646, 46);
            regInfoLabel.TabIndex = 6;
            regInfoLabel.Text = "Заполните корректно все поля с данными";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            surnameLabel.ForeColor = Color.FromArgb(211, 214, 209);
            surnameLabel.ImeMode = ImeMode.NoControl;
            surnameLabel.Location = new Point(555, 132);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(151, 41);
            surnameLabel.TabIndex = 14;
            surnameLabel.Text = "Фамилия :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(35, 37, 30);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.ForestGreen;
            textBox1.Location = new Point(817, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 38);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.FromArgb(211, 214, 209);
            nameLabel.ImeMode = ImeMode.NoControl;
            nameLabel.Location = new Point(92, 357);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(87, 41);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Имя :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(35, 37, 30);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.ForestGreen;
            textBox2.Location = new Point(244, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 38);
            textBox2.TabIndex = 11;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(211, 214, 209);
            emailLabel.ImeMode = ImeMode.NoControl;
            emailLabel.Location = new Point(555, 357);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(160, 41);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Эл. Почта :";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(35, 37, 30);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.ForestGreen;
            textBox3.Location = new Point(817, 357);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 38);
            textBox3.TabIndex = 17;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.ForeColor = Color.FromArgb(211, 214, 209);
            phoneLabel.ImeMode = ImeMode.NoControl;
            phoneLabel.Location = new Point(555, 249);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(218, 41);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Моб. Телефон :";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(35, 37, 30);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.ForestGreen;
            textBox4.Location = new Point(817, 249);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 38);
            textBox4.TabIndex = 15;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // RegButton
            // 
            RegButton.BackColor = Color.FromArgb(201, 248, 13);
            RegButton.CausesValidation = false;
            RegButton.FlatAppearance.BorderSize = 0;
            RegButton.FlatStyle = FlatStyle.Flat;
            RegButton.Font = new Font("Segoe UI Light", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            RegButton.ImeMode = ImeMode.NoControl;
            RegButton.Location = new Point(287, 495);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(567, 63);
            RegButton.TabIndex = 19;
            RegButton.Text = "Готово";
            RegButton.UseVisualStyleBackColor = false;
            RegButton.Click += RegButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 30);
            ClientSize = new Size(1098, 619);
            Controls.Add(RegButton);
            Controls.Add(emailLabel);
            Controls.Add(textBox3);
            Controls.Add(phoneLabel);
            Controls.Add(textBox4);
            Controls.Add(surnameLabel);
            Controls.Add(textBox1);
            Controls.Add(nameLabel);
            Controls.Add(textBox2);
            Controls.Add(passwordLabel);
            Controls.Add(PasswordField);
            Controls.Add(loginLabel);
            Controls.Add(LoginField);
            Controls.Add(regInfoLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private TextBox PasswordField;
        private Label loginLabel;
        private TextBox LoginField;
        private Label regInfoLabel;
        private Label surnameLabel;
        private TextBox textBox1;
        private Label nameLabel;
        private TextBox textBox2;
        private Label emailLabel;
        private TextBox textBox3;
        private Label phoneLabel;
        private TextBox textBox4;
        private Button RegButton;
    }
}