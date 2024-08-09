Console.WriteLine("Digite um numero: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro numero: ");

int num2 = Convert.ToInt32(Console.ReadLine());
int total = num1 + num2;

if (total > 70)
{
    Console.WriteLine("A soma dos numeros " + num1 + " e " + num2 + " é maior que 70, o total é: " + total);
    Console.WriteLine("FINANCEIRO APROVADO");
}else
{
    Console.WriteLine("FINANCEIRO REPROVADO");
}