public class Question18
{
    public static void Run()
    {
        char[] vowels = {'a', 'i', 'e', 'o', 'u'};
        Console.Write("Enter character: ");
        char.TryParse(Console.ReadLine(), out char c);
        if(vowels.Contains(c)) Console.WriteLine("Vowel");
        else Console.WriteLine("Consonant");
    }
}