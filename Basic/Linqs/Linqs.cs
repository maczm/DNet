namespace Basic.Linqs;

internal class Linqs
{
    private readonly List<dynamic> objs = [];

    public Linqs()
    {
        for (int i = 1; i < 100; i++)
        {
            objs.Add(new
            {
                Id = i,
                Name = $"Name {i}",
                Age = i
            });
        }
    }

    public void Linq()
    {
        var Ages= from obj in objs
                  where obj.Age % 2 == 0
                  select obj.Age;
        Console.WriteLine("[" + string.Join(", ", Ages) + "]");
    }

    public void LinqSelect()
    {
        Console.WriteLine("Linq Select ================================================================================= END");
        var names = objs.Select(x => x.Name).ToList();
        Console.WriteLine("[" + string.Join(", ", names) + "]");
        Console.WriteLine("\n");

        Console.WriteLine("Linq SelectMany ============================================================================= END");
        List<string> phrases = ["an apple a day", "the quick brown fox"];
        var query = phrases.SelectMany(phrase => phrase.Split(' '));
        Console.WriteLine("[" + string.Join(", ", query) + "]");
        Console.WriteLine("\n");

        Console.WriteLine("Linq SelectMany ============================================================================= END");
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        List<string> letters = ["1a", "2b", "3c", "4d", "5e", "f", "g", "h"];
        var crossJoin = numbers.SelectMany(number => letters, (number, letter) => (number, letter));
        Console.WriteLine("[" + string.Join(", ", crossJoin) + "]");
        Console.WriteLine("\n");

        Console.WriteLine("Linq Zip ==================================================================================== END");
        List<string> emoji = [ "🤓", "🔥", "🎉", "👀", "⭐", "💜", "✔", "💯"];
        var a = numbers.Zip(letters, emoji);
        Console.WriteLine("[" + string.Join(", ", a) + "]");
        Console.WriteLine("\n");
    }
}