namespace Basic.MyLinq.Set;

public class MyDistinctBy
{
    private readonly string[] _words = ["the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"];

    public void FuncDistinctBy()
    {
        Console.WriteLine("Distinct扩展：");
        var distinctByWords = _words.DistinctBy(w => w.Length).ToList();
        distinctByWords.ForEach(Console.WriteLine);
    }
}