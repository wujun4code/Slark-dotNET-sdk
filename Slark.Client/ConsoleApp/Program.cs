using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TheMessage;

namespace ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var hostBuilder = new HostBuilder().ConfigureLogging((context, builder) =>
            {
                builder.AddConsole();
            });
            var client = new TMClient()
            {
                NickName = "wujun"
            }.ConnnectLobby("http://localhost:3000/play/");

            await hostBuilder.RunConsoleAsync();

            //TMClientBuilder.CreateDefault("wujun").ConnnectLobbyAsync("ws://localhost:3000/lobby").Wait();
        }
    }
}
