// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tradutor: qual é a tradução das cores?");

Console.WriteLine("#1 - Green");
string name = Convert.ToString(Console.ReadLine());

if (name == "verde" ||  name == "Verde")
{
    Console.WriteLine("Parabens, voce acertou!");
}
else
{
    Console.WriteLine("Erro!, tente novamente.");
}

Console.WriteLine("#2 - Blue");
string name1 = Convert.ToString(Console.ReadLine());

if (name1 == "azul" | name1 == "Blue")
{
    Console.WriteLine("Parabens, voce acertou!");
}
else
{
    Console.WriteLine("Erro!, tente novamente.");
}