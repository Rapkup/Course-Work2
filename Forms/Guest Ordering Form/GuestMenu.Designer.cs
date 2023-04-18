namespace ArpachTax
{
    partial class GuestMenu
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
            MakeOrderButton = new Button();
            loginLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LogButton = new Button();
            RegButton = new Button();
            button1 = new Button();
            bioPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bioPanel
            // 
            bioPanel.BackColor = Color.FromArgb(3, 19, 51, 45);
            bioPanel.Controls.Add(label4);
            bioPanel.Controls.Add(label3);
            bioPanel.Controls.Add(loginLabel);
            bioPanel.Controls.Add(label2);
            bioPanel.Controls.Add(label1);
            bioPanel.Controls.Add(MakeOrderButton);
            bioPanel.Location = new Point(34, 26);
            bioPanel.Name = "bioPanel";
            bioPanel.Size = new Size(411, 569);
            bioPanel.TabIndex = 2;
            bioPanel.Paint += panel1_Paint;
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
            MakeOrderButton.Size = new Size(352, 59);
            MakeOrderButton.TabIndex = 20;
            MakeOrderButton.Text = "Сделать заказ";
            MakeOrderButton.UseVisualStyleBackColor = false;
            MakeOrderButton.Click += RegButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(211, 214, 209);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(30, 414);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(100, 41);
            loginLabel.TabIndex = 21;
            loginLabel.Text = "Цена :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(211, 214, 209);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 22;
            label1.Text = "Откуда едем :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(211, 214, 209);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(30, 105);
            label2.Name = "label2";
            label2.Size = new Size(165, 41);
            label2.TabIndex = 23;
            label2.Text = "Куда едем :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(211, 214, 209);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(30, 173);
            label3.Name = "label3";
            label3.Size = new Size(197, 41);
            label3.TabIndex = 23;
            label3.Text = "Тип поездки :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(211, 214, 209);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(30, 234);
            label4.Name = "label4";
            label4.Size = new Size(183, 41);
            label4.TabIndex = 23;
            label4.Text = "Тип оплаты :";
            // 
            // LogButton
            // 
            LogButton.BackColor = Color.FromArgb(49, 51, 45);
            LogButton.CausesValidation = false;
            LogButton.FlatAppearance.BorderSize = 0;
            LogButton.FlatStyle = FlatStyle.Flat;
            LogButton.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogButton.ForeColor = Color.FromArgb(201, 248, 13);
            LogButton.ImeMode = ImeMode.NoControl;
            LogButton.Location = new Point(901, 234);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(148, 48);
            LogButton.TabIndex = 12;
            LogButton.Text = "Авторизация";
            LogButton.UseVisualStyleBackColor = false;
            // 
            // RegButton
            // 
            RegButton.BackColor = Color.FromArgb(49, 51, 45);
            RegButton.CausesValidation = false;
            RegButton.FlatAppearance.BorderSize = 0;
            RegButton.FlatStyle = FlatStyle.Flat;
            RegButton.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegButton.ForeColor = Color.FromArgb(201, 248, 13);
            RegButton.ImeMode = ImeMode.NoControl;
            RegButton.Location = new Point(901, 303);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(148, 48);
            RegButton.TabIndex = 13;
            RegButton.Text = "Регистрация";
            RegButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 37, 30);
            button1.CausesValidation = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(201, 248, 13);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(901, 165);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 14;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = false;
            // 
            // GuestMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 30);
            ClientSize = new Size(1098, 619);
            Controls.Add(button1);
            Controls.Add(RegButton);
            Controls.Add(LogButton);
            Controls.Add(bioPanel);
            Name = "GuestMenu";
            Text = "GuestMenu";
            Load += GuestMenu_Load;
            bioPanel.ResumeLayout(false);
            bioPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel bioPanel;
        private Button MakeOrderButton;
        private Label loginLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button LogButton;
        private Button RegButton;
        private Button button1;
    }
}