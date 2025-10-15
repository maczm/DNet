namespace Basic.MyLinq.Set;

public class MyExceptBy
{
    private readonly string[] _words1 = ["the", "quick", "brown", "fox"];
    private readonly string[] _words2 = ["jumped", "over", "the", "lazy", "dog"];
    
    public void FuncExceptBy()
    {
        var dataExceptBy = _words1.ExceptBy(_words2, word => word).ToList();
        dataExceptBy.ForEach(Console.WriteLine);
    }
}