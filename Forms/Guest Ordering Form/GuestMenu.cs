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

namespace ArpachTax
{
    public partial class GuestMenu : Form
    {


        public GuestMenu()
        {
            InitializeComponent();
            FService.SetRoundedShape(bioPanel, 50);
            FService.SetRoundedShape(MakeOrderButton, 50);
            FService.SetRoundedShape(RegButton, 50);
            FService.SetRoundedShape(LogButton, 50);
            FService.SetRoundedShape(MakeOrderButton, 50);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void GuestMenu_Load(object sender, EventArgs e)
        {

        }

        private void GuestLoginButton_Click(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {

        }
    }
}
