// Ett litet namnregister


Console.Clear();
Console.WriteLine("Ett litet namnregister");

List<string> namnlista = [];

// Programloopen
while (true)
{
    // Visa/skapa en meny.
    Console.Write("""
1. Registrera namn
2. Skriva ut alla namn
3. Avsluta
Ange ditt val: 
""");
    string val = Console.ReadLine();

    // Läs in namn i register.
    if (val == "1")
    {
        Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);
    }
    // Skriver ut alla namn.
    else if (val == "2")
    {
        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet}, ");
        }
            Console.WriteLine();
        }
    // Om val 3 så avslutas programen.
    else if (val == "3")
    {
        break;
    }
}