using System.IO;

namespace PII_Game_Of_Life
{
    public class ReadFile
    {
        public static bool[,] Read(FileType file)
        {
            
            string content = File.ReadAllText(file.Ruta);
            string[] contentLines = content.Split(file.Separador);
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            return board;
        }
    }
}