using EksamensProjekt;
using EksamensProjekt.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise;
using Blazorise.Bootstrap;


namespace EksamensProjekt
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddSingleton<IServiceClass, ServiceClass>();

            builder.Services
    .AddBlazorise(options =>
    {
        // Configure Blazorise options if needed
    })
    .AddBootstrapProviders();

            ;


            await builder.Build().RunAsync();
		}


	}

}
