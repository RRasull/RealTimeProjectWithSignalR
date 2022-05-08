using Microsoft.AspNetCore.SignalR;
using RealTimeProjectWithSignalR.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeProjectWithSignalR.Hubs
{
    public class MessageHub : Hub<IMyMessageClient>
    {
        public async Task SendMessage(string user, string message, IReadOnlyList<string> connectionIds)
        {


            #region Hub Clients Methods

            #region AllExcept

            if(connectionIds is null)
            {
                await Clients.All.ReceiveMessage(user, message);
            }
            else
            {
                await Clients.AllExcept(connectionIds).ReceiveMessage(user, message);
            }

            #endregion
            #endregion

        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.GetConnectionId(Context.ConnectionId);
        }
    }
}
