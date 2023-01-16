/* Shared classes can be referenced by both the Client and Server */
namespace BlazorApp_empty2.Shared
{

       
        public class Lobby
        {
            public Lobby(string name) { this.name = name; }

            public int turn { get; set; }   
            public string name { get; set; }
            public string  player1 { get; set; }
            public string player2 { get; set; }   
            public string[,] lobbystate { get; set; }

            public int playercount = 0;


        }






    
}