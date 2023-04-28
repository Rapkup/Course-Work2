
namespace ArpachTax
{
    internal class RegistrationService
    {
        private readonly UserRepository userRepository;
        private readonly PasswordHasher passwordHasher;


        RegistrationService()
        {
            userRepository = new UserRepository();
            
        }
        public void RegisterNewClient(string login, string password, string name, string surname, string phone, string email)
        {
            // Проверяем, что пользователь с таким email не уже зарегистрирован
            if (userRepository.GetUserByEmail(email) != null)
            {
                throw new Exception("Пользователь с таким email уже зарегистрирован");
            }
            string hashedPassword = passwordHasher.HashPassword(password);

            // Создаем нового пользователя
            var newClient = new Client
            {
                Login = login,
                Password = hashedPassword,
                Name = name,
                Surname = surname,
                Phone = phone,
                Email = email
            };

            // Добавляем нового пользователя в репозиторий
            bool result = userRepository.Create(newClient);

            // Возвращаем ID нового пользователя
            // Присваиваем личный ID клиенту
            newClient.ID = userRepository.GetUserByEmail(email).ID;
        }
    }
}
