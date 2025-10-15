namespace Basic.MyLinq.Projection;

public class MyZip
{
    private readonly List<int> _numbers = [1, 2, 3, 4, 5, 6, 7, 8];
    private readonly List<string> _letters = ["1a", "2b", "3c", "4d", "5e", "6f", "7g", "8h"];
    private readonly List<string> _emoji = ["🤓", "🔥", "🎉", "👀", "⭐", "💜", "✔", "💯"];
    public void FuncZip()
    {
        Console.WriteLine("将数字、字母和表情符号组合：");
        var zip = _numbers.Zip(_letters, _emoji).ToList();
        zip.ForEach(x => Console.WriteLine($"[{string.Join(", ", x)}]"));
    }
}