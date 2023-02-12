// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
foreach (string s in GetStrings())
{
    Console.WriteLine(s);
}
Console.WriteLine("Klart");

static IEnumerable<string> GetStrings()
{
    foreach (string s in new string[] { "Ett", "Två", "Tre" })
    {
        yield return s;
        Task.Delay(3000).Wait();
    }
}
