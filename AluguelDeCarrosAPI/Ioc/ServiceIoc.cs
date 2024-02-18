using AluguelDeCarrosAPI.Interface.Service;
using AluguelDeCarrosAPI.Service;

namespace AluguelDeCarrosAPI.Ioc
{
    public static class ServiceIoc
    {
        public static void ConfigServiceIoc(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddHttpContextAccessor();

        }
    }
}
