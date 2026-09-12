public class FuncQ6
{
    public static void MaxMinArr(int[] arr, out int max, out int min)
    {
        max = arr[0];
        min = arr[0];
        for(int i = 0; i<arr.Length;i++)
        {
            if (max < arr[i]) max = arr[i];
            if (min > arr[i]) min = arr[i];
        }
    }
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

        MaxMinArr(array , out int max, out int min);
        Console.WriteLine($"Max: {max}, Min: {min}");
    }
}