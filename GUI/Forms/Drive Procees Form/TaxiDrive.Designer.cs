namespace ArpachTax
{
    partial class TaxiDrive
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
            progressDrive = new ProgressBar();
            statusLabel = new Label();
            MakeOrderButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // progressDrive
            // 
            progressDrive.ForeColor = Color.FromArgb(201, 248, 36);
            progressDrive.Location = new Point(211, 218);
            progressDrive.Name = "progressDrive";
            progressDrive.Size = new Size(677, 59);
            progressDrive.Step = 1;
            progressDrive.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.FromArgb(201, 248, 13);
            statusLabel.ImeMode = ImeMode.NoControl;
            statusLabel.Location = new Point(465, 104);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(164, 81);
            statusLabel.TabIndex = 23;
            statusLabel.Text = "Едем";
            // 
            // MakeOrderButton
            // 
            MakeOrderButton.BackColor = Color.FromArgb(49, 51, 45);
            MakeOrderButton.CausesValidation = false;
            MakeOrderButton.FlatAppearance.BorderSize = 0;
            MakeOrderButton.FlatStyle = FlatStyle.Flat;
            MakeOrderButton.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            MakeOrderButton.ForeColor = Color.FromArgb(201, 248, 13);
            MakeOrderButton.ImeMode = ImeMode.NoControl;
            MakeOrderButton.Location = new Point(211, 349);
            MakeOrderButton.Name = "MakeOrderButton";
            MakeOrderButton.Size = new Size(286, 142);
            MakeOrderButton.TabIndex = 24;
            MakeOrderButton.Text = "Сделать ещё один заказ";
            MakeOrderButton.UseVisualStyleBackColor = false;
            MakeOrderButton.Visible = false;
            MakeOrderButton.Click += LogButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(49, 51, 45);
            ExitButton.CausesValidation = false;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.FromArgb(201, 248, 13);
            ExitButton.ImeMode = ImeMode.NoControl;
            ExitButton.Location = new Point(602, 349);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(286, 142);
            ExitButton.TabIndex = 25;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Visible = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // TaxiDrive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 30);
            ClientSize = new Size(1098, 619);
            Controls.Add(ExitButton);
            Controls.Add(MakeOrderButton);
            Controls.Add(statusLabel);
            Controls.Add(progressDrive);
            Name = "TaxiDrive";
            Text = "TaxiDrive";
            Load += TaxiDrive_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressDrive;
        private Label statusLabel;
        private Button MakeOrderButton;
        private Button ExitButton;
    }
}