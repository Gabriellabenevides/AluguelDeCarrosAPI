using AluguelDeCarrosAPI.Interface.Repository;
using AluguelDeCarrosAPI.Repository;

namespace AluguelDeCarrosAPI.Ioc
{
    public static class RepositoryIoc
    {
        public static void ConfigRepositoryIoc(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
