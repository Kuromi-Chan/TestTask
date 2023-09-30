using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<User> GetUser()
        {
            var users = await dbContext.Users.Include(x => x.Orders).ToListAsync();
            var maxOrders = users.Max(x => x.Orders.Count);
            var user = users.Where(x =>  x.Orders.Count() == maxOrders ).FirstOrDefault();
            //user!.Orders = null;
            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            return await dbContext.Users.Where(x => x.Status == Enums.UserStatus.Inactive).ToListAsync();
        }
    }
}
