using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class DrawingBoardHub : Hub
{
    public async Task Draw(int x, int y)
    {
        await Clients.Others.SendAsync("ReceiveDraw", x, y);
    }
}