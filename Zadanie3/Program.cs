Console.Write("Podaj wiek: ");
int wiek = int.Parse(Console.ReadLine());



if (wiek < 0)
{
    Console.WriteLine("Wiek nie moze byc ujemny");
}
else if (wiek < 13)
{
    Console.WriteLine("Kategoria: Dziecko");
}
else if (wiek < 18)
{
    Console.WriteLine("Kategoria: Nastolatek");
}
else if (wiek < 64)
{
    Console.WriteLine("Kategoria: Dorosły");
}
else


{
    Console.WriteLine("Kategoria: Senior" );
}