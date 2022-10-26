
int x;
int y;

Console.WriteLine("Ingrese la primera coordenada: ");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la segunda coordenada: ");
y = int.Parse(Console.ReadLine());  
Console.WriteLine();

if (x > 0 && y > 0)
{
    Console.WriteLine("Las coordenadas estan en el cuadrante 1.");
}
else if (x <= 0 && y <= 0)
    {
    Console.WriteLine("Las coordenadas estan en el cuadrante 3.");
}
else if (x <= 0 && y > 0)
{
    Console.WriteLine("Las coordenadas estan en el cuadrante 2.");
}
else if (x > 0 && y <= 0)
{
        Console.WriteLine("Las coordenadas estan en el cuadrante 4.");
}
Console.ReadLine();