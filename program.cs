using System.Net.Security;

namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello. Git!");
        Console.WriteLine(DoSomething("Michael"));
    }

    static string DoSomething(string name)
    {
        return $"Hello {name}";
    }
}