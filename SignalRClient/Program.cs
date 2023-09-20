using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace SignalRClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HubConnection connection = new HubConnectionBuilder()
               .WithUrl("https://localhost:7255/chatHub", Microsoft.AspNetCore.Http.Connections.HttpTransportType.ServerSentEvents)
               .Build();
            await Task.Delay(TimeSpan.FromSeconds(5));
            await connection.StartAsync();

            await connection.StopAsync();
        }
    }
}