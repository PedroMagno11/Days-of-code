using JohnnyProgresso;


int[] milhasPercorridas = { 1, 2, 3, 2, 3 };
int quantProgresso = Progresso.GetDiasDeProgresso(milhasPercorridas);
Console.WriteLine($"Total de progressos de Johnny: {quantProgresso}");