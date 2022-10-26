int tiempo;
int sueldo;

Console.WriteLine("Ingrese su sueldo");
sueldo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo que ha trabajado: ");
tiempo = int.Parse(Console.ReadLine());

if (sueldo < 500 && tiempo >= 10)
{
    Console.WriteLine("Su sueldo: " + sueldo + (" aumento: " + sueldo * 0.2));
}
else if (sueldo < 500 && tiempo < 10)
{
    Console.WriteLine("Su sueldo: " + sueldo + (" aumento: " + sueldo * 0.05));
}
else if (sueldo >= 500)
{
    Console.WriteLine("Su sueldo es de: " + sueldo);
}
Console.ReadLine();