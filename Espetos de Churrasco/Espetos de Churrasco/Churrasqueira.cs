using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetos_de_Churrasco
{
    public static class Churrasqueira
    {
        public static (int espetoDeCarne, int espetoVegetariano) QuantidadeDeTiposDeEspeto(string[] churrasqueira)
        {
            int espetoVegetariano = 0;
            int espetoDeCarne = 0;

            foreach(var espeto in churrasqueira)
            {
                if (EhEspetoDeCarne(espeto))
                {
                    espetoDeCarne += 1;
                }
                else
                {
                    espetoVegetariano += 1;
                }
            }

            return(espetoDeCarne, espetoVegetariano);
        }

        private static bool EhEspetoDeCarne(string espeto)
        {
            return espeto.Contains("x");
        }
    }
}
