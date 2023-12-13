using JWT_Tutorial.Models;

namespace JWT_Tutorial.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new ()
            {
                Username = "admin",
                EmailAddress = "admin@localhost",
                Password = "admin",
                GivenName = "Admin",
                Surname = "User",
                Role = "Administrator"
            },
            new ()
            {
                Username = "user",
                EmailAddress = "user@localhost",
                Password = "user",
                GivenName = "Normal",
                Surname = "User",
                Role = "Standard"
            }
        };
    }
}
