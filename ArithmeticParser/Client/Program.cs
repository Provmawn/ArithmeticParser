using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArithmeticParser.Client.Source;
using ArithmeticParser.Client.Interfaces;

namespace ArithmeticParser.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<ILexer, Lexer>();
            builder.Services.AddSingleton<IParser, Parser>();

            await builder.Build().RunAsync();
        }
    }
}
