namespace Basic.MyLinq;

public static class MyDistinct
{
    public static void FuncDistinct()
    {
        Console.WriteLine("去重：");
        string[] words = ["the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"];
        var distinctWords = words.Distinct().ToList();
        distinctWords.ForEach(Console.WriteLine);
    }
}