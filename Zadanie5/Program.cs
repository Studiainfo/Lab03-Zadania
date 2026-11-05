﻿Console.Write("HP:");
string wpisanaLiczba = Console.ReadLine()!;
int hp1 = int.Parse(wpisanaLiczba);

Console.Write("Obrazenia broni:");
string wpisanaLiczba2 = Console.ReadLine()!;
double obrazenia = double.Parse(wpisanaLiczba2);

Console.Write("Czy bohater ma miksture, (tak/nie):");
string wpisanyTekst = Console.ReadLine()!;
bool maMiksture = (wpisanyTekst == "tak");




if (hp1 <= 0)
{
    Console.WriteLine("Bohater nie zyje");
}
else if (hp1 < 25)
{
    Console.WriteLine("Niski poziom zdrowia czy uzyć miksture");
}

Console.Write("Wybierz akcje: 1 - atak, 2 - leczenie, 3 - ucieczka");
string wpisanaLiczba3 = Console.ReadLine()!;
int wybor = int.Parse(wpisanaLiczba3);



switch (wybor)
{
    case 1:
    Console.WriteLine($"{obrazenia} dmg");
    break;
    case 2:
    if (maMiksture)
        {
            Console.WriteLine("Można się uleczyć");
        }
        else
        {
            Console.WriteLine("Nie masz leczącej mikstury");
        }
    break;
    case 3:
    Console.WriteLine("Zaczynasz ucieczke");
    break;
    default:
    Console.WriteLine("Nieznana akcja");
    break;
}
