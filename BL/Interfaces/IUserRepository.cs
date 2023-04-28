
namespace ArpachTax
{
    internal interface IUserRepository : IBaseRepository<User>
    {
        User GetByUsernameAndPassword(string username, string password);
        User GetUserByLogin(string login);
        User GetUserByEmail(string email);
        void UpdateUser(User user);
    }
}
