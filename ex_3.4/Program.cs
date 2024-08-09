// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero dos personagems disponiveis: ");
Console.WriteLine("1-Bardo, 2-Arqueiro, 3-Guerreiro e 4-Mago");

int numero = Convert.ToInt32(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine("Voce selecionou o numero 1 = Barbo");
} else if (numero == 2)
{
    Console.WriteLine("Voce selecionou o numero 2 = Arqueiro");
}else if (numero == 3)
{
    Console.WriteLine("Voce selecionou o numero 3 = Guerreiro");
}else if(numero == 4)
{
    Console.WriteLine("Voce selecionou o numero 4 = Mago");
}
else
{
    Console.WriteLine("ERRO! o numero digitado Não é valido");
}

Console.ReadKey();
