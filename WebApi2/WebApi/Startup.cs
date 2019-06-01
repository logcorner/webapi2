using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(WebApi.Startup))]
namespace WebApi
{
    public partial class Startup
    {
        // Microsoft.Owin.Host.SystemWeb               <--- Nuget package listing
        // Microsoft.AspNet.WepApi.Owin
        // Swashbuckle
        // Serilog.Sinks.File
        // IdentityServer3.AccessTokenValidation
        public void Configuration(IAppBuilder app)
        {            
            // many times this would be in a "ConfigureAuth" method
            app.UseIdentityServerBearerTokenAuthentication(
                new IdentityServerBearerTokenAuthenticationOptions
                    {
                        Authority = "https://demo.identityserver.io",
                        RequiredScopes = new[] { "api" }
                    });
        }        
    }
}