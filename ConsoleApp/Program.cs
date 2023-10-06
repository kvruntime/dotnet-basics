using StringClasslib.Utilities;



Console.Write("Enter your name: ");
var name = Console.ReadLine();
if (String.IsNullOrWhiteSpace(name) || !StringOperations.StartsWithUpper(name))
{
  Console.WriteLine("Invalid name provided, program exit...");
  Environment.Exit(0);
}

Console.WriteLine($"Hello {name} at {DateTime.UtcNow:d} on {DateTime.Now:t}");
Console.WriteLine($"{Environment.NewLine}Press any key...");

Console.ReadKey(true);