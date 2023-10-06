using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp.Models;

public class User
{
  public string Name { get; set; }
  public string Email { get; set; }
}



[JsonSerializable(typeof(List<User>))]
public sealed partial class UserSerializer : JsonSerializerContext { }
