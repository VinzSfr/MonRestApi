using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MonRestApi.Business;
using MonRestApi.Business.Implements;
using MonRestApi.Infrastructure.Data;
using MonRestApi.Repositories;
using MonRestApi.Repositories.Implements;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

[assembly: FunctionsStartup(typeof(MonRestApi.Startup))]
namespace MonRestApi
{
    public class Startup : IWebJobsStartup
    {
        public Startup()
        {

        }

        public void Configure(IWebJobsBuilder builder)
        {
            //A Deco
            /*builder.Services.AddDbContext<TicketDbContext>(options =>
            {
                options.UseMySql("Server=127.0.0.1;Database=VirusDrive;", mySqlOptions => mySqlOptions
                    // replace with your Server Version and Type
                    .ServerVersion(new Version(8, 0, 18), ServerType.MySql));
            });*/

            builder.Services.AddSingleton<ITicketRepository, TicketRepository>();
            builder.Services.AddSingleton<ITicketBusiness, TicketBusiness>();

        }
    }
}