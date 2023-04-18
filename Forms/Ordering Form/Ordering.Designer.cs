namespace ArpachTax.Users.Client
{
    partial class Ordering
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
            bioPanel = new Panel();
            FinalPrice = new TextBox();
            PaymentType = new ComboBox();
            TypeOfRide = new ComboBox();
            EndFieldAddress = new TextBox();
            StartAddressField = new TextBox();
            label4 = new Label();
            label3 = new Label();
            loginLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            MakeOrderButton = new Button();
            UserPicture = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            LogOutButton = new Button();
            label6 = new Label();
            bioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bioPanel
            // 
            bioPanel.BackColor = Color.FromArgb(3, 19, 51, 45);
            bioPanel.Controls.Add(FinalPrice);
            bioPanel.Controls.Add(PaymentType);
            bioPanel.Controls.Add(TypeOfRide);
            bioPanel.Controls.Add(EndFieldAddress);
            bioPanel.Controls.Add(StartAddressField);
            bioPanel.Controls.Add(label4);
            bioPanel.Controls.Add(label3);
            bioPanel.Controls.Add(loginLabel);
            bioPanel.Controls.Add(label2);
            bioPanel.Controls.Add(label1);
            bioPanel.Controls.Add(MakeOrderButton);
            bioPanel.Location = new Point(28, 22);
            bioPanel.Name = "bioPanel";
            bioPanel.Size = new Size(842, 569);
            bioPanel.TabIndex = 3;
            // 
            // FinalPrice
            // 
            FinalPrice.BackColor = Color.FromArgb(35, 37, 30);
            FinalPrice.BorderStyle = BorderStyle.FixedSingle;
            FinalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FinalPrice.ForeColor = Color.ForestGreen;
            FinalPrice.Location = new Point(263, 417);
            FinalPrice.Name = "FinalPrice";
            FinalPrice.ReadOnly = true;
            FinalPrice.Size = new Size(343, 38);
            FinalPrice.TabIndex = 30;
            FinalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // PaymentType
            // 
            PaymentType.BackColor = Color.FromArgb(35, 37, 30);
            PaymentType.FlatStyle = FlatStyle.Flat;
            PaymentType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentType.ForeColor = Color.FromArgb(211, 214, 209);
            PaymentType.FormattingEnabled = true;
            PaymentType.Items.AddRange(new object[] { "Наличный", "Безналичный", "Смешаный " });
            PaymentType.Location = new Point(263, 239);
            PaymentType.Name = "PaymentType";
            PaymentType.Size = new Size(343, 39);
            PaymentType.TabIndex = 29;
            // 
            // TypeOfRide
            // 
            TypeOfRide.BackColor = Color.FromArgb(35, 37, 30);
            TypeOfRide.FlatStyle = FlatStyle.Flat;
            TypeOfRide.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TypeOfRide.ForeColor = Color.FromArgb(211, 214, 209);
            TypeOfRide.FormattingEnabled = true;
            TypeOfRide.Items.AddRange(new object[] { "Эконом", "Бизнесс" });
            TypeOfRide.Location = new Point(263, 178);
            TypeOfRide.Name = "TypeOfRide";
            TypeOfRide.Size = new Size(343, 39);
            TypeOfRide.TabIndex = 28;
            // 
            // EndFieldAddress
            // 
            EndFieldAddress.BackColor = Color.FromArgb(35, 37, 30);
            EndFieldAddress.BorderStyle = BorderStyle.FixedSingle;
            EndFieldAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EndFieldAddress.ForeColor = Color.ForestGreen;
            EndFieldAddress.Location = new Point(263, 111);
            EndFieldAddress.Name = "EndFieldAddress";
            EndFieldAddress.Size = new Size(343, 38);
            EndFieldAddress.TabIndex = 25;
            EndFieldAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // StartAddressField
            // 
            StartAddressField.BackColor = Color.FromArgb(35, 37, 30);
            StartAddressField.BorderStyle = BorderStyle.FixedSingle;
            StartAddressField.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StartAddressField.ForeColor = Color.ForestGreen;
            StartAddressField.Location = new Point(263, 50);
            StartAddressField.Name = "StartAddressField";
            StartAddressField.Size = new Size(343, 38);
            StartAddressField.TabIndex = 24;
            StartAddressField.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(201, 248, 13);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(30, 234);
            label4.Name = "label4";
            label4.Size = new Size(183, 41);
            label4.TabIndex = 23;
            label4.Text = "Тип оплаты :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(201, 248, 13);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(30, 173);
            label3.Name = "label3";
            label3.Size = new Size(197, 41);
            label3.TabIndex = 23;
            label3.Text = "Тип поездки :";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(211, 214, 209);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(30, 414);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(221, 41);
            loginLabel.TabIndex = 21;
            loginLabel.Text = "Итоговая цена :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(201, 248, 13);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(30, 105);
            label2.Name = "label2";
            label2.Size = new Size(165, 41);
            label2.TabIndex = 23;
            label2.Text = "Куда едем :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(201, 248, 13);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 22;
            label1.Text = "Откуда едем :";
            // 
            // MakeOrderButton
            // 
            MakeOrderButton.BackColor = Color.FromArgb(201, 248, 13);
            MakeOrderButton.CausesValidation = false;
            MakeOrderButton.FlatAppearance.BorderSize = 0;
            MakeOrderButton.FlatStyle = FlatStyle.Flat;
            MakeOrderButton.Font = new Font("Segoe UI Light", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            MakeOrderButton.ImeMode = ImeMode.NoControl;
            MakeOrderButton.Location = new Point(30, 478);
            MakeOrderButton.Name = "MakeOrderButton";
            MakeOrderButton.Size = new Size(576, 59);
            MakeOrderButton.TabIndex = 20;
            MakeOrderButton.Text = "Сделать заказ";
            MakeOrderButton.UseVisualStyleBackColor = false;
            MakeOrderButton.Click += MakeOrderButton_Click;
            // 
            // UserPicture
            // 
            UserPicture.Image = Properties.Resources.DL;
            UserPicture.Location = new Point(13, 18);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new Size(168, 146);
            UserPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPicture.TabIndex = 4;
            UserPicture.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(211, 214, 209);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(37, 185);
            label5.Name = "label5";
            label5.Size = new Size(121, 41);
            label5.TabIndex = 24;
            label5.Text = " Rapkup";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 19, 51, 45);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(UserPicture);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(876, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 569);
            panel1.TabIndex = 24;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.FromArgb(49, 51, 45);
            LogOutButton.CausesValidation = false;
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutButton.ForeColor = Color.FromArgb(201, 248, 13);
            LogOutButton.ImeMode = ImeMode.NoControl;
            LogOutButton.Location = new Point(17, 483);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(159, 62);
            LogOutButton.TabIndex = 26;
            LogOutButton.Text = "Выход из аккаунта";
            LogOutButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(211, 214, 209);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(37, 264);
            label6.Name = "label6";
            label6.Size = new Size(0, 41);
            label6.TabIndex = 25;
            // 
            // Ordering
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 30);
            ClientSize = new Size(1098, 619);
            Controls.Add(panel1);
            Controls.Add(bioPanel);
            Name = "Ordering";
            Text = "Ordering";
            bioPanel.ResumeLayout(false);
            bioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bioPanel;
        private Label label4;
        private Label label3;
        private Label loginLabel;
        private Label label2;
        private Label label1;
        private Button MakeOrderButton;
        private PictureBox UserPicture;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Button LogOutButton;
        private ComboBox PaymentType;
        private ComboBox TypeOfRide;
        private TextBox EndFieldAddress;
        private TextBox StartAddressField;
        private TextBox FinalPrice;
    }
}