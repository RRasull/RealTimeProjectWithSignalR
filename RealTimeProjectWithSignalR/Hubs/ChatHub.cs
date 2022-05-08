using Microsoft.AspNetCore.SignalR;
using RealTimeProjectWithSignalR.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeProjectWithSignalR.Hubs
{
    public class ChatHub : Hub<IMyMessageClient>
    {
       readonly static List<string> clients = new List<string>();

        public async Task SendMessage(string user, string message)
        {
            /*await Clients.All.SendAsync("ReceiveMessage", user, message)*/;
            await Clients.All.ReceiveMessage(user,message);
        }

        public override async Task OnConnectedAsync()
        {
            clients.Add(Context.ConnectionId);
            //await Clients.All.SendAsync("clients",clients);
            //await Clients.All.SendAsync("clientJoined",Context.ConnectionId);

            await Clients.All.Clients(clients);
            await Clients.All.ClientJoined(Context.ConnectionId);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            clients.Add(Context.ConnectionId);
            //await Clients.All.SendAsync("clients", clients);
            //await Clients.All.SendAsync("clientLeaved", Context.ConnectionId);

            await Clients.All.Clients(clients);
            await Clients.All.ClientLeaved(Context.ConnectionId);
        }


    }
}
