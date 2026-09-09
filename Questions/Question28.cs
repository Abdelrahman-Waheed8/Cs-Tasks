using System.Globalization;

public class Question28
{
    public static void Run()
    {
        Console.Write("Enter starting number: ");
        int.TryParse(Console.ReadLine(), out int start);
        Console.Write("Enter ending number: ");
        int.TryParse(Console.ReadLine(), out int end);

        for(int i = start; i <= end; i++)
        {
            if(i <= 1) continue;
            if(i == 2) {Console.Write($"{i} "); continue;}
            if(i % 2 == 0) continue;
            
            int limit = (int)Math.Sqrt(i);
            int j;
            for(j = 3; j <= limit ; j += 2)
            {
                if(i % j ==0) break;
            }
            if(j > limit)
            {
                Console.Write($"{i} ");
            }
        }
    }
}