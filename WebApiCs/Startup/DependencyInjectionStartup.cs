using AspNetDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WebActivatorEx;
using WebApiCs.Startup;

[assembly: PreApplicationStartMethod(typeof(DependencyInjectionStartup), methodName: nameof(DependencyInjectionStartup.PreStart))]
// [assembly: PostApplicationStartMethod(typeof(DependencyInjectionStartup), methodName: nameof(DependencyInjectionStartup.PostStart))] // Uncomment this if you have any Post-start logic you want to run.
// [assembly: OwinStartup( typeof( SampleApplicationStart ), methodName: nameof( SampleApplicationStart.OwinStartup ) )] // Uncomment this if you're using SignalR or other features that depend on OWIN.

namespace WebApiCs.Startup
{
    /// <summary>Startup class for the AspNetDependencyInjection NuGet package.</summary>
    internal static class DependencyInjectionStartup
    {
        private static ApplicationDependencyInjection _di;

        /// <summary>Invoked when the ASP.NET application starts up, before Global's Application_Start method runs. Dependency-injection should be configured here.</summary>
        internal static void PreStart()
        {
            System.Diagnostics.Debug.WriteLine($"{nameof(DependencyInjectionStartup)}.{nameof(PreStart)}() called.");

            _di = new ApplicationDependencyInjectionBuilder()
                .ConfigureServices(ConfigureServices)
                .AddWebApiDependencyResolver()
                .Build();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDefaultHttpContextAccessor()
                .AddScoped<IValueRepo, ValueRepo>();
        }
    }
}