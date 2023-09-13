using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using VeronaSingalr;

public class SignalrHub : Hub
{
    Rcon rcon = new Rcon();
    public async Task NewMessage(string gameId, string command, string itemId, string playerId)
    {
        RconType rconResponse = rcon.GetRconcCommand(gameId, command, itemId, playerId);
        
        await Clients.All.SendAsync("messageReceived", rconResponse);
    }
}