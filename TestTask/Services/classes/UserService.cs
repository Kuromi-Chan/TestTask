using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.classes
{
    public class UserService : IUserRepository
    {
        private IUserRepository _userService;

        public UserService(IUserRepository userService)
        {
            _userService = userService;
        }

        public async Task<User> GetUser()
        {
            return await _userService.GetUser();
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userService.GetUsers();
        }
    }
}
