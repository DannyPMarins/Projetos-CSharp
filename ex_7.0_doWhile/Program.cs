// Firt code
int numero;

do
{
    Console.WriteLine("Digite um numero positivo: ");
    numero = Convert.ToInt32(Console.ReadLine());
}while(numero <= 0);
Console.WriteLine($"Voce digitou o numero positivo: {numero}");

// Second code

Console.WriteLine("Digite um numero inteiro: ");
double numero1 = Convert.ToDouble(Console.ReadLine());
int numero2 = (int)numero1;

if( numero1 == numero2)
{
    Console.Write("O numero é inteiro");
}else
{
    Console.WriteLine("O numero não é inteiro");
}