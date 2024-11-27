Console.Clear();
// Lista med 5 namn.
// List<string> listaNamn = ["Obama", "Uzayon", "Emilio", "William", "Love"];
// Console.WriteLine($"Min kompisar är: {string.Join(", ", listaNamn)}");

// Lista med 5 orter.
List<string> listaOrter = ["Göteborg", "Stockholm", "Malmö", "Uppsala", "Lund"];
// Fem orter (Göteborg, Stockholm, Malmö, Uppsala, Lund) ligger i Sverige.
Console.WriteLine($"Fem orter {string.Join(", ", listaOrter)} som ligger i Sverige.");

// Skapa en lista med 5 historisk årtal.
List<int> listaÅrtal = [1989, 1945, 1492, 1776, 1914];
Console.WriteLine($"Fem historiska årtal: '{string.Join("', '", listaÅrtal)}'");

// // Visa första och sista objektet i listan.
// List<string> listaNamn = ["Obama", "Uzayon", "Emilio", "William", "Love"];
// Console.WriteLine("Första namnet: " + listaNamn[0]);
// Console.WriteLine("Sista namnet: " + listaNamn[4]);

// En lista med mina 5 favoritdrycker.
List<string> drycker = ["Pepsi Max", "Fanta Exotic", "Trocadero", "MONSTER", "Sprite"];
Console.WriteLine("1. " + drycker[0]);
Console.WriteLine("2. " + drycker[1]);
Console.WriteLine("3. " + drycker[2]);
Console.WriteLine("4. " + drycker[3]);
Console.WriteLine("5. " + drycker[4]);

// En lista


List<string> listaNamn = ["Obama", "Uzayon", "Emilio", "William", "Love"];
Console.Write("Ange ett namn att lägga till: ");
string nyNamn = Console.ReadLine();
listaNamn.Add(nyNamn);
Console.WriteLine($"Uppdaterad lista: {string.Join} ");
