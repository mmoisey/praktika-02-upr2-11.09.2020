using System;

namespace praktika_02_upr2_11._09._2020
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "Microsoft .NET Framework 2 Application Development Foundation";
      string[] sa = s.Split("");
      Array.Sort(sa);
      s = string.Join(" ", sa); 
      Console.WriteLine(s);
    }
  }
}
