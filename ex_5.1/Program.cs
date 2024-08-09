// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero Inteiro: ");

int n = Convert.ToInt32(Console.ReadLine());
int soma = 0;

for (int i = 1; i <= n; i++)
{
    soma += i;
    
}
Console.WriteLine($"A soma de 1 a {n} é: {soma}");

