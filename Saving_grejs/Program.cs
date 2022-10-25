using System.IO;
using System.Text.Json;

// string read = File.ReadAllText("guitar.json");
// Guitar readGuitar = JsonSerializer.Deserialize<Guitar>(read);

int sa;
string tune;
string col;


Console.WriteLine("How many string would you like to have on your guitar?");
Console.WriteLine("You can choose between 6, 7, 8 or 9 strings:");
string? stringAmountInput = Console.ReadLine();
bool validAnswer = int.TryParse(stringAmountInput, out sa);
Console.Clear();


Console.WriteLine("Would you like to use a drop-tuning? (Y/N)");
ConsoleKey key = Console.ReadKey().Key;
Console.Clear();
  
if (key == ConsoleKey.Y)
{
    Console.WriteLine("What drop tuning would you like to use?");
    Console.WriteLine("You can choose between Drop D, Drop C, Drop B and Drop A:");
    tune = Console.ReadLine();
}
else if (key == ConsoleKey.N)
{
    Console.WriteLine("What standard tuning would you like to use?");
    Console.WriteLine("You can choose between E, D#, D, C#, C, B, A#, A and F#:");
    tune = Console.ReadLine();
}
else
{
    tune = "null";
}
Console.Clear();



Console.WriteLine("What color would you like to have on your guitar?");
col = Console.ReadLine();
Console.Clear();

Guitar guitar = new Guitar()
{
    stringAmount = sa,
    tuning = tune,
    color = col
};

string serialize = JsonSerializer.Serialize<Guitar>(guitar);
File.WriteAllText("guitar.json", serialize);



Console.WriteLine("You have successfully customized your guitar. Press any ENTER to exit.");


Console.ReadLine();