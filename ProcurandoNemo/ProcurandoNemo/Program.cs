using ProcurandoNemo;

Console.WriteLine("Bem-vindo(a) ao app Procurando Nemo!");
Console.WriteLine("Informe uma frase contendo a palavra 'Nemo':");

try
{
    Console.Write("Sua frase: ");
    string frase = TratandoEntrada(Console.ReadLine()!);
    int posicao = Buscador.ProcurandoNemo(frase);
    if(posicao == 0)
    {
        Console.WriteLine("Não consigo encontrar o Nemo :(");
    }
    else
    {
        Console.WriteLine($"O Nemo foi encontrado na posição {posicao}!");
    }
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Encerrando o programa!");
}

static string TratandoEntrada(string fraseDeEntrada)
{
    string auxiliar = "";

    if (String.IsNullOrEmpty(fraseDeEntrada))
    {
        throw new ArgumentException("Insira uma frase!");
    }

    foreach(string palavra in fraseDeEntrada.Split(' '))
    {
        auxiliar += $"{char.ToUpper(palavra[0]) + palavra.Substring(1)} ";
    }
    return auxiliar;
}