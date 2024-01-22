using Bin2Dec.Exceptions;
using System.Text.RegularExpressions;

namespace Bin2Dec.Entidates;

internal static class Conversor
{
    public static int BinarioParaDecimal(string numeroBinario)
    {

            int expoente = 0;
            int numero;
            int soma = 0;
            if (VerificarSeEBinario(FormatarEntrada(numeroBinario)))
            {
                string numeroInvertido = InverterOrdemDaString(numeroBinario);
                for (int i = 0; i < numeroInvertido.Length; i++)
                {
                    numero = int.Parse(numeroInvertido.Substring(i, 1));
                    soma += numero * (int)Math.Pow(2, expoente);
                    expoente++;
                }
                return soma;
            }
            else
            {
                throw new EntradaException("O valor que está sendo inserido não é um número binário");
            }
    }

    public static string DecimalParaBinario(string numeroDecimal)
    {
        try
        {
            string valor = "";
            int dividendo = int.Parse(FormatarEntrada(numeroDecimal));
            if (dividendo == 0 || dividendo == 1)
            {
                return dividendo.ToString();
            }
            else
            {
                while (dividendo > 0)
                {
                    valor += (dividendo % 2).ToString();
                    dividendo /= 2;
                }
                return InverterOrdemDaString(valor);
            }
        }
        catch(EntradaException e)
        {
            throw new EntradaException(e.Message);
        }
        
    }

    private static string FormatarEntrada(string str)
    {
        string strFormatada = Regex.Replace(str, @"[^\d]", " ");
        if (strFormatada.Length > 8 || Regex.IsMatch(str, @"[a-zA-Z]"))
        {
            throw new EntradaException("O número excede a quantidade limite de 8 dígitos ou não é um número");
        }
        return strFormatada;
    }
    private static bool VerificarSeEBinario(string numero)
    {
        string value = FormatarEntrada(numero);
        for(int i = 0;i < value.Length;i++)
        {
            if(value.Substring(i,1) != "0" && value.Substring(i, 1) != "1")
            {
                return false;
            }
        }
        return true;
    }

    private static string InverterOrdemDaString(string str)
    {
        return new string(str.Reverse().ToArray());
    }


}

