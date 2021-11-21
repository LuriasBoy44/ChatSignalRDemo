using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomsProyect
{    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string room, string message)
        {
            await Clients.Group(room).SendAsync("ReceiveMessage",user,message);        
        }
        public async Task AddToGroup( string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId,room);
            await Clients.Group(room).SendAsync("ShowWho", $"Algien se conectó {Context.ConnectionId}");

        }
    }
}
