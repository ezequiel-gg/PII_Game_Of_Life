namespace PII_Game_Of_Life
{
    public class FileType
    {
        public string Separador { get; }
        
        public string Ruta { get; }

        public FileType( string separator, string ruta)
        {
            Separador = separator;
            Ruta = ruta;
        }
    }
}