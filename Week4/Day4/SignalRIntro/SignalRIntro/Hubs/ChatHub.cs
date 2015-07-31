using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRIntro.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.SendMessage(message);
        }
        
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}