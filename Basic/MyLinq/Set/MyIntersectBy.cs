namespace Basic.MyLinq.Set;

public class MyIntersectBy
{
    private readonly string[] _words1 = ["the", "quick", "brown", "fox"];
    private readonly string[] _words2 = ["t", "over", "the", "lazy", "dog"];
    
    public void FuncIntersectBy()
    {
        Console.WriteLine("Intersect扩展");
        var result = _words1.IntersectBy(_words2, w => w.Substring(0,1));
        Console.WriteLine(string.Join(",", result));
    }
}