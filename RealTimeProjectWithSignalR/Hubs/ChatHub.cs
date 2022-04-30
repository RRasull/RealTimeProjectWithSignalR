using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace RealTimeProjectWithSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("clientJoined",Context.ConnectionId);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("clientLeaved", Context.ConnectionId);

        }


    }
}
