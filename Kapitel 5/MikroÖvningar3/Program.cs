Console.Clear();
//Maträtter
List<string> listamaträtter = ["Pizza", "Pasta", "Kebab"];
Console.WriteLine("Alla maträtter: ");
foreach (string maträtter in listamaträtter)
{
    Console.WriteLine($"- {maträtter}");
}

List<string> listaårtal = ["1492", "1776", "1914", "1945", "1969"]; 
Console.WriteLine("Alla årtal i listan: ");
foreach (string årtal in listaårtal)
{
    Console.WriteLine($"- {årtal}");
}
List<string> listaÅrtal = ["1492", "1776", "1914", "1945", "1969"]; 
Console.Write("Alla årtal i listan:");
foreach (string årtal in listaÅrtal)
{
    Console.Write($" {årtal}");
}
List<string> listanamn = [];
while (true)
{
    Console.WriteLine("Ange ett namn att lägga till (eller 'avsluta' för att avsluta): ");
    string namn = Console.ReadLine();
    if (namn == "avsluta")
    {
        break;
    }
    listanamn.Add(namn);
}
// Skriv ut alla namn