using System;

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int firstPosition = name.IndexOf("F");
      char firstLetter = name[firstPosition];

      // Get last name
      int lastNamePosition = name.IndexOf("Abbasi");
      string lastName = name.Substring(lastNamePosition);

      // Print results
      Console.WriteLine(firstLetter);
      Console.WriteLine(lastName);

    }
  }
}
