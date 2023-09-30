using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Order> GetOrder()
        {
            var orders = dbContext.Orders;
            var maxOrderSum = orders.Max(x => x.Quantity * x.Price  );
            var order = orders.Where(x => x.Quantity * x.Price == maxOrderSum).FirstOrDefault();
            return order;

        }

        public async Task<List<Order>> GetOrders()
        {
            return await dbContext.Orders.Where(x => x.Quantity > 10).ToListAsync();
        }

       
    }
}
