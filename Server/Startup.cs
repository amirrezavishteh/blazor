using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using P8.Server.DB;
using Swashbuckle.AspNetCore.Swagger;

namespace P8.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /* CORS */
            services.AddCors(options =>
                {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
                }
            );
            /*CORS */
            services.AddControllersWithViews();
            services.AddRazorPages();
            var sqlConnectionString = "Host=ec2-34-200-94-86.compute-1.amazonaws.com;Port=5432;Database=d97ardi9gglis6;Username=rbsdfnjphvcrkf;Password=63c7114be590709b09971535b83f9d17883516b3eff9fab6e073909ed5bdd1f0;sslmode=Prefer;Trust Server Certificate=True;";
            services.AddDbContext<ClotheDbContext>(options => options.UseNpgsql(sqlConnectionString));
            services.AddScoped<ClotheProvider>();
            services.AddDbContext<UserDbContext>(options => options.UseNpgsql(sqlConnectionString));
            services.AddScoped<UserProvider>();
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("a1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "API Title is",
                    Version = "a1"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            /* CORS-POLICY */
            app.UseCors("CorsPolicy");
            /* CORS-POLICY */

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/a1/swagger.json", "a1 api test");
            });
        }
    }
}
