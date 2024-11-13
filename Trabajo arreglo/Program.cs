internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de elementos en el arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] arreglo = new int[n];
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine($"Ingrese el valor para la posición {i}: ");

            arreglo[i] = int.Parse(Console.ReadLine());

        }
        
        Console.WriteLine("\nPrimer arreglo:");
        MostrarArreglo(arreglo);

        Console.WriteLine("Ingrese la posición a eliminar (0 a " + (n - 1) + "): ");
        int pos = int.Parse(Console.ReadLine());
        if (pos < 0 || pos >= n)

        {

            Console.WriteLine("Posición inválida.");

            return;

        }

        for (int i = pos; i < n - 1; i++)

        {

            arreglo[i] = arreglo[i + 1];

        }

        n--;

        Console.WriteLine("Arreglo después de eliminar la posición " + pos + ":");

        for (int i = 0; i < n; i++)

        {

            Console.Write(arreglo[i] + " ");

        }

        Console.WriteLine();

    }
    static void MostrarArreglo(int[] arreglo)
    {
        foreach (int num in arreglo)

        {

            Console.WriteLine(num + " ");

        }
        Console.WriteLine();

    }

}