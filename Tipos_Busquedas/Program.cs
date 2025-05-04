using Tipos_Busquedas;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int indice = BusquedaLineal.Buscar(numeros, 30);

        if (indice != -1)
            Console.WriteLine($"Elemento encontrado en el índice {indice}");
        else
            Console.WriteLine("Elemento no encontrado");

        int[] numeros1 = { 5, 10, 15, 20, 25, 30 };
        int indice1 = BusquedaBinaria.Buscar(numeros, 20);

        if (indice != -1)
            Console.WriteLine($"Elemento encontrado en el índice {indice}");
        else
            Console.WriteLine("Elemento no encontrado");
    }
}
