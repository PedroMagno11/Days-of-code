using Espetos_de_Churrasco;

string[] espetos = new string[]
{ 
    "--oooo-ooo--", 
    "--xx--x--xx--", 
    "--o---o--oo--", 
    "--xx--x--ox--", 
    "--xx--x--ox--"
};

(int quantEspetosDeCarne, int quantEspetosVegetarianos) = Churrasqueira.QuantidadeDeTiposDeEspeto(espetos);

foreach (var espeto in espetos)
{
    Console.WriteLine(espeto);
}
Console.Write(" ->");
Console.WriteLine($"[{quantEspetosVegetarianos} espetos vegetarianos, {quantEspetosDeCarne} espetos de carne]");