public class Question35
{
    public static void Run()
    {
        Dictionary<int, int> hashmap = new Dictionary<int, int>(); // (item , frequency)
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
        
        for(int i = 0; i < size; i++)
        {
            if(!hashmap.ContainsKey(array[i])) 
            {
                hashmap[array[i]] = 1;
            }
            else
            {
                hashmap[array[i]]++; // yezawed el freq by 1
            }
        }

        Console.WriteLine("\nFrequency for each array element: ");
        foreach(var kvp in hashmap)
        {
            Console.WriteLine($"{kvp.Key} was found {kvp.Value} time(s)");
        }
    }
}