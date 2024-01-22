using Bin2Dec.Exceptions;
using Bin2Dec.Menu;

internal class Program
{
    private static void Main(string[] args)
    {
        COMECO:
        try
        {
            Menu.ExibirMenu();
        }
        catch (EntradaException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            Console.ReadLine();
        }
        
        goto COMECO;
        

    }


}
