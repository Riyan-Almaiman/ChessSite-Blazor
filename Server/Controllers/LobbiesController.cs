using BlazorApp_empty2;
using BlazorApp_empty2.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;
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
                var test = JsonConvert.SerializeObject(lobbies.LobbyList[lobby]);

                lobbies.LobbyList[lobby].playercount++; return Ok(test);
                
            }

            else { return NotFound(null);  }

        }

        [HttpPut("CreateLobby")]
        public ActionResult create([FromBody]string lobby)
        {
            if (lobbies.LobbyList.ContainsKey(lobby)) { return NotFound(null); }

            else
            {

                lobbies.LobbyList.Add(lobby, new Lobby(lobby));
                lobbies.LobbyList[lobby].playercount++;
               
                var test = JsonConvert.SerializeObject(lobbies.LobbyList[lobby]);
                return Ok(test);

            }
        }

    }

    
}