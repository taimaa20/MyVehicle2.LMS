using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Common;
using MyVehicle.LMS.INFRA.Repoisitory;
using MyVehicle.LMS.INFRA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API
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
            services.AddControllers();
            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<ICardsRepoisitory, CardsRepoisitory>();
            services.AddScoped<IContactRepoisitory, ContactRepoisitory>();
            services.AddScoped<IReportTypeRepoisitory, ReportTypeRepoisitory>();
            services.AddScoped<IRoleRepoisitory, RoleRepoisitory>();
            services.AddScoped<IUsersRepoisitory, UsersRepoisitory>();

            services.AddScoped<ITestimonialRepository, TestimonialRepository>(); 
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepostiory>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<ILicensingAndInsuranceRepository, LicensingAndInsuranceRepository>();

            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IReportTypeService, ReportTypeService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUsersService, UsersService>();

            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<ILicensingAndInsuranceService, LicensingAndInsuranceService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
