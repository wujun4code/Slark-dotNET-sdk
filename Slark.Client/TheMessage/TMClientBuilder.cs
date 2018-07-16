using System;
using System.Threading.Tasks;

namespace TheMessage
{
    public static class TMClientBuilder
    {
        public static TMClient CreateDefault(string nickName)
        {
            return new TMClient()
            {
                NickName = nickName
            };
        }

        public static Task<TMClient> UseLobby(this TMClient client, string lobbyWebSocketUrl)
        {
            return client.ConnnectLobbyAsync(lobbyWebSocketUrl);
        }
    }
}
