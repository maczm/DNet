namespace Basic.MyLinq.Set;

public class MyDistinct
{
    private readonly string[] _words = ["the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"];

    public void FuncDistinct()
    {
        Console.WriteLine("去重：");
        var distinctWords = _words.Distinct().ToList();
        distinctWords.ForEach(Console.WriteLine);
    }
}