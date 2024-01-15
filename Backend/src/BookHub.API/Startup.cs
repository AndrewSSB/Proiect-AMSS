using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BookHub.DAL;
using Microsoft.AspNetCore.Identity;
using BookHub.DAL.Entities;
using BookHub.BLL.Managers;
using BookHub.BLL.Interfaces;
using BookHub.BLL.Helpers;
using BookHub.BLL.Repositories;
using System.Threading.Tasks;
using BookHub.Services.Interfaces;
using BookHub.Services.Interfaces.Meet.Manager;
using BookHub.Services.Interfaces.Meet.Repo;
using BookHub.Services.Managers.Meet;
using BookHub.Services.Repositories.Meet;
using BookHub.Services.Managers;
using BookHub.Services.Repositories;

namespace BookHub;

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
            options.AddPolicy(SpecificOrigins,
                              policy =>
                              {
                                  policy
                                    .WithOrigins("http://localhost:3000", "https://localhost:3000")
                                    .AllowAnyMethod()
                                    .AllowAnyHeader();
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

        services.AddTransient<IAgendaRepository, AgendaRepository>();
        services.AddTransient<IAgendaManager, AgendaManager>();

        services.AddTransient<IFeedbackRepository, FeedbackRepository>();
        services.AddTransient<IFeedbackManager, FeedbackManager>();

        services.AddTransient<ITradeRepository, TradeRepository>();
        services.AddTransient<ITradeManager, TradeManager>();

        services.AddTransient<IPostRepository, PostRepository>();
        services.AddTransient<IPostManager, PostManager>();

        services.AddTransient<IFriendshipRepository, FriendshipRepository>();
        services.AddTransient<IFriendshipManager, FriendshipManager>();

        services.AddTransient<IMeetingRepository, MeetingRepository>();

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
            app.UseSwaggerUI(c => 
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Proiect1 v1");
                    c.RoutePrefix = string.Empty;
                }
            );
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

        initialSeed.CreateRoles();
        Task.Run(async () =>
        {
            await initialSeed.CreateUsers();
        }).Wait();
    }
}
