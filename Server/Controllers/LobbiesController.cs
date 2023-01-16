using BlazorApp_empty2;
using BlazorApp_empty2.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace BlazorAppServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LobbiesController : ControllerBase
    {
     

        private readonly Lobbies lobbies;

        public LobbiesController(Lobbies lobbies)
        {
            this.lobbies = lobbies;
        }

        [HttpPut("JoinLobby")]
        public ActionResult join([FromBody] string lobby)
        {

            if (lobbies.LobbyList.ContainsKey(lobby) && lobbies.LobbyList[lobby].playercount<2) {
                lobbies.LobbyList[lobby].playercount++; return Ok("Joined"); 
            }

            else { return Ok("JoinFailed"); }

        }

        [HttpPut("CreateLobby")]
        public ActionResult create([FromBody] string lobby)
        {
            if (lobbies.LobbyList.ContainsKey(lobby)) { return Ok("CantCreate"); }

            else
            {
                
                lobbies.LobbyList.Add(lobby, new Lobby(lobby));
                lobbies.LobbyList[lobby].playercount++;
                return Ok("Created"); 
            }
        }

    }

}