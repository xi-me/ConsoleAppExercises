/* Programa que permite ver el contenido de un archivo plano */
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string line;

        try
        {
            Console.WriteLine("Dirección del archivo:");
            string path = Console.ReadLine();

            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }
        catch (Exception e) 
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}