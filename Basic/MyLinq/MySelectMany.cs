namespace Basic.MyLinq;

internal static class MySelectMany
{
    public static void FuncSelectMany()
    {
        Console.WriteLine("Linq SelectMany ============================================================================= END");
        List<Data> data =
        [
            new() { Flowers = ["sunflower", "daisy"] },
            new() { Flowers = ["tulip", "rose"] },
            new() { Flowers = ["lily"] },
            new() { Flowers = ["larkspur", "lilac"] }
        ];
        var dataSelectMany = data.SelectMany(d => d.Flowers).ToList();
        dataSelectMany.ForEach(Console.WriteLine);


        List<string> phrases = ["an apple a day", "the quick brown fox"];
        var phrasesSelectMany = phrases.SelectMany(phrase => phrase.Split(' ')).ToList();
        phrasesSelectMany.ForEach(Console.WriteLine);

        List<int> numbers = [1, 2, 3];
        List<string> letters = ["1a", "2b", "3c"];
        var numbersSelectMany = numbers.SelectMany(number => letters, (number, letter) => (number, letter)).ToList();
        numbersSelectMany.ForEach(x => Console.WriteLine($"({x.number}, {x.letter})"));
    }
}