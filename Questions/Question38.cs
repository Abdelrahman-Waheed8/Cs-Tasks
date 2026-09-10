public class Question38
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

        Dictionary<int, int> firstseen = new Dictionary<int, int>();
        int maxDist = 0;
        for(int i = 0; i < size ; i++)
        {
            if(!firstseen.ContainsKey(array[i]))
            {
                firstseen[array[i]] = i;
            }
            else
            {
                int distance = i - firstseen[array[i]] - 1;
                if(distance >maxDist) maxDist = distance;
            }
        }
        Console.WriteLine($"Longest Distance between two equal cells is {maxDist}");
    }
}