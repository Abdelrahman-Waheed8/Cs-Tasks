public class Question26
{
    public static void Run()
    {
        Console.Write("Enter String to Reverse: ");
        string Input = Console.ReadLine() ?? "";
        string Reversed = "";

        for(int i=Input.Length - 1; i >= 0 ; i--)
        {
            Reversed += Input[i];
        }
        Console.WriteLine($"Reversed String: {Reversed}");
    }
}