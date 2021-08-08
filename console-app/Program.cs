using System;
using domino.models;

namespace console_app
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Domino games!");
      DominoSet dominoSet = new DominoSet(6);

      Console.WriteLine(dominoSet);
    }
  }
}
