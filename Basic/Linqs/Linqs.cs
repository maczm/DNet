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
        List<string> phrases = ["an apple a day", "the quick brown fox"];
        Console.WriteLine("\n");

        Console.WriteLine("Linq SelectMany ============================================================================= END");
        var query = phrases.SelectMany(phrase => phrase.Split(' '));
        Console.WriteLine("[" + string.Join(", ", query) + "]");
        Console.WriteLine("\n");

        Console.WriteLine("Linq SelectMany ============================================================================= END");
        List<int> numbers = [1, 2, 3];
        List<char> letters = ['a', 'b', 'c', 'd'];
        var crossJoin = numbers
            .SelectMany(number => letters,
            (number, letter) => (number, letter));
        Console.WriteLine("[" + string.Join(", ", crossJoin) + "]");
        Console.WriteLine("\n");

        Console.WriteLine("Linq Zip ==================================================================================== END");
        var a = numbers.Zip(letters);
        Console.WriteLine("[" + string.Join(", ", a) + "]");
        Console.WriteLine("\n");

        // A string array with 8 elements.
        IEnumerable<string> emoji = [ "🤓", "🔥", "🎉", "👀", "⭐", "💜", "✔", "💯"];
    }
}