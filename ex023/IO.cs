using System;

namespace ex023
{
  public class IO
  {
    public string Input(string msg)
    {
      Console.Write(msg);
      return Console.ReadLine();
    }

    public void Print(string msg)
    {
      Console.WriteLine(msg);
    }

    public void Clear()
    {
      Console.Clear();
    }
  }
}
