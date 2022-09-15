// See https://aka.ms/new-console-template for more information

string[] classificaCibi = { "Margherita", "Genovese", "Ragù", "Bolognese", "Pesto" };

Console.WriteLine("La lunghezza della classifica è " + classificaCibi.Length);

for (int i = 0; i < classificaCibi.Length; i++)
{
    Console.WriteLine(i + " - " + classificaCibi[i]);
}


Console.WriteLine("Il mio cibo preferito top è " + classificaCibi[0]);

Console.WriteLine("Il mio cibo preferito non top è " + classificaCibi[classificaCibi.Length - 1]);

