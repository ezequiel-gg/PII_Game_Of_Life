using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class PrintBoard
    {
        public static void Print(Board board)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<board.BoardHeight;y++)
                {
                    for (int x = 0; x<board.BoardWidth; x++)
                    {
                        if(board.GameBoard[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Thread.Sleep(300);
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}