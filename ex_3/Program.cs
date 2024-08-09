Console.WriteLine("Exemplo com 'if': ");
Console.WriteLine("Digite um numero: ");

int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0 ){
    Console.WriteLine("O numero é positivo.");
}else
{
    Console.WriteLine("O numero não é positivo.");
}

Console.ReadKey();