Console.WriteLine("Digite um numero dos personagems disponiveis: ");
Console.WriteLine("1-Bardo, 2-Arqueiro, 3-Guerreiro e 4-Mago");

int classe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Atividade recomendada:");

switch (classe)
{
    case 1:
        Console.WriteLine("Voce escolheu o Barbo #1");
        break;
    case 2:
        Console.WriteLine("Voce escolheu o Arqueiro #2");
        break;
    case 3:
        Console.WriteLine("Voce escolheu o Guerreiro #3");
        break;
    case 4:
        Console.WriteLine("Voce escolheu o Mago #4");
        break;
    default:
        Console.WriteLine("ERRO! o numero digitado Não é valido");
        break;
}
