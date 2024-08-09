// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero Inteiro: ");

int n = Convert.ToInt32(Console.ReadLine());
long m = 1;

for (int i = 1; i <= n; i++)
{
    m *= n;

}
Console.WriteLine($"Resultado fatorial é: {m}");

