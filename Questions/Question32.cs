using System.Drawing;

public class Question32
{
    public static void Run()
    {
        Console.Write("Enter matrix size: ");
        int size;
        while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Invalid size! enter number bigger than 0: ");
        }

        for(int i = 0; i < size ; i++)
        {
            for(int j = 0; j < size ; j++)
            {
                if(i == j)Console.Write(" 1 ");
                else Console.Write(" 0 ");
            }
            Console.WriteLine();
        }
    }
}