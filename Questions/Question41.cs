public class Question41
{
    public static void Run()
    {
        Console.Write("Enter Array Size: ");
        int size;
        while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write("Enter positive number for array size: ");
        }
    
        int[] array = new int[size];
        for(int i = 0; i < size ; i++)
        {
            Console.Write($"Enter element [{i+1}]: ");
            int.TryParse(Console.ReadLine(), out array[i]);
        }

        Console.WriteLine("Array in inputted order: ");
        for(int i = 0 ; i < size ; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("\nArray in reverse order: ");
        for(int i = size - 1; i >= 0 ; i--)
        {
            Console.Write($"{array[i]} ");
        }
    }
}