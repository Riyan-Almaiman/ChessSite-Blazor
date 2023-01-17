using Microsoft.AspNetCore.SignalR;
using BlazorApp_empty2.Shared;
using System.IO.Pipelines;

namespace BlazorApp_empty2.Server
{

    public class GameHub : Hub
{

        private readonly Lobbies lobbies;

        public GameHub(Lobbies lobbies)
        {
            this.lobbies = lobbies;
        }

        public async Task SendMove(string tildadd, string piece, string lobbyname)
        {
            await Clients.GroupExcept(lobbyname, Context.ConnectionId).SendAsync("ReceiveMove", tildadd, piece);

            lobbies.LobbyList[lobbyname].turn++;

            lobbies.LobbyList[lobbyname].move(tildadd, piece)
                ;
            Console.WriteLine($"sent from { Context.ConnectionId}"); 
        }



        public async Task JoinLobby(string lobbyname, string connectionid)
        {

            await Groups.AddToGroupAsync(connectionid, lobbyname);

            if (lobbies.LobbyList[lobbyname].player1 == null) 
            {
                lobbies.LobbyList[lobbyname].player1 = connectionid;
                await Clients.Caller.SendAsync("playernumber", 1);

            }
            else
            {
               
                lobbies.LobbyList[lobbyname].player2 = connectionid;
                await Clients.Caller.SendAsync("playernumber", 2);
            }


        }







    }
}
