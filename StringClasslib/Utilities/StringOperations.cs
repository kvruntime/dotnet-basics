using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringClasslib.Utilities;

public static class StringOperations
{
  public static bool StartsWithUpper(this string? str)
  {
    if (string.IsNullOrWhiteSpace(str))
      return false;
    char ch = str[0];
    return char.IsUpper(ch);
  }
}
