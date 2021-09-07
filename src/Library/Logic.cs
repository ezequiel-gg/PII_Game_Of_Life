namespace PII_Game_Of_Life
{
    public abstract class Logic
    {
        public Board Game(Board board)
        {
            for (int x = 0; x < board.BoardWidth; x++)
            {
                for (int y = 0; y < board.BoardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<board.BoardWidth && j>=0 && j < board.BoardHeight && board.GameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(board.GameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (board.GameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        board.Cloneboard[x,y] = false;
                    }
                    else if (board.GameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        board.Cloneboard[x,y] = false;
                    }
                    else if (!board.GameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        board.Cloneboard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        board.Cloneboard[x,y] = board.GameBoard[x,y];
                    }
                }
            }

            return board;
        }
    }
}