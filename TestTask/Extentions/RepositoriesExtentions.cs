using Microsoft.Extensions.DependencyInjection;
using TestTask.Repositories;
using TestTask.Services.classes;
using TestTask.Services.Interfaces;

namespace TestTask.Extentions
{
    public static class RepositoriesExtentions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
         
        }
        public static void AddServices(this IServiceCollection services)
        {
            
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IOrderService, OrderService>();
        }
    }
}
