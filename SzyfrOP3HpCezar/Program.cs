// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Podaj tekst w wielkich literach od A do Z, aby zakodowac je szyfru cezara:");
string haslo = Console.ReadLine() ?? "";
Console.WriteLine("Podaj liczbe jako klucz dla szyfru:");
string liczba = Console.ReadLine() ?? "";
int l = int.Parse(liczba);

for (int e = 0; e < haslo.Length; e++)  
{
    int wartosc = (int)haslo[e];
    Console.WriteLine(wartosc);
    wartosc =+ l;
    if ((int)haslo[e] > 90)
    {
    wartosc =- 25;
    Console.WriteLine(wartosc);
    } while (wartosc > 90)
    if ((int)haslo[e] <= 90)
    {
        Console.WriteLine(wartosc);
    }
    if ((int)haslo[e] < 35)
    {
        Console.WriteLine("Blednie zostaly podane informacje.");
    }
}