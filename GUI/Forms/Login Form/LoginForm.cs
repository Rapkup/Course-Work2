

namespace ArpachTax
{
    public partial class LoginForm : Form
    {

        List<User> users = new List<User>
        {
            new User { Login = "guest", Password = "guest", Role = UserRole.Guest },
            new User { Login = "client", Password = "client", Role = UserRole.Client },
            new User { Login = "driver", Password = "driver", Role = UserRole.Driver },
            new User { Login = "admin", Password = "admin", Role = UserRole.Admin },
            new User { Login = "manager", Password = "manager", Role = UserRole.Manager },
            new User { Login = "dispatcher", Password = "dispatcher", Role = UserRole.Dispatcher }
        };


        // AuthenticationService authService = new AuthenticationService(users);


        public LoginForm()
        {
            InitializeComponent();
            FService.SetRoundedShape(LoginButton, 60);
            FService.SetRoundedShape(RegButton, 60);
            FService.SetRoundedShape(GuestLoginButton, 60);

        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string password = PasswordField.Text;

          /*  try
            {
                if (login != "" && password != "")
                {
                    AuthenticationService authService = new AuthenticationService(login);

                    User authenticatedUser = authService.Authenticate(login, password);

                    switch (authenticatedUser.Role)
                    {

                        case UserRole.Client:

                        case UserRole.Guest:
                     
                        case UserRole.Admin:
                           
                        case UserRole.Driver:
                            
                        default: break;

                    }
                }
                else
                {
                    MessageBox.Show("Поля Логин и Пароль должны быть заполнены!!!");
                }*/
              

                Ordering ordering = new Ordering();
                ordering.Show();
           /* }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void GuestLoginButton_Click(object sender, EventArgs e)
        {
            GuestMenu guestMenu = new GuestMenu();
            guestMenu.Show();
        }

        private void PasswordField_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PasswordField.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }


        private void RegButton_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }
    }
}