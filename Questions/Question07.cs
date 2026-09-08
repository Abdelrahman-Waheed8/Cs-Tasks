public class Question07
{
    public static void Run()
    {
        string s1 = "C-sharp";
        string s2 = "basics";
        string concatenated = string.Join(" ", s1,s2);
        Console.WriteLine(concatenated);
    }
}