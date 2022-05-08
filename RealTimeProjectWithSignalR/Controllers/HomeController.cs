using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeProjectWithSignalR.Business;
using RealTimeProjectWithSignalR.Hubs;
using System.Threading.Tasks;

namespace RealTimeProjectWithSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly IHubContext<ChatHub> _myChatHub;

        public HomeController(IHubContext<ChatHub> myChatHub)
        {
            _myChatHub = myChatHub;
        }

        //[HttpGet("{user message}")]
        //public async Task<IActionResult> Index(string user,string message)
        //{
        //    await _myChatHub.SendMessage(user, message);
        //    return Ok();
        //} 
    }
}
