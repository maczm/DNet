namespace Basic.Linqs;

internal class Linqs
{
    List<int> LinqList = new List<int>();
    public Linqs()
    {
        for (int i = 0; i < 100; i++)
        {
            LinqList.Add(i);
        }
    }
    public static void BakLinq()
    {
        Linqs linqs = new Linqs();
        var evenNumbers = from num in linqs.LinqList
                          where num % 2 == 0
                          select num;
        Console.WriteLine("[" + string.Join(", ", evenNumbers) +"]");
        int[] evenNumbersList = [.. evenNumbers];
    }
    public static void Linq()
    {

    }
}
