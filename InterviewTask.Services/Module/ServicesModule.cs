using InterviewTask.Common.Service;
using InterviewTask.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace InterviewTask.Services.Module
{
    public static class ServicesModule
    {
        public static IServiceCollection LoadServiceModule(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();

            return services;
        }
    }
}
