using System.Net.Security;

namespace simpleGit;

class program
{
    static void main()
    {
        Console.WriteLine("Hello. Git!");
        Console.WriteLine(DoSomething("Michael"));
    }

    static string DoSomething(string name)
    {
        return $"Hello {name}";
    }
}