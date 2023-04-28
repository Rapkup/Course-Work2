using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArpachTax
{
    internal class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }



        public User(int id, string login, string password, string name, string surname, string phone, string email, UserRole role)
        {
            ID = id;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Role = role;
        }

        public User(string login, string password, string name, string surname, string phone, string email, UserRole role)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Role = role;
        }

        public User(string login, string password, string name, string surname, string phone, string email)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;

        }

        public User() { }


    }
}

