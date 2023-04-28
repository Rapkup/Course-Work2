
/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArpachTax.FormServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArpachTax.Users.Client
{
    public partial class TaxiDrive : Form
    {*/


namespace ArpachTax
{
    public partial class TaxiDrive : Form
    {
        public TaxiDrive()
        {
            InitializeComponent();
            progressDrive.Value = 0;
            progressDrive.Maximum = 100;
            FService.SetRoundedShape(MakeOrderButton, 60);
            FService.SetRoundedShape(ExitButton, 60);
            FService.SetRoundedShape(progressDrive, 60);
        }

        private void UpdateProgressBar(int progress)
        {
            progressDrive.Value = progress;
        }

        private async Task BackgroundTask()
        {
            for (int i = 0; i <= 100; i++)
            {
                UpdateProgressBar(i);
                string dots = new string('.', i % 4);
                statusLabel.Text = "Едем" + dots;
                await Task.Delay(50);
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {

        }

        private async void TaxiDrive_Load(object sender, EventArgs e)
        {
            await BackgroundTask();
            ExitButton.Visible = true;
            MakeOrderButton.Visible = true;
            statusLabel.Text = "Готово!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
