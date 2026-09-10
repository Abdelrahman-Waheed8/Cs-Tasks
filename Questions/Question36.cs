public class Question36
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

        int max = array[0]; 
        int min = array[0];
        for(int i =0; i < size; i++)
        {
            if(max < array[i]) max = array[i];
            if(min > array[i]) min = array[i];
        }

        Console.WriteLine($"Maximum in array: {max}\nMinimum in array: {min}");
    }
}