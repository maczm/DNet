namespace Basic.MyLinq;

internal static class MyZip
{
    public static void FuncZip()
    {
        Console.WriteLine("将数字、字母和表情符号组合：");
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8];
        List<string> letters = ["1a", "2b", "3c", "4d", "5e", "6f", "7g", "8h"];
        List<string> emoji = ["🤓", "🔥", "🎉", "👀", "⭐", "💜", "✔", "💯"];
        var zip = numbers.Zip(letters, emoji).ToList();
        zip.ForEach(x => Console.WriteLine($"[{string.Join(", ", x)}]"));
    }
}