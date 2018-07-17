using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud;

namespace TheMessage
{
    public class TMClient : PlayMonoBehaviour
    {
        public TMClient()
        {
            AVClient.Initialize("315XFAYyIGPbd98vHPCBnLre-9Nh9j0Va", "Y04sM6TzhMSBmCMkwfI3FpHc");
        }
        ClientWebSocket websocketClient;
        public string NickName { get; set; }

        public TMClient ConnnectLobby(string lobbyWebSocketUrl)
        {
            Play.ToggleLog(true);
            Play.Logger = (message) => 
            {
                Console.WriteLine(message);
            };
            Play.UserID = NickName;
            Play.SetRouteServer(lobbyWebSocketUrl);
            Play.Connect("0.0.1");

            return this;
        }

        [PlayEvent]
        public override void OnAuthenticated()
        {
            Play.Log("OnAuthenticated");
        }
    }
}
