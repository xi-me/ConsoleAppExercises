/* Programa para resolver ecuaciones cuadraticas */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Resolución de ecuaciones cuadráticas");
        while (true)
        {
            Console.WriteLine("Escribe 'c' para continuar y 's' para salir:");
            string option = Console.ReadLine().ToLower();
            Console.Clear();

            if (option == "s")
            {
                break;
            }
            else if (option == "c")
            {
                double a, b, c, x1, x2;
                Console.WriteLine("Resolución de ecuaciones de la forma: ax^2 + bx + c = 0");

                Console.Write("Valor de a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Valor de b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Valor de c: ");
                c = double.Parse(Console.ReadLine());

                x1 = -b + Math.Sqrt((b * b) - 4 * a * c);
                x1 /= 2 * a;
                x2 = -b - Math.Sqrt((b * b) - 4 * a * c);
                x2 /= 2 * a;


                x1 = double.Round(x1, 2);
                x2 = double.Round(x2, 2);
                Console.WriteLine("Resultados:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                Console.WriteLine();
                Console.WriteLine("Haz enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
        
    }
}