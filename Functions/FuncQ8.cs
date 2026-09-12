using System.IO.Pipelines;

public class FuncQ8
{
    public static string ChangeChar(string st, int position, char ch)
    {
        if(position < 0 || position >= st.Length || string.IsNullOrEmpty(st))
        {
            return "Invalid position or string might be null or empty";
        }

        char[] stringChar = st.ToCharArray();
        stringChar[position] = ch;

        return new string(stringChar);
    }
    public static void Run()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine() ?? "";

        Console.Write("Enter position to be modified: ");
        int.TryParse(Console.ReadLine(), out int pos);
    
        Console.Write("Enter new character: ");
        char.TryParse(Console.ReadLine(), out char newCharacter);

        Console.WriteLine($"New string: {ChangeChar(str, pos, newCharacter)}");
    }
}