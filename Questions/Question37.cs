public class Question37
{
    public static void Run()
    {
        Console.Write("Enter Array Size: ");
        int size;
        while(!int.TryParse(Console.ReadLine(), out size) || size < 2)
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
        int secondmax = 0;
        bool hasSecondMax = false;

        for(int i =0; i < size; i++)
        {
            if(max < array[i])
            {
                secondmax = max;
                max = array[i];
                hasSecondMax = true;
            }
            else if(secondmax < array[i] && (!hasSecondMax || array[i] > secondmax))
            {
                secondmax = array[i];
                hasSecondMax = true;
            }
        }
        if(!hasSecondMax)
            Console.WriteLine("There is no distinct second-largest number.");
        else
            Console.WriteLine($"The second-largest number is: {secondmax}");
    }
}