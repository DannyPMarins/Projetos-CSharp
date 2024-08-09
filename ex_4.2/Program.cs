Console.WriteLine("Tradutor: qual é a tradução das cores?");

Console.WriteLine("Como é vermelho em ingles:" +
    " 1 - Orange, " +
    " 2 - Purple," +
    " 3 - Black," +
    " 4 - Red. ");

int num = Convert.ToInt32(Console.ReadLine());


switch (num)
{
    case 1:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 2:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 3:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 4:
        Console.WriteLine("Voce acertou #4 é vermelho.");
        break;
    default:
        Console.WriteLine("ERRO! o numero digitado Não é valido");
        Console.WriteLine("/n");
        break;
}

Console.WriteLine("Como é azul em ingles:" +
    " 1 - Orange, " +
    " 2 - Blue," +
    " 3 - Black," +
    " 4 - Red. ");

int num1 = Convert.ToInt32(Console.ReadLine());


switch (num1)
{
    case 1:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 2:
        Console.WriteLine("Voce acertou #2 é azul.");
        break;
    case 3:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 4:
        Console.WriteLine("Erro! tente novamente.");
        break;
    default:
        Console.WriteLine("ERRO! o numero digitado Não é valido");
        Console.WriteLine("");
        break;
}

Console.WriteLine("Como é laranja em ingles:" +
    " 1 - Orange, " +
    " 2 - Blue," +
    " 3 - Black," +
    " 4 - Red. ");

int num2 = Convert.ToInt32(Console.ReadLine());


switch (num2)
{
    case 1:
        Console.WriteLine("Voce acertou #1 é laranja.");
        break;
    case 2:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 3:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 4:
        Console.WriteLine("Erro! tente novamente.");
        break;
    default:
        Console.WriteLine("ERRO! o numero digitado Não é valido");
        Console.WriteLine("");
        break;
}

Console.WriteLine("Como é preto em ingles:" +
    " 1 - Orange, " +
    " 2 - Purple," +
    " 3 - Black," +
    " 4 - Red. ");

int num3 = Convert.ToInt32(Console.ReadLine());


switch (num3)
{
    case 1:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 2:
        Console.WriteLine("Erro! tente novamente.");
        break;
    case 3:
        Console.WriteLine("Voce acertou #3 é preto.");
        break;
    case 4:
        Console.WriteLine("Erro! tente novamente.");
        break;
    default:
        Console.WriteLine("ERRO! o numero digitado Não é valido");
        Console.WriteLine("");
        break;
}

