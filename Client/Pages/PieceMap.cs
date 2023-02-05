namespace BlazorApp_empty2.Pages
{
    public static class PieceMap
{

    public static string Pieces(string piece)
    {

        if (piece.Contains('p'))
        {

            return "\u2659";


        }
            
        if (piece.Contains('P'))
        {

            return "\u2659";


        }

        if (piece.Contains('q'))
        {

            return "\u2655";


        }
        if (piece.Contains('Q'))
        {

            return "\u265B";


        }
        if (piece.Contains('r'))
        {

            return "\u2656";


        }
        if (piece.Contains('R'))
        {

            return "\u265C";


        }
        if (piece.Contains('k'))
        {

            return "\u2654";


        }
        if (piece.Contains('K'))
        {

            return "\u265A";


        }
        if (piece.Contains('b'))
        {

            return "\u2657";


        }
        if (piece.Contains('B'))
        {

            return "\u265D";


        }
        if (piece.Contains('n'))
        {

            return "\u2658";


        }
        if (piece.Contains('N'))
        {

            return "\u265E";


        }
        else return piece;















    }






}
}
