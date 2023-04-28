using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArpachTax
{
    internal class Guest : User
    {
        public Guest(string login, string password, string name, string surname, string phone, string email)
    : base(login, password, name, surname, phone, email)
        {
            Role = UserRole.Guest;
        }

        public void ViewAvailableTaxis()
        {
            // Вывод информации о доступных такси
        }

        public void PlaceOrder()
        {

            // Оформление заказа на такси
        }



    }

}

