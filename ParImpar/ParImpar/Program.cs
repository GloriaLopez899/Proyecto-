
Console.WriteLine("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i < numero; i++)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("El numero: " + numero + " es par");
    }
    else
    {
        Console.WriteLine("El numero: " + numero + " es impar");
    }
}
Console.ReadLine();