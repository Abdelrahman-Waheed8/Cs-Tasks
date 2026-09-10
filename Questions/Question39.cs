public class Question39
{
    public static void Run()
    {
        Console.Write("Enter Sentence: ");
        string sentence = Console.ReadLine();
        while(string.IsNullOrEmpty(sentence))
        {
            Console.Write("Enter a valid string: ");
            sentence = Console.ReadLine();
        }

        string[] words = sentence.Split();
        string reverse = "";
        for(int i = words.Length-1 ; i >= 0; i--)
        {
            reverse += words[i];
            if(i >0) reverse += " ";
        }
        Console.WriteLine($"Reversed sentence: {reverse}");
    }
}