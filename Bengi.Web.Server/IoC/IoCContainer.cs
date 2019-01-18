using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bengi.Web.Server
{
    /// <summary>
    /// Shorthand access class to get DI services with clean code
    /// </summary>
    public static class IoC
    {
        public static ApplicationDbContext GetApplicationDbContext => IoCContainer.Provider.GetService<ApplicationDbContext>();
    }

    /// <summary>
    /// The DI container making use of the built in .Net core servivce provider
    /// </summary>
    public static class IoCContainer
    {
        public static IServiceProvider Provider { get; set; }
    }
}
