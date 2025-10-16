using Basic.MyLinq.Models;

namespace Basic.MyLinq.Projection;

public class MySelectMany
{
    private readonly List<Data> _data =
    [
        new() { Flowers = ["sunflower", "daisy"] },
        new() { Flowers = ["tulip", "rose"] },
        new() { Flowers = ["lily"] },
        new() { Flowers = ["larkspur", "lilac"] }
    ];
    private readonly List<string> _phrases = ["an apple a day", "the quick brown fox"];
    private readonly List<int> _numbers = [1, 2, 3];
    private readonly List<string> _letters = ["1a", "2b", "3c"];

    public void FuncSelectMany()
    {
        Console.WriteLine("展开花朵列表：");
        var dataSelectMany = _data.SelectMany(d => d.Flowers).ToList();
        dataSelectMany.ForEach(Console.WriteLine);


        var phrasesSelectMany = _phrases.SelectMany(phrase => phrase.Split(' ')).ToList();
        phrasesSelectMany.ForEach(Console.WriteLine);

        var numbersSelectMany = _numbers
            .SelectMany(number => _letters, (number, letter) => (number, letter))
            .ToList();
        numbersSelectMany.ForEach(x => Console.WriteLine($"({x.number}, {x.letter})"));
    }
}