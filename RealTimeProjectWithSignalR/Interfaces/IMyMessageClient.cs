using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeProjectWithSignalR.Interfaces
{
    public interface IMyMessageClient
    {
        Task Clients(List<string> clients);
        Task ClientJoined(string connectionId);
        Task ClientLeaved(string connectionId);
        Task ReceiveMessage(string user,string message);

    }
}
