// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int l;
string liczba, haslo;

Console.WriteLine("Podaj tekst do zakodowania:");
haslo = Console.ReadLine() ?? "";
Console.WriteLine("Podaj liczbe jako klucz:");
liczba = Console.ReadLine() ?? "";
l = int.Parse(liczba);

for (int i = 0; i < haslo.Length; i++)
{
    int wartoscLitery = (int)haslo[i];
    wartoscLitery = wartoscLitery + l;
    if (wartoscLitery <= 90)
    {

        char wartoscLiterye = Convert.ToChar(wartoscLitery);
        Console.WriteLine(wartoscLiterye);
    }
    else
    if (wartoscLitery > 90)
    {
        wartoscLitery = wartoscLitery - 26;
        char wartoscLiterye = Convert.ToChar(wartoscLitery);
        Console.WriteLine(wartoscLiterye);
    } while (wartoscLitery > 90) ;
}
