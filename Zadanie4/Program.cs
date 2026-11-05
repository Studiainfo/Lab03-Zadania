Console.Write("Podaj zdrowie: ");
int zdrowie = int.Parse(Console.ReadLine()!);

Console.Write("Czy bohater ma klucz (y/n): ");
string odpowiedz = Console.ReadLine()!;
bool maKlucz = odpowiedz == "y";

Console.Write("Czy zna hasło (y/n): ");
string odpowiedz2 = Console.ReadLine()!;
bool znaHaslo = odpowiedz2 == "y";





if (zdrowie <= 0)
{
    Console.WriteLine("Bohater nie zyje");
}
else if (zdrowie > 0 && (znaHaslo || maKlucz))
{
    Console.WriteLine("Bohater może wejść");
}
else
{
    Console.WriteLine("Bohater nie może wejśc");
}