Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.Write("Podaj kierunek podróży:");
string kierunek = Console.ReadLine()!;

switch (kierunek)
{
    case "północ":
    Console.WriteLine("Wyruszasz w strone gór");
    break;
    case "południe":
    Console.WriteLine("Wyruszasz w strone pustyni");
    break;
    case "wschód":
    Console.WriteLine("Wyruszasz w strone lasu");
    break;
    case "zachód":
    Console.WriteLine("Wyruszasz w strone morza");
    break;
    default:
    Console.WriteLine("Podaj poprawny kierunek");
    break;
}
