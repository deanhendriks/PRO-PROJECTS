using System;

namespace Scope
{
    class Program
    {
    public string helloClass = "Hello, class!";

    static void Main(string[] args)
    {
        string helloLocal = "Hello, local!";
        Console.WriteLine(helloLocal);
    
        DoStuff();
    }

    static void DoStuff()
    {
        Console.WriteLine("A message from DoStuff: " + Program.helloClass);
    }
    }
}