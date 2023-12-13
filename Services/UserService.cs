using JWT_Tutorial.Models;
using JWT_Tutorial.Repositories;

namespace JWT_Tutorial.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o=>
            o.Username.Equals(userLogin.Username, StringComparison.OrdinalIgnoreCase) &&
            o.Password.Equals(userLogin.Password));

            return user;
        }
    }
}
