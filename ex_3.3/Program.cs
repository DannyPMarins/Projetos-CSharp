

Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

if (numero % 3 == 0)
{
    Console.WriteLine(numero * 5);
}
else
{
    Console.WriteLine(numero * 3);
}

Console.ReadKey();