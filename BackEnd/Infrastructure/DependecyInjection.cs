using BackEnd.APIs;
using BackEnd.Interfaces;
using BackEnd.Service;

namespace BackEnd.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection Dependencies(this IServiceCollection Services)
        {

            Services.AddScoped<IServiceUsers, ServiceUsers>();
            Services.AddScoped<IServiceClientes, ServiceClientes>();
            Services.AddScoped<IServiceFiltro, ServiceFiltroMaquinas>();
            Services.AddScoped<IForce1API, Force1API>();    
            Services.AddScoped<IServiceProduto, ServiceProduto>();
            return Services; 
        }
    }
}
