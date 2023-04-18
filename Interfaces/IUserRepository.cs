using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArpachTax.Interfaces
{
    internal interface  IUserRepository : IBaseRepository<User>
    {
        User GetByUsernameAndPassword(string username, string password);
        User GetUserByLogin(string login);
        User GetUserByEmail(string email);
        void UpdateUser(User user);
    }
}
