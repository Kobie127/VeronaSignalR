using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using VeronaSingalr;

public class SignalrHub : Hub
{
    Rcon rcon = new Rcon();
    public async Task NewMessage(string user, string message)
    {
        RconType rconResponse = rcon.GetRconcCommand(null, null, null, null);
        
        await Clients.All.SendAsync("messageReceived", user, message);
    }
}