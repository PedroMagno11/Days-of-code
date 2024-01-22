using ConverterIdadeEmDias;

Console.WriteLine("Bem-vindo(a) ao conversor de idade em dias!");
try
{
    Console.Write("Informe a sua idade: ");
    int idade = int.Parse(Console.ReadLine()!);
    int diasDeVida = Conversor.IdadeEmDias(idade);
    Console.WriteLine($"Até o momento, você teve {diasDeVida} dias de vida.");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

