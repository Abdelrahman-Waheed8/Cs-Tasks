public class Question31
{
    public static void Run()
    {
        Console.Write("Enter time taken for a task: ");
        double.TryParse(Console.ReadLine(), out double hours);

        if(hours < 0) Console.WriteLine("Invalid input");
        else if(hours >= 2 && hours <= 3) Console.WriteLine("Highly efficient");
        else if(hours >= 3 && hours <= 4) Console.WriteLine("Increase your speed");
        else if(hours >= 4 && hours <= 5) Console.WriteLine("You need training");
        else if(hours > 5) Console.WriteLine("Fired");
    }
}