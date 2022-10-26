
int sumar = 0;
int valores;
Console.WriteLine("Ingrese un numero: ");
valores = int.Parse(Console.ReadLine());

while (valores < 999)
{
    sumar = sumar + valores;
    valores++;
}
Console.WriteLine(sumar);
Console.ReadLine();