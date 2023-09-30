using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.classes
{
    public class OrderService : IOrderRepository
    {
        private IOrderRepository _orderService;

        public OrderService(IOrderRepository orderService)
        {
            _orderService = orderService;
        }

        public async Task<Order> GetOrder()
        {
            return await _orderService.GetOrder();
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _orderService.GetOrders();
        }
    }
}
