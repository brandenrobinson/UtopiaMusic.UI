using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace Utopia.UI.BlazorApp
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.Services
				.AddBlazorise(options =>
				{
					options.ChangeTextOnKeyPress = true;
				})
				.AddBootstrapProviders()
				.AddFontAwesomeIcons();

			builder.RootComponents.Add<App>("app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

			var host = builder.Build();

			host.Services
			.UseBootstrapProviders()
			.UseFontAwesomeIcons();

			await host.RunAsync();
		}
	}
}
