using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace ArpachTax.Interfaces
{
    internal interface IPasswordHashers
    {
        public string HashPassword(string password);

    }
}
