using System.IO;

Guitar guitar = new Guitar();
int sa;

Console.WriteLine("How many string would you like to have on your guitar?");
Console.WriteLine("You can choose between 6, 7, 8 or 9 strings:");
string? stringAmountInput = Console.ReadLine();
bool validAnswer = int.TryParse(stringAmountInput, out sa);
guitar.stringAmount = sa;
Console.Clear();


Console.WriteLine("Would you like to use a drop-tuning? (Y/N)");
string? yesNo = Console.ReadLine();
ConsoleKey key = Console.ReadKey().Key;
while (key != ConsoleKey.Y || key != ConsoleKey.N)
{
    Console.Clear();
    
    if (key == ConsoleKey.Y)
    {
        Console.WriteLine("What drop tuning would you like to use?");
        Console.WriteLine("You can choose between Drop D, Drop C, Drop B and Drop A:");
        guitar.tuning = Console.ReadLine();
    }
    else if (key == ConsoleKey.N)
    {
        Console.WriteLine("What standard tuning would you like to use?");
        Console.WriteLine("You can choose between E, D#, D, C#, C, B, A#, A and F#:");
        guitar.tuning = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Please press Y (yes) or N (no) to continue.");
        Console.WriteLine();
    }
}



Console.WriteLine("What color would you like to have on your guitar?");
guitar.color = Console.ReadLine();



Console.ReadLine();