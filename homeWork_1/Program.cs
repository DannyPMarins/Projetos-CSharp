// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero de 1 - 100: ");
int numero = Convert.ToInt32(Console.ReadLine());
int multi;

if (numero < 101)
{

    for (int i = 1; i < 11; i++)
    {
        multi = numero * i;
        Console.WriteLine("A tabuada de multiplicação de " + numero + " vezes " + i + " é: " + multi);
    }
}
else
{
    Console.WriteLine("Erro!!! Digite um numero de 1 á 100");
}

