using System.Data.SQLite;
using System.Data;

namespace ArpachTax
{
    internal class UserRepository : IUserRepository
    {
        private string source = "Data Source = TaxiDataBase.db; Version=3";

        public bool Create(User entity)
        {
            using (var DB = new SQLiteConnection(source))
            {
                DB.Open();
                SQLiteCommand CMD = new SQLiteCommand(DB);
                CMD = DB.CreateCommand();
                CMD.CommandText = "INSERT INTO User (ID, Role, Login, Password, Name, Surname, Phone, Email)" +
                    "VALUES (@ID, @Role, @Login, @Password, @Name, @Surname, @Phone, @Email )";
                CMD.Parameters.Add("@Role", DbType.String).Value = entity.Role;
                CMD.Parameters.Add("@Login", DbType.String).Value = entity.Login;
                CMD.Parameters.Add("@Password", DbType.String).Value = entity.Password;
                CMD.Parameters.Add("@Name", DbType.String).Value = entity.Name;
                CMD.Parameters.Add("@Surname", DbType.String).Value = entity.Surname;
                CMD.Parameters.Add("@Phone", DbType.String).Value = entity.Phone;
                CMD.Parameters.Add("@Email", DbType.String).Value = entity.Email;
                CMD.ExecuteNonQuery();
            }
            return true;
        }

        public bool Delete(User entity)
        {
            using (var DB = new SQLiteConnection(source))
            {
                DB.Open();
                SQLiteCommand CMD = new SQLiteCommand(DB);
                CMD = DB.CreateCommand();
                CMD.CommandText = "DELETE FROM User WHERE ID = @ID;";
                CMD.Parameters.Add("@ID", DbType.Int32).Value = entity.ID;
                CMD.ExecuteNonQuery();
                DB.Close();
            }
            return true;
        }

        public User Get(int id)
        {
            using (var DB = new SQLiteConnection(source))
            {
                DB.Open();
                SQLiteCommand CMD = new SQLiteCommand(DB);
                CMD = DB.CreateCommand();
                CMD.CommandText = "SELECT * FROM User WHERE ID = @ID;";
                CMD.Parameters.Add("@ID", DbType.Int32).Value = id;
                using (SQLiteDataReader reader = CMD.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                        /* string roleStr = reader.GetString(reader.GetOrdinal("Role"));
                         UserRole role = (UserRole)Enum.Parse(typeof(UserRole), roleStr);
                         user.Role = role;*/
                        user.Login = reader.GetString(reader.GetOrdinal("Login"));
                        user.Password = reader.GetString(reader.GetOrdinal("Password"));
                        user.Name = reader.GetString(reader.GetOrdinal("Name"));
                        user.Surname = reader.GetString(reader.GetOrdinal("Surname"));
                        user.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                        user.Email = reader.GetString(reader.GetOrdinal("Email"));
                        return user;
                    }
                }
            }
            return null;
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            using (var DB = new SQLiteConnection(source))
            {
                DB.Open();
                SQLiteCommand CMD = new SQLiteCommand(DB);
                CMD = DB.CreateCommand();
                CMD.CommandText = "SELECT * FROM User WHERE Username = @Username AND Password = @Password;";
                CMD.Parameters.Add("@Username", DbType.String).Value = username;
                CMD.Parameters.Add("@Password", DbType.String).Value = password;
                using (SQLiteDataReader reader = CMD.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                        /* string roleStr = reader.GetString(reader.GetOrdinal("Role"));
                         UserRole role = (UserRole)Enum.Parse(typeof(UserRole), roleStr);
                         user.Role = role;*/
                        user.Login = reader.GetString(reader.GetOrdinal("Login"));
                        user.Password = reader.GetString(reader.GetOrdinal("Password"));
                        user.Name = reader.GetString(reader.GetOrdinal("Name"));
                        user.Surname = reader.GetString(reader.GetOrdinal("Surname"));
                        user.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                        user.Email = reader.GetString(reader.GetOrdinal("Email"));
                        return user;
                    }
                }
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            using (var DB = new SQLiteConnection(source))
            {
                DB.Open();
                SQLiteCommand CMD = new SQLiteCommand(DB);
                CMD = DB.CreateCommand();
                CMD.CommandText = "SELECT * FROM User WHERE Email = @Email;";
                CMD.Parameters.Add("@Email", DbType.String).Value = email;
                using (SQLiteDataReader reader = CMD.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                        /* string roleStr = reader.GetString(reader.GetOrdinal("Role"));
                         UserRole role = (UserRole)Enum.Parse(typeof(UserRole), roleStr);
                         user.Role = role;*/
                        user.Login = reader.GetString(reader.GetOrdinal("Login"));
                        user.Password = reader.GetString(reader.GetOrdinal("Password"));
                        user.Name = reader.GetString(reader.GetOrdinal("Name"));
                        user.Surname = reader.GetString(reader.GetOrdinal("Surname"));
                        user.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                        user.Email = reader.GetString(reader.GetOrdinal("Email"));
                        return user;
                    }
                }
            }
            return null;
        }


        public User GetUserByLogin(string login)
        {
            using (var DB = new SQLiteConnection(source))
            {
                DB.Open();
                SQLiteCommand CMD = new SQLiteCommand(DB);
                CMD = DB.CreateCommand();
                CMD.CommandText = "SELECT * FROM User WHERE Login = @Login;";
                CMD.Parameters.Add("@Login", DbType.String).Value = login;
                using (SQLiteDataReader reader = CMD.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                        /* string roleStr = reader.GetString(reader.GetOrdinal("Role"));
                         UserRole role = (UserRole)Enum.Parse(typeof(UserRole), roleStr);
                         user.Role = role;*/
                        user.Login = reader.GetString(reader.GetOrdinal("Login"));
                        user.Password = reader.GetString(reader.GetOrdinal("Password"));
                        user.Name = reader.GetString(reader.GetOrdinal("Name"));
                        user.Surname = reader.GetString(reader.GetOrdinal("Surname"));
                        user.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                        user.Email = reader.GetString(reader.GetOrdinal("Email"));
                        return user;
                    }
                }
            }
            return null;
        }

        public IEnumerable<User> Select()
        {
            throw new NotImplementedException();
        }

        void IUserRepository.UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }

}
