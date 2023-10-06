using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleApp;
using ConsoleApp.Models;


User victor = new() { Name = "Viktor", Email = "viktor@gmail.com" };
var r=JsonSerializer.Serialize(victor, UserSerializer.Default.User);
Console.WriteLine(r);
// Runners.Requiring();


Runners.ProgramPrompter();