

//Projekt gra

Console.WriteLine("╔════════════════════════════════╗");
Console.WriteLine("║         The Adventurer         ║");
Console.WriteLine("╠════════════════════════════════╣");
Console.WriteLine("║  Witaj w grze!                 ║");
Console.WriteLine("║  Nazwij swoją postać:          ║");
Console.WriteLine("╚════════════════════════════════╝");

string name = Console.ReadLine();


Console.WriteLine("╔════════════════════════════════╗");
Console.WriteLine("║         The Adventurer         ║");
Console.WriteLine("╠════════════════════════════════╣");
Console.WriteLine($"║  Witaj {name}        \t\t║");
Console.WriteLine("║  Wybierz swoją klasę:          ║");
Console.WriteLine("║  1. Wojownik                   ║");
Console.WriteLine("║  2. Mag                        ║");
Console.WriteLine("╚════════════════════════════════╝");

int classChoice = int.Parse(Console.ReadLine());

int strength = 0;
int intelligence = 0;

if (classChoice == 1)
{
    strength = 100;
    intelligence = 50;
    Console.WriteLine("Wybrałeś klasę Wojownik! Tak wygląda Twoja karta postaci:");
}
else if (classChoice == 2)
{
    strength = 50;
    intelligence = 100;
    Console.WriteLine("Wybrałeś klasę Mag! Tak wygląda Twoja karta postaci:");
}
else
{
    Console.WriteLine("Wybrałeś niepoprawną klasę postaci! Domyślnie przypisano Ci klasę Wojownik.");
    strength = 100;
    intelligence = 50;
}

int health = 20 + strength;
int mana = 20 + intelligence;

Console.WriteLine("╔════════════════════════════════╗");
Console.WriteLine("║         The Adventurer         ║");
Console.WriteLine("╠════════════════════════════════╣");
Console.WriteLine("║         Karta Postaci          ║");
Console.WriteLine("╠════════════════════════════════╣");
Console.WriteLine($"║  Imię: {name,-20}\t ║");
Console.WriteLine($"║  Klasa: {(classChoice == 1 ? "Wojownik" : "Mag"),-18}\t ║");
Console.WriteLine($"║  Siła: {strength,-20}\t ║");
Console.WriteLine($"║  Inteligencja: {intelligence,-15} ║");
Console.WriteLine($"║  Zdrowie: {health,-18}\t ║");
Console.WriteLine($"║  Mana: {mana,-21}\t ║");
Console.WriteLine("╚════════════════════════════════╝");