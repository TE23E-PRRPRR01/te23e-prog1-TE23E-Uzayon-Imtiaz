// Spelet - gissa ett slumptak 1-100
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptak 1-100");

// En variabel för att hålla koll på antal gissningar
int antal = 0;

// Be användaren ange slumptalets gränser med min och max
Console.WriteLine("Ange slumptalets min-värde: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Ange slumptalets max-värde: ");
int max = int.Parse(Console.ReadLine());

int slumptal = Random.Shared.Next(min,max+1);

// Upprepning - loop
while (true)
{
    // Ställ frågan till användaren
    Console.Write($"Gissa ett tal ({min-max}): ");
    int gissning = int.Parse(Console.ReadLine());

    //Räkna upp antal med 1
    antal++;

    // Kontroll om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat på {antal} gånger!");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }

    //Vill användaren gissa en gång till?
    Console.WriteLine("Vill du gissa en gång till? (j/n): ");
    string svar = Console.ReadLine();
    if (svar == "n")
    {
    break;
    }
}

// Slut på spelet
Console.WriteLine("Slut, Tack för att du spelade min fina spel!");