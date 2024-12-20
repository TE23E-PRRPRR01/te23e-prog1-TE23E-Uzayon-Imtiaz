﻿// Använda listor för att skapa/hantera samlingar.
using Microsoft.VisualBasic;

Console.Clear();

    // Lista på trevliga frukter, t.ex "Äpple", "Apelsin", "Annanas".
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter [0]}, {frukter [1]}, {frukter [2]}");

    // Ändra i listan:
frukter [0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter [0]}, {frukter [1]}, {frukter [2]}");

    // Gå igenom listan = loopa igenom = fråm första till sista.
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

    // Skapa en lista på valfri ska (4st).
    // Skriv ut varje sak på samma rad.
List<string> länder = ["Sverige", "Finland", "Danmark", "Norge"];
Console.WriteLine($"Min landlista: {länder [0]}, {länder [1]}, {länder [2]}, {länder [3]}");
foreach (var land in länder)
{
    Console.WriteLine($"{land}");
}
for (int i = 0; i < länder.Count; i++)
{
    Console.WriteLine($"{länder[i]}");
}

    // Skapa ett register.
Console.Clear();
    // En tom lista.
List<string> namnlista = [];

    // while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

        // Skriv ut hela listan på ett rad.
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}