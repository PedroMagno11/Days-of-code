namespace ConverterIdadeEmDias
{
    public static class Conversor
    {
        public static int IdadeEmDias(int idade)
        {
            if(idade < 0)
            {
                throw new ArgumentException("O número deve ser um inteiro positivo");
            }
            return idade * 365;
        }
    }
}
