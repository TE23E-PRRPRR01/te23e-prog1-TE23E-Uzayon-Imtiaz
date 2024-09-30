// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur ett kortlek!");

// Ett annat exemple. Lista på 3 årtal
// List<int> årtal = [1957, 1969, 1989];

// Skapa en lista kort
// List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "Sexa", "Sjunde", "Åtta", "Nia", "Tia", "Knekt", "Dam", "Kung"];
//List<string> kortlek = ["🂡 ♠", "🂢 ♠ ", "🂣 ♠", "🂤 ♠", "🂥 ♠", "🂦 ♠", "🂧 ♠", "🂨 ♠", "🂩 ♠", "🂪 ♠", "🂫 ♠", "🂭 ♠", "🂮 ♠"];
List<string> kortlek = ["🂡 ♠", "🂢 ♠", "🂣 ♠", "🂤 ♠", "🂥 ♠", "🂦 ♠", "🂧 ♠", "🂨 ♠", "🂩 ♠", "🂪 ♠", "🂫 ♠", "🂭 ♠", "🂮 ♠"];

int antal = 5;
while (antal > 0)
{
	// Slumpa index 0-12
	int index = Random.Shared.Next(0, kortlek.Count);
	//Console.WriteLine($"Det slumpade index = {index}");

	// Plocka ut det sjunde kortet, index = 6
	string kort = kortlek[index];

    // Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

	// Skriv ut 7:e kortet
	Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal--;
}