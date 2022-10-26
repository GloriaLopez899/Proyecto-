Console.Write("Ingrese un numero de tres digitos o menos: ");
string numero = Console.ReadLine();
int contar = numero.Length;
Console.ReadLine();
if (contar < 4)
{
    Console.WriteLine("El numero ingresado tiene " + contar + " digitos");
}
else
{
    Console.WriteLine(contar + "digitos, numero invalido ingrese menor a 3 digitos");
}
Console.ReadLine();
