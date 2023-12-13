using JWT_Tutorial.Models;

namespace JWT_Tutorial.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
