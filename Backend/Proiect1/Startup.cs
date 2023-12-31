using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proiect1.DAL;
using Microsoft.AspNetCore.Identity;
using Proiect1.DAL.Entities;
using Proiect1.BLL.Managers;
using Proiect1.BLL.Interfaces;
using Proiect1.BLL.Helpers;
using Proiect1.BLL.Repositories;
using System.Threading.Tasks;
using Proiect1.Services.Interfaces;

namespace Proiect1;

public class Startup
{
    public string SpecificOrigins = "_allowSpecificOrigins";
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {

        services.AddCors(options =>
        {
            options.AddPolicy(name: SpecificOrigins,
                              builder =>
                              {
                                  builder.WithOrigins("localhost:3000", "http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
                              });
        });

        // services.AddControllers();
        services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnString")),
        ServiceLifetime.Transient);

        services.AddTransient<IAuthManager, AuthManager>();
        services.AddTransient<ITokenHelper, TokenHelper>();
        services.AddTransient<InitialSeed>();

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUserManager, UserManager>();

        services.AddTransient<IBookRepository, BookRepository>();
        services.AddTransient<IBookManager, BookManager>();

        services.AddSwagger();

        services.AddIdentity<User, Role>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        services.AddAuthorization(opt =>
        {
            opt.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
            opt.AddPolicy("User", policy => policy.RequireRole("User").Build());
        });
    }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, InitialSeed initialSeed)
    {
        if (env.IsDevelopment())
        { 
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Proiect1 v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseCors(SpecificOrigins);

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseStatusCodePages();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

    }
}
