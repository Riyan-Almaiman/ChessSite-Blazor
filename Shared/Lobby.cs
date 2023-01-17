/* Shared classes can be referenced by both the Client and Server */
namespace BlazorApp_empty2.Shared
{

       
        public class Lobby
        {
            public Lobby(string name) { this.name = name;
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 7; j >= 0; j--)
                {
                    this.TileAddresses[i, j] = this.Columns[j] + this.Rows[i];
                }
            }
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (i == 0) { boardstate[i, j] = Player2pieces[j]; }

                    else if (i == 7) { boardstate[i, j] = Player1pieces[j]; }

                    else if (i == 6) { boardstate[i, j] = $"p{j + 1}"; }

                    else if (i == 1) { boardstate[i, j] = $"P{j + 1}"; }

                    else { boardstate[i, j] = "  "; }


                }
            }
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    lobbystate.Add(TileAddresses[i, j], boardstate[i, j]);





                }


            }
        }

            public string lastmove { get;  set; }
            public int turn = 2;
            public string name { get; set; }
            public string  player1 { get; set; }
            public string player2 { get; set; }
        public string[,] boardstate = new string[8, 8];
            public string[,] TileAddresses = new string[8, 8];

            public Dictionary<string, string> lobbystate = new();
            public int playercount = 0;
             string[] Rows = { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] Columns = { "A", "B", "C", "D", "E", "F", "G", "H" };


             string[] Player1pieces = { "r1", "n1", "b1", "q1", "k1", "b2", "n2", "r2" };
              string[] Player2pieces = { "R1", "N1", "B1", "Q1", "K1", "B2", "N2", "R2" };

        
        public void move(string tileadd, string piece)
        {


            int[] index = indexOfAddress(tileadd);
            int[] index2 = indexOfPiece(piece);
            boardstate[index[0], index[1]] = piece;
            boardstate[index2[0], index2[1]] = "  ";

            lobbystate[tileadd] = piece;

            lobbystate[TileAddresses[index2[0], index2[1]]] = "  ";
        }

        public int[] indexOfPiece(string PieceSelect)
        {
            int[] array = new int[2];
            for (int i = 0; i <= 7; i++)
            {

                for (int j = 0; j <= 7; j++)
                {


                    if (boardstate[i, j] == PieceSelect) { array[0] = i; array[1] = j; }

                }

            }
            return array;
        }
        public int[] indexOfAddress(string AddressSelect)
        {
            int[] array = new int[2];
            for (int i = 0; i <= 7; i++)
            {

                for (int j = 0; j <= 7; j++)
                {


                    if (TileAddresses[i, j] == AddressSelect.ToUpper()) { array[0] = i; array[1] = j; }

                }

            }
            return array;
        }


    }






    
}