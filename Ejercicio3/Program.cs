/* Registro de empleados para una planilla de empresa constructora */

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        string fullName, NIT, DUI;
        double hourlyWage, totalWage, allWages = 0;
        int hoursWorked, workers = 5;
        var workerData = new Dictionary<string, Tuple<string, string, int, double, double, double, double>>();

        for (int i = 1; i <= workers; i++)
        {
            Console.WriteLine($"Nombre completo de trabajador #{i}:");
            fullName = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            Console.Write("NIT: ");
            NIT = Console.ReadLine();
            Console.Write("DUI: ");
            DUI = Console.ReadLine();
            Console.Write("Salario por hora: $");
            hourlyWage = double.Parse(Console.ReadLine());
            Console.Write("Horas trabajadas: ");
            hoursWorked = int.Parse(Console.ReadLine());
            totalWage = double.Round(hoursWorked * hourlyWage, 2);
            double renta = double.Round(totalWage * 0.1, 2);
            double neto = totalWage - renta;
            allWages += totalWage;

            workerData.Add(fullName, Tuple.Create(NIT, DUI, hoursWorked, hourlyWage, totalWage, renta, neto));
            
            Console.Clear();
        }

        Console.Write("Nombre".PadRight(20));
        Console.Write("Horas trabajadas".PadRight(20));
        Console.Write("Salario/Hora".PadRight(20));
        Console.Write("Salario".PadRight(20));
        Console.Write("Renta".PadRight(20));
        Console.WriteLine("Neto".PadRight(20));

        foreach (var worker in workerData)
        {
            Console.Write(worker.Key.PadRight(20));
            var tuple = workerData[worker.Key];
            int hours = tuple.Item3;
            double hourWage = tuple.Item4;
            double totWage = tuple.Item5;
            double renta = tuple.Item6;
            double neto = tuple.Item7;
            Console.Write($"{hours}".PadRight(20));
            Console.Write($"${hourWage}".PadRight(20));
            Console.Write($"${totWage}".PadRight(20));
            Console.Write($"${renta}".PadRight(20));
            Console.WriteLine($"${neto}".PadRight(20));
        }
        Console.WriteLine();
        Console.WriteLine($"Total de planilla: ${allWages}");
    }
}