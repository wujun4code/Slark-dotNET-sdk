using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace TheMessage
{
    public class TMClient
    {
        public TMClient()
        {

        }
        ClientWebSocket websocketClient;
        public string NickName { get; set; }

        public async Task<TMClient> ConnnectLobbyAsync(string lobbyWebSocketUrl)
        {
            if (websocketClient == null) websocketClient = new ClientWebSocket();
            await websocketClient.ConnectAsync(new Uri(lobbyWebSocketUrl), CancellationToken.None);
            return this;
        }
    }
}
