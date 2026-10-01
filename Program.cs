

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
Console.WriteLine($"║  Witaj {name}                 ║");
Console.WriteLine("║  Wybierz swoją klasę:          ║");
Console.WriteLine("║  1. Wojownik                   ║");
Console.WriteLine("║  2. Mag                        ║");
Console.WriteLine("╚════════════════════════════════╝");
int classChoice = int.Parse(Console.ReadLine());

if (classChoice == 1)
{
    int str = 100;
    int intelligence = 50;
    Console.WriteLine("Wybrałeś klasę Wojownik!");
}
else if (classChoice == 2)
{
    int strength = 50;
    int intelligence = 100;
    Console.WriteLine("Wybrałeś klasę Mag!");
}
else
{
    Console.WriteLine("Nieprawidłowy wybór klasy.");
    return;
}

int health = 20 + strength;
int mana = 20 + intelligence;

Console.WriteLine("╔════════════════════════════════╗");
Console.WriteLine("║         The Adventurer         ║");
Console.WriteLine("╠════════════════════════════════╣");
Console.WriteLine("║         Karta Postaci          ║");
Console.WriteLine("╠════════════════════════════════╣");
Console.WriteLine($"║  Imię: {name}                 ║");
Console.WriteLine($"║  Klasa: {(classChoice == 1 ? "Wojownik" : "Mag")} ║");
Console.WriteLine($"║  Siła: {strength}              ║");
Console.WriteLine($"║  Inteligencja: {intelligence}    ║");
Console.WriteLine($"║  Zdrowie: {health}              ║");
Console.WriteLine($"║  Mana: {mana}                   ║");
Console.WriteLine("╚════════════════════════════════╝");