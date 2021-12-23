using DotNetCoreApiStarter.Data;
using DotNetCoreApiStarter.Data.Repositories;
using DotNetCoreApiStarter.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test_Assignment_Project.Data.Repositories;
using Test_Assignment_Project.Data.Repositories.Interface;
using Test_Assignment_Project.Services;
using Test_Assignment_Project.Services.Interface;

namespace Test_Assignment_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BusinessDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISearchService, SerchService>();
            services.AddTransient<IRestApiService, RestApiService>();
            services.AddTransient<IRecordService, RecordService>();
            services.AddTransient<ISearchHistoryService, SearchHistoryService>();
            services.AddTransient<IRestApiService, RestApiService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ISearchResultRepository, SearchResultRepository>();
            services.AddTransient<IRecordRepository, RecordRepository>();
            services.AddTransient<ISearchHistoryRepository, SearchHistoryRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseMiddleware<RequestMiddleware>();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
