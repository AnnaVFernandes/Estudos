using Crud1.Models;

namespace Crud1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = Configuration;
        }

        public IConfiguration configuration1 { get; }
        public object Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container. 

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<BancoDeDados>();
        }

        //  This method gets called by the runtime. Use this method to configure the HTTP request pipeline

        public void Configure(IApplicationBuilder app, IWebHostEnvironmet env)
        {
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https.//aka.ms/aspnetcore-hsts.app.UseHsts(); 
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id}");
            });
        }
    }
}
