// Program för att regristrera förnamn och efternamn.
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Write("Program för att regristrera förnamn och efternamn");
Console.WriteLine("Ange förnamn: ");
string Förnamn = Console.ReadLine();
Console.WriteLine("Ange efternamn: ");
string Efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + Förnamn + " " + Efternamn);
Console.WriteLine($"Hej! {Förnamn} {Efternamn} ");