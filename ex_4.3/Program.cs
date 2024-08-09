Console.WriteLine("Escolha uma cor para traduzir:");
Console.WriteLine("1 - Vermelho");
Console.WriteLine("2 - Azul");
Console.WriteLine("3 - Verde");
Console.WriteLine("4 - Amarelo");
Console.WriteLine("5 - Roxo");

int escolha = Convert.ToInt32(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Vermelho em inglês é: Red");
        break;
    case 2:
        Console.WriteLine("Azul em inglês é: Blue");
        break;
    case 3:
        Console.WriteLine("Verde em inglês é: Green");
        break;
    case 4:
        Console.WriteLine("Amarelo em inglês é: Yellow");
        break;
    case 5:
        Console.WriteLine("Roxo em inglês é: Purple");
        break;
    default:
        Console.WriteLine("Cor não reconhecida.");
        break;
}



