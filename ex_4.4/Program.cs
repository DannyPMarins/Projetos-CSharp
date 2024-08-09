// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"Escolha sua classe:
1 - Do
2 - Re
3 - Mi
4 - Fa
5 - Sol
6 - La
7 - Si
");

int escolha = Convert.ToInt32(Console.ReadLine());
string resposta;

switch (escolha)
//{
//    case 1:
//        Console.WriteLine("Dó (C) tem frequência de aproximadamente 261.63 Hz");
//        Console.WriteLine("Gostaria de saber a nota em sustenido?");
//        resposta = Console.ReadLine();
//        resposta1 = resposta.ToLower();
//        if (resposta1 == "sim")
//        {
//            Console.WriteLine("Dó Sustenido (C#) tem frequência de aproximadamente 17.32 Hz");
//        }
//}
{
    case 1:
        Console.WriteLine(@"A frequência sonora da nota Do é de 264Hz
Gostaria de saber a nota em sustenio?");

        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Dó Sustenido (C#) tem frequência de aproximadamente 17.32 Hz");
        }
        break;
    case 2:
        Console.WriteLine(@"A frequência sonora da nota Ré é de 297Hz
Gostaria de saber a nota em sustenio?");

        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Ré Sustenido (D#) tem frequência de aproximadamente 19.44 Hz");
        }
        break;
    case 3:
        Console.WriteLine(@"A frequência sonora da nota Mi de 330Hz
Gostaria de saber a nota em sustenio?");
        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Ré não tem nota sustenida");
        }
        break;
    case 4:
        Console.WriteLine(@"A frequência sonora da nota Fa é de 352Hz
Gostaria de saber a nota em sustenio?");
        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Fá Sustenido (F#) tem frequência de aproximadamente 23.12 Hz");
        }
        break;
    case 5:
        Console.WriteLine(@"A frequência sonora da nota Sol é de 396Hz
Gostaria de saber a nota em sustenio?");
        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Sol Sustenido (G#) tem frequência de aproximadamente 25.95 Hz");
        }
        break;
    case 6:
        Console.WriteLine(@"A frequência sonora da nota Lá é de 440Hz
Gostaria de saber a nota em sustenio?");
        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Lá Sustenido (A#) tem frequência de aproximadamente 29.13 Hz");
        }
        break;
    case 7:
        Console.WriteLine(@"A frequência sonora da nota Si é de 495Hz
Gostaria de saber a nota em sustenio?");
        resposta = Console.ReadLine();
        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM" || resposta == "s" || resposta == "S")
        {
            Console.WriteLine("Frequencia Si não possui sustenido");
        }
        break;
    default:
        Console.WriteLine("Erro!");
        break;
}

