using AutoMapper;
using Subscribere_Core.Interfaces;
using Subscribere_Service_Bl;
using Subscribere_Servise;
using Subscribere_Servise_Dal;

namespace ProjectRuth.Config
{
    public static class Configuration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ISubscriberRepository, SubscriberRepository>();
            services.AddScoped<ISubscriberService, SubscriberService>();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProjectRuthProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
