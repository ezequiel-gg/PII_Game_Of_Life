using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            FileType file = new FileType("\n", "../../assets/board.txt");
            bool[,] boardBool = ReadFile.Read(file);
            Board board = new Board(boardBool);
            while (true)
            {
                Logic.Game(board);
                PrintBoard.Print(board);
            }
            
        }
    }
}
