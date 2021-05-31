using BusinessLogic.Abstraction;
using BusinessLogic.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extensions
{
    public static class ServiceInstallerExtension
    {
        public static void InstallManagerServices(this IServiceCollection services)
        {
            services.AddScoped<IManipulateImageManger, ManipulateImageManger>();
            services.AddScoped<IOperationsManager, OperationsManager>();
        }
    }
}
