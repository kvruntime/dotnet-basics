using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using StringClasslib.Utilities;


namespace ConsoleApp;

public partial class Runners
{
  public static void Requiring()
  {
    Console.Write("Enter your name: ");
    var name = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(name))
    {
      Console.WriteLine("Invalid name provided, program exit...");
      Environment.Exit(0);
    }

    name = StringOperations.StartsWithUpper(name) ? name : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
    Console.WriteLine($"Hello {name} at {DateTime.UtcNow:d} on {DateTime.Now:t}");
  }

  public static void ProgramPrompter()
  {
    Console.WriteLine($"{Environment.NewLine}Press any key...");
    Console.ReadKey(true);
  }
}
