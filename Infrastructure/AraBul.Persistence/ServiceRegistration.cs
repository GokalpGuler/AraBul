//using AraBul.Application.Abstractions;
//using AraBul.Persistence.Concretes;
using AraBul.Application.Repositories;
using AraBul.Application.Repositories.ICarRepositories;
using AraBul.Application.Repositories.ICustomerRepositories;
using AraBul.Application.Repositories.IOrderRepositories;
using AraBul.Persistence.Contexts;
using AraBul.Persistence.Repositories;
using AraBul.Persistence.Repositories.CarRepositories;
using AraBul.Persistence.Repositories.CustomerRepositories;
using AraBul.Persistence.Repositories.OrderRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence
{
    // Api ye gelen isteklerin applicationdaki interfaceler kullanılarak persistence katmanındaki classlara yönlendirilmesi burası ile yapılacak. static yapılmasının sebebi extension bir yapılanma olması
    public static class ServiceRegistration
    {
        //IoC container a ekleme yapılması lazım buranın
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<AraBulDbContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Singleton);

            //services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            //services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            //Customer
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            //Car
            services.AddScoped<ICarReadRepository, CarReadRepository>();
            services.AddScoped<ICarWriteRepository, CarWriteRepository>();

            //Order
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
    }
}
