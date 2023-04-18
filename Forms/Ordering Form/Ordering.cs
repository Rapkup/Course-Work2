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

namespace ArpachTax.Users.Client
{
    public partial class Ordering : Form
    {
        public Ordering()
        {
            InitializeComponent();
            FService.SetRoundedShape(MakeOrderButton, 60);
            FService.SetRoundedShape(LogOutButton, 60);
            FService.SetRoundedShape(panel1, 60);
            FService.SetRoundedShape(bioPanel, 60);
            FService.SetRoundedShape(LogOutButton, 60);
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            /*  if (StartAddressField.Text != "" && EndFieldAddress.Text != "" && TypeOfRide != null && PaymentType != null)
              { */


            TaxiDrive taxiDrive = new TaxiDrive();
            taxiDrive.Show();
            //}

        }
    }
}
