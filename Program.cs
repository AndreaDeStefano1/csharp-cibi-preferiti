// See https://aka.ms/new-console-template for more information


// array pari
string[] classificaCibi = { "Margherita", "Genovese", "Ragù", "Amatriciana", "Bolognese", "Pesto" }; 

// array dispari
// string[] classificaCibi = { "Margherita", "Genovese", "Ragù",  "Bolognese", "Pesto" }; 

Console.WriteLine("La lunghezza della classifica è " + classificaCibi.Length);

for (int i = 0; i < classificaCibi.Length; i++)
{
    Console.WriteLine((i + 1) + " - " + classificaCibi[i]);
}


Console.WriteLine("Il mio cibo preferito top è " + classificaCibi[0]);

Console.WriteLine("Il mio cibo preferito non top è " + classificaCibi[classificaCibi.Length - 1]);


if(classificaCibi.Length % 2 != 0)
{
    Console.WriteLine("La posizione centrale della classifica è " + classificaCibi[classificaCibi.Length / 2]);
}else
{
    Console.WriteLine("Le posizioni centrali della classifica sono " + classificaCibi[classificaCibi.Length / 2] + " e " + classificaCibi[(classificaCibi.Length / 2) - 1]);

}



