namespace PII_Game_Of_Life
{
    public class Board
    {
        public bool[,] GameBoard { get; set;}
        public int BoardWidth { get; }
        public int BoardHeight { get; }

        public bool[,] Cloneboard { get; set; }

        public Board( bool[,] gameBoard)
        {
            this.BoardWidth = gameBoard.GetLength(0);
            this.BoardHeight = gameBoard.GetLength(1);
            this.GameBoard = gameBoard;
            this.Cloneboard = new bool[BoardWidth, BoardHeight];
        }
    }
}