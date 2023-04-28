

namespace ArpachTax
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
