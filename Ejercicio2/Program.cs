/* Temporizador para apagar la computadora */

using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int timeToShutDown, minutesToSeconds;
        string cancel;

        Console.WriteLine("Temporizador para apagar la computadora");
        Console.Write("Ingrese el tiempo para apagar (minutos): ");
        minutesToSeconds = int.Parse(Console.ReadLine());
        timeToShutDown = minutesToSeconds * 60;
        Process.Start("cmd.exe", $"/C shutdown -s -t {timeToShutDown}");
        Console.WriteLine("Escribe 'c' para cancelar: ");
        cancel = Console.ReadLine().ToLower();

        if (cancel == "c")
        {
            Process.Start("cmd.exe", "/C shutdown -a");
        }
        else
        {
            Console.WriteLine($"La computadora se apagará en {minutesToSeconds} minutos");
        }
    }
}