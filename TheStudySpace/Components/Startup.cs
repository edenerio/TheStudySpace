using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSignalR();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //app.UseRouting();
        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapHub<CollaborationHub>("/collaborationHub");
        //});
    }
}