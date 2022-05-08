using Microsoft.AspNetCore.SignalR;
using RealTimeProjectWithSignalR.Hubs;
using System.Threading.Tasks;

namespace RealTimeProjectWithSignalR.Business
{
    public class MyBusiness
    {
      readonly IHubContext<ChatHub> _hubContext;

        public MyBusiness(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        //public async Task SendMessage(string user, string message)
        //{
        //    await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
        //}

    }
}
