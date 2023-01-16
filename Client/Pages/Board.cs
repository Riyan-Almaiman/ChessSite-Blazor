namespace BlazorApp_empty2.Pages
{
    public class Board


    {



        public Dictionary<string, string> BoardState = new Dictionary<string, string>();
        public string[,] BoardLayout = new string[8, 8];

        public string[,] TileAddresses = new string[8, 8];

        public int[] indexOfPiece(string PieceSelect)
        {
            int[] array = new int[2];
            for (int i = 0; i <= 7; i++)
            {

                for (int j = 0; j <= 7; j++)
                {


                    if (BoardLayout[i, j] == PieceSelect) { array[0] = i; array[1] = j; }

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