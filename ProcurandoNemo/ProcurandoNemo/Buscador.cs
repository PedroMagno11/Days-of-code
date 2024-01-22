using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurandoNemo
{
    public class Buscador
    {
        public static int ProcurandoNemo(string frase)
        {
            string[] palavras = frase.Split(' ');

            for(int i = 0; i< palavras.Length; i++)
            {
                if (palavras[i] == "Nemo" || palavras[i]=="nemo")
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}
