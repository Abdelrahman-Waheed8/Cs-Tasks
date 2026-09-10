public class Question33
{
    public static void Run()
    {
        Console.Write("Enter array size: ");
        int size;
        while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Enter positive number for array size: ");
        }
    
        int[] array = new int[size];
        for(int i = 0; i < size ; i++)
        {
            Console.Write($"Enter element [{i+1}]: ");
            int.TryParse(Console.ReadLine(), out array[i]);
        }

        int sum = 0;
        for(int i = 0; i < size ; i++)
        {
            sum += array[i];
        }
        Console.WriteLine($"Sum of all elements: {sum}");
    }
}