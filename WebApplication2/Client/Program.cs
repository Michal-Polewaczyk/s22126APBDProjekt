using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("WebApplication2.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebApplication2.ServerAPI"));

            builder.Services.AddApiAuthorization();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@32302e312e30JWu72RyawGTpgWWA40X/mchbYN4/3kAgTzKWt/Wo4f0=");
            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}
