using Bin2Dec.Entidates;
using Bin2Dec.Exceptions;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Bin2Dec.Menu;

internal static class Menu
{
    public static void ExibirMenu()
    {
        Console.WriteLine("Escolha a sua opção :");
        Console.WriteLine("1 - Converter Binário para Decimal");
        Console.WriteLine("2 - Converter Decimal para Binário");
        Console.Write("Sua opção: ");
        
        switch (Console.ReadLine()!)
        {
            case "1":
                Console.Clear();
                ConverteBinarioParaDecimal();
                Console.Clear();
                ExibirMenu();
                break;
            case "2":
                Console.Clear();
                ConverteDecimalParaBinario();
                Console.Clear();
                ExibirMenu();
                break;
            default:
                Console.WriteLine("Opção inválida");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirMenu();
                break;
        }
    }

    private static void ConverteDecimalParaBinario()
    {
        try
        {
            Console.Write("Informe o numero decimal que deseja converter: ");
            string valor = Console.ReadLine()!;
            string resultado = Conversor.DecimalParaBinario(valor);
            Console.WriteLine($" O numero decimal: {valor} é igual ao número binário: {resultado} ");
            Console.ReadKey();
        }
        catch(EntradaException ex)
        {
            throw new EntradaException(ex.Message, ex);
        }
    }
    private static void ConverteBinarioParaDecimal()
    {
        try
        {
            Console.Write("Informe o numero binário que deseja converter: ");
            string valor = Console.ReadLine()!;
            string auxiliar = Regex.Replace(valor, @"[^\d]", " ");
            int resultado = Conversor.BinarioParaDecimal(valor);
            
            Console.WriteLine($" O numero binário: {auxiliar} é igual ao número decimal: {resultado} ");
            Console.ReadKey();
        }
        catch (EntradaException ex)
        {
            throw new EntradaException (ex.Message, ex);
        }
        
    }
}
